using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XurWatcher.Xur.Models.Bungie
{
	public class VendorResponse
	{

		[JsonProperty("Response")]
		public Response Response { get; set; }

		[JsonProperty("ErrorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("ThrottleSeconds")]
		public int ThrottleSeconds { get; set; }

		[JsonProperty("ErrorStatus")]
		public string ErrorStatus { get; set; }

		[JsonProperty("Message")]
		public string Message { get; set; }

		[JsonProperty("MessageData")]
		public VendorMessageData MessageData { get; set; }
	}

	public class Stat
	{

		[JsonProperty("statHash")]
		public object StatHash { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }

		[JsonProperty("maximumValue")]
		public int MaximumValue { get; set; }
	}

	public class Node
	{

		[JsonProperty("isActivated")]
		public bool IsActivated { get; set; }

		[JsonProperty("stepIndex")]
		public int StepIndex { get; set; }

		[JsonProperty("state")]
		public int State { get; set; }

		[JsonProperty("hidden")]
		public bool Hidden { get; set; }

		[JsonProperty("nodeHash")]
		public int NodeHash { get; set; }
	}

	public class ArtRegions
	{

		[JsonProperty("3")]
		public int? Three { get; set; }
	}

	public class Perk
	{

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("perkHash")]
		public object PerkHash { get; set; }

		[JsonProperty("isActive")]
		public bool IsActive { get; set; }
	}

	public class PrimaryStat
	{

		[JsonProperty("statHash")]
		public object StatHash { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }

		[JsonProperty("maximumValue")]
		public int MaximumValue { get; set; }
	}

	public class Progression
	{

		[JsonProperty("dailyProgress")]
		public int DailyProgress { get; set; }

		[JsonProperty("weeklyProgress")]
		public int WeeklyProgress { get; set; }

		[JsonProperty("currentProgress")]
		public int CurrentProgress { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("step")]
		public int Step { get; set; }

		[JsonProperty("progressToNextLevel")]
		public int ProgressToNextLevel { get; set; }

		[JsonProperty("nextLevelAt")]
		public int NextLevelAt { get; set; }

		[JsonProperty("progressionHash")]
		public long ProgressionHash { get; set; }
	}

	public class Item
	{

		[JsonProperty("itemHash")]
		public int ItemHash { get; set; }

		[JsonProperty("bindStatus")]
		public int BindStatus { get; set; }

		[JsonProperty("isEquipped")]
		public bool IsEquipped { get; set; }

		[JsonProperty("itemInstanceId")]
		public string ItemInstanceId { get; set; }

		[JsonProperty("itemLevel")]
		public int ItemLevel { get; set; }

		[JsonProperty("stackSize")]
		public int StackSize { get; set; }

		[JsonProperty("qualityLevel")]
		public int QualityLevel { get; set; }

		[JsonProperty("stats")]
		public IList<Stat> Stats { get; set; }

		[JsonProperty("canEquip")]
		public bool CanEquip { get; set; }

		[JsonProperty("equipRequiredLevel")]
		public int EquipRequiredLevel { get; set; }

		[JsonProperty("unlockFlagHashRequiredToEquip")]
		public object UnlockFlagHashRequiredToEquip { get; set; }

		[JsonProperty("cannotEquipReason")]
		public int CannotEquipReason { get; set; }

		[JsonProperty("damageType")]
		public int DamageType { get; set; }

		[JsonProperty("damageTypeHash")]
		public int DamageTypeHash { get; set; }

		[JsonProperty("damageTypeNodeIndex")]
		public int DamageTypeNodeIndex { get; set; }

		[JsonProperty("damageTypeStepIndex")]
		public int DamageTypeStepIndex { get; set; }

		[JsonProperty("talentGridHash")]
		public long TalentGridHash { get; set; }

		[JsonProperty("nodes")]
		public IList<Node> Nodes { get; set; }

		[JsonProperty("useCustomDyes")]
		public bool UseCustomDyes { get; set; }

		[JsonProperty("artRegions")]
		public ArtRegions ArtRegions { get; set; }

		[JsonProperty("isEquipment")]
		public bool IsEquipment { get; set; }

		[JsonProperty("isGridComplete")]
		public bool IsGridComplete { get; set; }

		[JsonProperty("perks")]
		public IList<Perk> Perks { get; set; }

		[JsonProperty("location")]
		public int Location { get; set; }

		[JsonProperty("transferStatus")]
		public int TransferStatus { get; set; }

		[JsonProperty("locked")]
		public bool Locked { get; set; }

		[JsonProperty("lockable")]
		public bool Lockable { get; set; }

		[JsonProperty("objectives")]
		public IList<object> Objectives { get; set; }

		[JsonProperty("state")]
		public int State { get; set; }

		[JsonProperty("primaryStat")]
		public PrimaryStat PrimaryStat { get; set; }

		[JsonProperty("progression")]
		public Progression Progression { get; set; }
	}

	public class Cost
	{

		[JsonProperty("itemHash")]
		public int ItemHash { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }
	}

	public class SaleItem
	{

		[JsonProperty("item")]
		public Item Item { get; set; }

		[JsonProperty("vendorItemIndex")]
		public int VendorItemIndex { get; set; }

		[JsonProperty("itemStatus")]
		public int ItemStatus { get; set; }

		[JsonProperty("costs")]
		public IList<Cost> Costs { get; set; }

		[JsonProperty("requiredUnlockFlags")]
		public IList<object> RequiredUnlockFlags { get; set; }

		[JsonProperty("failureIndexes")]
		public IList<object> FailureIndexes { get; set; }
	}

	public class SaleItemCategory
	{

		[JsonProperty("categoryIndex")]
		public int CategoryIndex { get; set; }

		[JsonProperty("categoryTitle")]
		public string CategoryTitle { get; set; }

		[JsonProperty("saleItems")]
		public IList<SaleItem> SaleItems { get; set; }
	}

	public class VendorData
	{

		[JsonProperty("vendorHash")]
		public long VendorHash { get; set; }

		[JsonProperty("nextRefreshDate")]
		public DateTime NextRefreshDate { get; set; }

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("saleItemCategories")]
		public IList<SaleItemCategory> SaleItemCategories { get; set; }

		[JsonProperty("inventoryBuckets")]
		public IList<object> InventoryBuckets { get; set; }

		[JsonProperty("canPurchase")]
		public bool CanPurchase { get; set; }
	}

	public class Response
	{

		[JsonProperty("data")]
		public VendorData Data { get; set; }
	}

	public class VendorMessageData
	{
	}
}
