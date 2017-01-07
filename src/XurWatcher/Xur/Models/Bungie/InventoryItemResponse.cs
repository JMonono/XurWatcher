using System.Collections.Generic;
using Newtonsoft.Json;

namespace XurWatcher.Xur.Models.Bungie
{
	public class InventoryItemResponse
	{

		[JsonProperty("Response")]
		public InventoryResponse Response { get; set; }

		[JsonProperty("ErrorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("ThrottleSeconds")]
		public int ThrottleSeconds { get; set; }

		[JsonProperty("ErrorStatus")]
		public string ErrorStatus { get; set; }

		[JsonProperty("Message")]
		public string Message { get; set; }

		[JsonProperty("MessageData")]
		public InventoryItemMessageData MessageData { get; set; }
	}

	public class Stats
	{
	}

	public class Values
	{
	}

	public class ComputedStats
	{
	}

	public class Source
	{

		[JsonProperty("expansionIndex")]
		public int ExpansionIndex { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("minQuality")]
		public int MinQuality { get; set; }

		[JsonProperty("maxQuality")]
		public int MaxQuality { get; set; }

		[JsonProperty("minLevelRequired")]
		public int MinLevelRequired { get; set; }

		[JsonProperty("maxLevelRequired")]
		public int MaxLevelRequired { get; set; }

		[JsonProperty("exclusivity")]
		public int Exclusivity { get; set; }

		[JsonProperty("computedStats")]
		public ComputedStats ComputedStats { get; set; }

		[JsonProperty("sourceHashes")]
		public IList<object> SourceHashes { get; set; }
	}

	public class InventoryItem
	{

		[JsonProperty("itemHash")]
		public int ItemHash { get; set; }

		[JsonProperty("itemName")]
		public string ItemName { get; set; }

		[JsonProperty("itemDescription")]
		public string ItemDescription { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("hasIcon")]
		public bool HasIcon { get; set; }

		[JsonProperty("secondaryIcon")]
		public string SecondaryIcon { get; set; }

		[JsonProperty("actionName")]
		public string ActionName { get; set; }

		[JsonProperty("hasAction")]
		public bool HasAction { get; set; }

		[JsonProperty("deleteOnAction")]
		public bool DeleteOnAction { get; set; }

		[JsonProperty("tierTypeName")]
		public string TierTypeName { get; set; }

		[JsonProperty("tierType")]
		public int TierType { get; set; }

		[JsonProperty("itemTypeName")]
		public string ItemTypeName { get; set; }

		[JsonProperty("bucketTypeHash")]
		public int BucketTypeHash { get; set; }

		[JsonProperty("primaryBaseStatHash")]
		public int PrimaryBaseStatHash { get; set; }

		[JsonProperty("stats")]
		public Stats Stats { get; set; }

		[JsonProperty("perkHashes")]
		public IList<object> PerkHashes { get; set; }

		[JsonProperty("specialItemType")]
		public int SpecialItemType { get; set; }

		[JsonProperty("talentGridHash")]
		public int TalentGridHash { get; set; }

		[JsonProperty("hasGeometry")]
		public bool HasGeometry { get; set; }

		[JsonProperty("statGroupHash")]
		public int StatGroupHash { get; set; }

		[JsonProperty("itemLevels")]
		public IList<object> ItemLevels { get; set; }

		[JsonProperty("qualityLevel")]
		public int QualityLevel { get; set; }

		[JsonProperty("equippable")]
		public bool Equippable { get; set; }

		[JsonProperty("instanced")]
		public bool Instanced { get; set; }

		[JsonProperty("rewardItemHash")]
		public int RewardItemHash { get; set; }

		[JsonProperty("values")]
		public Values Values { get; set; }

		[JsonProperty("itemType")]
		public int ItemType { get; set; }

		[JsonProperty("itemSubType")]
		public int ItemSubType { get; set; }

		[JsonProperty("classType")]
		public int ClassType { get; set; }

		[JsonProperty("sources")]
		public IList<Source> Sources { get; set; }

		[JsonProperty("itemCategoryHashes")]
		public IList<int> ItemCategoryHashes { get; set; }

		[JsonProperty("sourceHashes")]
		public IList<object> SourceHashes { get; set; }

		[JsonProperty("nonTransferrable")]
		public bool NonTransferrable { get; set; }

		[JsonProperty("exclusive")]
		public int Exclusive { get; set; }

		[JsonProperty("maxStackSize")]
		public int MaxStackSize { get; set; }

		[JsonProperty("itemIndex")]
		public int ItemIndex { get; set; }

		[JsonProperty("setItemHashes")]
		public IList<object> SetItemHashes { get; set; }

		[JsonProperty("tooltipStyle")]
		public string TooltipStyle { get; set; }

		[JsonProperty("questlineItemHash")]
		public int QuestlineItemHash { get; set; }

		[JsonProperty("needsFullCompletion")]
		public bool NeedsFullCompletion { get; set; }

		[JsonProperty("objectiveHashes")]
		public IList<object> ObjectiveHashes { get; set; }

		[JsonProperty("allowActions")]
		public bool AllowActions { get; set; }

		[JsonProperty("questTrackingUnlockValueHash")]
		public int QuestTrackingUnlockValueHash { get; set; }

		[JsonProperty("bountyResetUnlockHash")]
		public int BountyResetUnlockHash { get; set; }

		[JsonProperty("uniquenessHash")]
		public int UniquenessHash { get; set; }

		[JsonProperty("showActiveNodesInTooltip")]
		public bool ShowActiveNodesInTooltip { get; set; }

		[JsonProperty("hash")]
		public int Hash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("redacted")]
		public bool Redacted { get; set; }
	}

	public class InventoryItemData
	{

		[JsonProperty("requestedId")]
		public int RequestedId { get; set; }

		[JsonProperty("inventoryItem")]
		public InventoryItem InventoryItem { get; set; }
	}

	public class InventoryResponse
	{

		[JsonProperty("data")]
		public InventoryItemData Data { get; set; }
	}

	public class InventoryItemMessageData
	{
	}
}
