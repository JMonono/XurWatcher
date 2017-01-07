using System.Threading.Tasks;
using XurWatcher.Xur.Models;

namespace XurWatcher.Xur.Repositories
{
	public interface IVendorRepository
	{
		Task<VendorResponse> GetInventory();
	}
}
