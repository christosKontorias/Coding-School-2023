using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Item;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForms {
	public partial class ItemsForm : Form {

		private readonly HttpClient _httpClient;

		public ItemsForm() {
			InitializeComponent();
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:7136/");
		}

		private void ItemsForm_Load(object sender, EventArgs e) {
			SetControlProperties();
		}
		
		private async void SetControlProperties() {
			var items = await GetItems();
			if (items != null) {
				bsItems.DataSource = items;
				grvItems.DataSource = bsItems;
			}
		}

		private async Task<List<ItemListDto>> GetItems() {
			var response = await _httpClient.GetAsync("item");
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
			}
			return null;
		}
	}
}
