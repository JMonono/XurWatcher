using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XurWatcher.Xur.Models;

namespace XurWatcher.Xur.Repositories
{
	public class VendorRepository : IVendorRepository
	{
		private readonly HttpClient _client;

		public VendorRepository()
		{
			_client = new HttpClient();
		}

		// TODO: Tell don't ask
		public async Task<Models.VendorResponse> GetInventory()
		{
			Models.Bungie.VendorResponse vendorResponse = null;
			var vendorItems = new List<VendorItem>();

			try
			{
				var response = await _client.GetStringAsync("https://www.bungie.net/Platform/Destiny/Advisors/Xur/");
				vendorResponse = JsonConvert.DeserializeObject<Models.Bungie.VendorResponse>(response);


				foreach (var item in vendorResponse.Response?.Data?.SaleItemCategories)
				{
					foreach (var saleItem in item.SaleItems)
					{
						var itemResponse =
							await _client.GetStringAsync($"http://www.bungie.net/Platform/Destiny/Manifest/6/{saleItem.Item.ItemHash}/");
						var inventoryItem = JsonConvert.DeserializeObject<Models.Bungie.InventoryItemResponse>(itemResponse);
						vendorItems.Add(
							new VendorItem(inventoryItem.Response.Data.InventoryItem.ItemTypeName,
										   inventoryItem.Response.Data.InventoryItem.ItemName));
					}

				}
			}
			catch (Exception ex)
			{
				// TODO: Logging
			}

			return new Models.VendorResponse(VendorType.Xur, vendorItems);
		}
	}
}
