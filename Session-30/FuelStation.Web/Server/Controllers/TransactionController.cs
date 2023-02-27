using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Item;
using FuelStation.Web.Shared.Transaction;
using FuelStation.Web.Shared.TransactionLine;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class TransactionController : ControllerBase {
		private readonly IEntityRepo<Transaction> _transactionRepo;

		public TransactionController(IEntityRepo<Transaction> transactionRepo) {
			_transactionRepo = transactionRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<TransactionListDto>> Get() {
			var result = _transactionRepo.GetAll();
			return result.Select(transaction => new TransactionListDto {
				Id = transaction.Id,
				Date = transaction.Date,
				PaymentMethod = transaction.PaymentMethod,
				TotalValue = transaction.TotalValue,
				EmployeeId = transaction.EmployeeId,
				CustomerId = transaction.CustomerId,
				TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLineListDto {
					Id = transactionLine.Id,
					Quantity = transactionLine.Quantity,
					ItemPrice = transactionLine.ItemPrice,
					NetValue = transactionLine.NetValue,
					DiscountPercent = transactionLine.DiscountPercent,
					DiscountValue = transactionLine.DiscountValue,
					TotalValue = transactionLine.TotalValue,
					TransactionId = transactionLine.TransactionId,
					ItemId = transactionLine.ItemId,
					item = new ItemListDto {
						Id = transactionLine.Item.Id,
						Code = transactionLine.Item.Code,
						Description = transactionLine.Item.Description,
						Price = transactionLine.Item.Price,
						Cost = transactionLine.Item.Cost,
						ItemType = transactionLine.Item.ItemType,
					},

				}).ToList()

			}).ToList();
		}

		[HttpGet("{id}")]
		public async Task<TransactionEditDto> GetById(int id) {
			var result = _transactionRepo.GetById(id);
			return new TransactionEditDto {
				Id = id,
				Date = result.Date,
				PaymentMethod = result.PaymentMethod,
				TotalValue = result.TotalValue,
				EmployeeId = result.EmployeeId,
				CustomerId = result.CustomerId,
				//TransactionLines = result.TransactionLines
			};
		}

		[HttpPost]
		public async Task Post(TransactionListDto transaction) {
			//var newTransaction = new Transaction(transaction.PaymentMethod, transaction.TotalValue);

			//newTransaction.EmployeeId = transaction.EmployeeId;
			//newTransaction.CustomerId = transaction.CustomerId;
			//newTransaction.TransactionLines = transaction.TransactionLines;
			var newTransaction = new Transaction(transaction.PaymentMethod, transaction.TotalValue) {
				//Id = transaction.Id,
				Date = transaction.Date,
				EmployeeId = transaction.EmployeeId,
				CustomerId = transaction.CustomerId,
				TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLine(
									transactionLine.Quantity,
									transactionLine.ItemPrice,
									transactionLine.NetValue,
									transactionLine.DiscountPercent,
									transactionLine.DiscountValue, transactionLine.TotalValue) {
					Id = transactionLine.Id,
					TransactionId = transactionLine.TransactionId,
					ItemId = transactionLine.ItemId,
				}).ToList()
			};

			_transactionRepo.Add(newTransaction);
		}

		[HttpPut]
		public async Task Put(TransactionEditDto transaction) {
			var itemToUpdate = _transactionRepo.GetById(transaction.Id);
			if (itemToUpdate is null) {
				return;
			}
			//var itemToUpdate = _transactionRepo.GetById(transaction.Id);

			itemToUpdate.Date = transaction.Date;
			itemToUpdate.PaymentMethod = transaction.PaymentMethod;
			itemToUpdate.TotalValue = transaction.TotalValue;
			itemToUpdate.EmployeeId = transaction.EmployeeId;
			itemToUpdate.CustomerId = transaction.CustomerId;
			itemToUpdate.TransactionLines = transaction.TransactionLines
				.Select(transactionLine => new TransactionLine(
					transactionLine.Quantity,
					transactionLine.ItemPrice,
					transactionLine.NetValue,
					transactionLine.DiscountPercent,
					transactionLine.DiscountValue,
					transactionLine.TotalValue) {
					ItemId = transactionLine.ItemId,
					TransactionId = transactionLine.TransactionId,
					Id = transactionLine.Id
				}).ToList();
			//_transactionRepo.Update(transaction.Id, itemToUpdate);
			await Task.Run(() => { _transactionRepo.Update(transaction.Id, itemToUpdate); });
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id) {
			_transactionRepo.Delete(id);
		}
	}
}
