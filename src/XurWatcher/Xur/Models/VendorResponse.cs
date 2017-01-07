using System.Collections.Generic;

namespace XurWatcher.Xur.Models
{
	public class VendorResponse
	{
		public VendorType Vendor { get; }
		public List<VendorItem> Items { get; }

		public VendorResponse(VendorType vendor, List<VendorItem> items)
		{
			Items = items;
			Vendor = vendor;
		}
	}

	public enum VendorType
	{
		Xur
	}

	public class VendorItem
	{
		public string ItemType { get; }
		public string Name { get; }

		public VendorItem(string type, string name)
		{
			ItemType = type;
			Name = name;
		}

		//public enum VendorItemType
		//{
		//	NotSet,
		//	LegendaryVehicleUpgrade,
		//	CommonConsumable,
		//	RareConsumable,
		//	RareMaterial,
		//	ExoticLegArmour,
		//	ExoticBodyArmour,
		//	ExoticHelmet,
		//	ExoticGauntlet,
		//	ExoticAutoRifle,
		//	ExoticShotgun,
		//	ExoticBodyArmourEngram
		//}
	}
}
