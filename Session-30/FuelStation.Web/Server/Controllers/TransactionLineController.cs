using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using FuelStation.Web.Shared.TransactionLine;
using Microsoft.AspNetCore.Mvc;


namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class TransactionLineController : ControllerBase {

		private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

		public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo) {
			_transactionLineRepo = transactionLineRepo;
		}


		[HttpGet]
		public async Task<IEnumerable<TransactionLineListDto>> Get() {
			var result = _transactionLineRepo.GetAll();
			return result.Select(transactionLine => new TransactionLineListDto {
				Id = transactionLine.Id,
				Quantity = transactionLine.Quantity,
				ItemPrice = transactionLine.ItemPrice,
				NetValue = transactionLine.NetValue,
				DiscountPercent = transactionLine.DiscountPercent,
				DiscountValue = transactionLine.DiscountValue,
				TotalValue = transactionLine.TotalValue,
				TransactionId = transactionLine.TransactionId,
				ItemId = transactionLine.ItemId,
			});
		}

		[HttpGet("{id}")]
		public async Task<TransactionLineListDto> GetById(int id) {
			var result = _transactionLineRepo.GetById(id);
			return new TransactionLineListDto {
				Id = id,
				Quantity = result.Quantity,
				ItemPrice = result.ItemPrice,
				NetValue = result.NetValue,
				DiscountPercent = result.DiscountPercent,
				DiscountValue = result.DiscountValue,
				TotalValue = result.TotalValue,
				TransactionId = result.TransactionId,
				ItemId = result.ItemId
			};
		}

		[HttpPost]
		public async Task Post(TransactionLineListDto transactionLine) {
			var newTransactionLine = new TransactionLine(transactionLine.Quantity,
				transactionLine.ItemPrice, transactionLine.NetValue, transactionLine.DiscountPercent,
				transactionLine.DiscountValue, transactionLine.TotalValue);
			newTransactionLine.Quantity = transactionLine.Quantity;
			newTransactionLine.ItemPrice = transactionLine.ItemPrice;
			newTransactionLine.NetValue = transactionLine.NetValue;
			newTransactionLine.DiscountPercent = transactionLine.DiscountPercent;
			newTransactionLine.DiscountValue = transactionLine.DiscountValue;
			newTransactionLine.TotalValue = transactionLine.TotalValue;
			//newTransactionLine.TransactionId = transactionLine.TransactionId;
			//newTransactionLine.ItemId = transactionLine.ItemId;
			_transactionLineRepo.Add(newTransactionLine);
		}



		[HttpPut]
		public async Task Put(TransactionLineEditDto transactionLine) {
			var itemToUpdate = _transactionLineRepo.GetById(transactionLine.Id);
			itemToUpdate.Quantity = transactionLine.Quantity;
			itemToUpdate.ItemPrice = transactionLine.ItemPrice;
			itemToUpdate.NetValue = transactionLine.NetValue;
			itemToUpdate.DiscountPercent = transactionLine.DiscountPercent;
			itemToUpdate.DiscountValue = transactionLine.DiscountValue;
			itemToUpdate.TotalValue = transactionLine.TotalValue;
			itemToUpdate.TransactionId = transactionLine.TransactionId;
			itemToUpdate.ItemId = transactionLine.ItemId;
			_transactionLineRepo.Update(transactionLine.Id, itemToUpdate);
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_transactionLineRepo.Delete(id);
		}
	}
}
