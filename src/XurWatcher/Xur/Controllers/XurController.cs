using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XurWatcher.Xur.Repositories;

namespace XurWatcher.Xur.Controllers
{
	[Route("[controller]")]
	public class XurController : Controller
	{
		private readonly IVendorRepository _repository;

		public XurController(IVendorRepository repository)
		{
			_repository = repository;
		}

		[HttpGet("inventory")]
		public async Task<IActionResult> Inventory()
		{
			var vendorData = await _repository.GetInventory();
			return Ok(vendorData);
		}
	}
}
