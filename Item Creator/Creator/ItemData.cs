using System.Collections.Generic;
using Newtonsoft.Json;

namespace Item_Creator.Creator
{
    public class ItemData
    {
        public static List<ItemData> ItemDataList = new List<ItemData>();

        [JsonIgnore]
        public string ItemType { get; private set; }
        [JsonProperty("ItemImg")]
        public string ItemImg { get; private set; }
        [JsonProperty("ItemStack")]
        public int ItemStack { get; private set; }
        [JsonProperty("ItemGroup")]
        public string ItemGroup { get; private set; }
        [JsonProperty("ItemName")]
        public string ItemName { get; private set; }
        [JsonProperty("ItemDescription")]
        public string ItemDescription { get; private set; }
        [JsonProperty("ItemWeight")]
        public int ItemWeight { get; private set; }

        private ItemData() { }
        public ItemData(string type, string img, int stack, string group, string name, string desc, int weight)
        {
            this.ItemType = type;
            this.ItemImg = img;
            this.ItemStack = stack;
            this.ItemGroup = group;
            this.ItemName = name;
            this.ItemDescription = desc;
            this.ItemWeight = weight;
        }

        public override string ToString()
        {
            return "ItemType: " + ItemType + " | ItemImg: " + ItemImg + " | ItemStack: " + ItemStack + " | ItemGroup: " + ItemGroup + " | ItemName: " + ItemName + " | ItemDesc: " + ItemDescription + " | ItemWeight: " + ItemWeight;
        }
    }
}
