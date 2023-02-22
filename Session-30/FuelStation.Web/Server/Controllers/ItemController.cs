using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Employee;
using FuelStation.Web.Shared.Item;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class ItemController : ControllerBase {
		private readonly IEntityRepo<Item> _itemRepo;

		public ItemController(IEntityRepo<Item> itemRepo) { 
			_itemRepo = itemRepo;
		}

		[HttpGet]
		[Authorize(Roles = "Staff")]
		public async Task<IEnumerable<ItemListDto>> Get() {
			var result = _itemRepo.GetAll();
			return result.Select(item => new ItemListDto {
				Id = item.Id,
				Code = item.Code,
				Description = item.Description,
				ItemType = item.ItemType,
				Price = item.Price,
				Cost = item.Cost
			});
		}

		[HttpGet("{id}")]
		public async Task<ItemEditDto> GetById(int id) {
			var result = _itemRepo.GetById(id);
			return new ItemEditDto {
				Id = id,
				Code = result.Code,
				Description = result.Description,
				ItemType = result.ItemType,
				Price = result.Price,
				Cost = result.Cost
			};
		}

		[HttpPost]
		public async Task<ActionResult<ItemEditDto>> Post(ItemEditDto item) {

			if (_itemRepo.GetAll().Any(c => c.Code == item.Code)) {
				return BadRequest("CardNumber must be unique");
			}
			var newItem = new Item(item.Code, item.Description, item.ItemType, item.Price, item.Cost);
			_itemRepo.Add(newItem);

			return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, new ItemEditDto {
				Id = newItem.Id,
				Code = newItem.Code,
				Description = newItem.Description,
				ItemType = newItem.ItemType,
				Price = newItem.Price,
				Cost = newItem.Cost
			});
		}

		[HttpPut]
		public async Task<IActionResult> Put(ItemEditDto item) {

			if (_itemRepo.GetAll().Any(item => item.Id != item.Id && item.Code == item.Code)) {
				return BadRequest("CardNumber must be unique");
			}

			var itemToUpdate = _itemRepo.GetById(item.Id);
			itemToUpdate.Code = item.Code;
			itemToUpdate.Description = item.Description;
			itemToUpdate.ItemType = item.ItemType;
			itemToUpdate.Price = item.Price;
			itemToUpdate.Cost = item.Cost;
			_itemRepo.Update(item.Id, itemToUpdate);

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_itemRepo.Delete(id);
		}
	}
}
