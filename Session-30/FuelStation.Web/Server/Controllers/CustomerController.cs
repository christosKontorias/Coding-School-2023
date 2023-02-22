using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase {

		private readonly IEntityRepo<Customer> _customerRepo;

		public CustomerController(IEntityRepo<Customer> customerRepo) {
			_customerRepo = customerRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<CustomerListDto>> Get() {
			var result = _customerRepo.GetAll();
			return result.Select(customer => new CustomerListDto {
				Id = customer.Id,
				Name = customer.Name,
				Surname = customer.Surname,
				CardNumber = customer.CardNumber
			});
		}

		[HttpGet("{id}")]
		public async Task<CustomerEditDto> GetById(int id) {
			var result = _customerRepo.GetById(id);
			return new CustomerEditDto {
				Id = id,
				Name = result.Name,
				Surname = result.Surname,
				CardNumber = result.CardNumber
			};
		}

		[HttpPost]
		public async Task<ActionResult<CustomerEditDto>> Post(CustomerEditDto customer) {
			if (string.IsNullOrWhiteSpace(customer.CardNumber) || !customer.CardNumber.StartsWith("A")) {
				return BadRequest("CardNumber must not be empty and must start with 'A'");
			}

			if (_customerRepo.GetAll().Any(c => c.CardNumber == customer.CardNumber)) {
				var errorMessage = "Card Number must be unique";
				return StatusCode(StatusCodes.Status400BadRequest, new { Error = errorMessage });
			}

			var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
			_customerRepo.Add(newCustomer);

			return CreatedAtAction(nameof(GetById), new { id = newCustomer.Id }, new CustomerEditDto {
				Id = newCustomer.Id,
				Name = newCustomer.Name,
				Surname = newCustomer.Surname,
				CardNumber = newCustomer.CardNumber
			});
		}

		[HttpPut]
		public async Task<IActionResult> Put(CustomerEditDto customer) {
			if (string.IsNullOrWhiteSpace(customer.CardNumber) || !customer.CardNumber.StartsWith("A")) {
				return BadRequest("CardNumber must not be empty and must start with 'A'");
			}


			if (_customerRepo.GetAll().Any(c => c.CardNumber == customer.CardNumber)) {
				var errorMessage = "Card Number must be unique";
				return StatusCode(StatusCodes.Status400BadRequest, new { Error = errorMessage });
			}

			var itemToUpdate = _customerRepo.GetById(customer.Id);
			itemToUpdate.Name = customer.Name;
			itemToUpdate.Surname = customer.Surname;
			itemToUpdate.CardNumber = customer.CardNumber;
			_customerRepo.Update(customer.Id, itemToUpdate);

			return NoContent();
		}


		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_customerRepo.Delete(id);
		}
	}
}
