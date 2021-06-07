using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Components;
using System;
using System.Collections.Generic;

namespace NiobeLab.Core.Objects.Destiny.Responses
{
    public class DestinyProfileResponse
    {
        [JsonProperty("vendorReceipts")]
        public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; } //good 
        [JsonProperty("profileInventory")]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; } //good 
        [JsonProperty("profileCurrencies")]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; } //good
        [JsonProperty("profile")]
        public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; } //good
        [JsonProperty("platformSilver")]
        public SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver { get; set; } //good 
        [JsonProperty("profileKiosks")]
        public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; } //good
        [JsonProperty("profilePlugSets")]
        public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; set; } //good 
        [JsonProperty("profileProgression")]
        public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; set; } //good
        [JsonProperty("profilePresentationNodes")]
        public SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes { get; set; } //good
        [JsonProperty("profileRecords")]
        public SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords { get; set; } //good
        [JsonProperty("profileCollectibles")]
        public SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles { get; set; } //good 
        [JsonProperty("profileTransitoryData")]
        public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; set; } //good 
        [JsonProperty("characters")]
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; } //good
        [JsonProperty("characterInventories")]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; set; } //good
        [JsonProperty("characterProgressions")]
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; set; } //good 
        [JsonProperty("characterRenderData")]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; set; } //good
        [JsonProperty("characterActivities")]
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; set; } //good
        [JsonProperty("characterEquipment")]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; } //good
        [JsonProperty("characterKiosks")]
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; set; } //good
        [JsonProperty("characterPlugSets")]
        public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets { get; set; } //good
        [JsonProperty("characterUninstancedItemComponents")]
        public Dictionary<Int64, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents { get; set; } //good
        [JsonProperty("characterPresentationNodes")]
        public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent CharacterPresentationNodes { get; set; } //good
        [JsonProperty("characterRecords")]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent CharacterRecords { get; set; } //good 
        [JsonProperty("characterCollectibles")]
        public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent CharacterCollectibles { get; set; } //good
        [JsonProperty("itemComponents")]
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; } //eh
        [JsonProperty("characterCurrencyLookups")]
        public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups { get; set; } //good 
    }
}
