using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Item_Creator.Creator
{
    public class ItemController
    {
        public void UnPackJson(string json)
        {
            if (json == string.Empty) return;

            var j = JsonConvert.DeserializeObject<Dictionary<string, ItemData>>(json);

            foreach (var r in j)
            {
                ItemData t = r.Value;
                ItemData.ItemDataList.Add(new ItemData(r.Key, t.ItemImg, t.ItemStack, t.ItemGroup, t.ItemName, t.ItemDescription, t.ItemWeight));
            }
        }

        public void PackJson()
        {
            Dictionary<string, ItemData> kp = new Dictionary<string, ItemData>();

            foreach (var i in ItemData.ItemDataList)
            {
                kp.Add(i.ItemType, i);
            }

            var ser = JsonConvert.SerializeObject(kp);

            System.IO.File.WriteAllText(PathData.fileName, ser);
        }

        public void CreateItem(Label label, string type, string img, int stack, string group, string name, string desc, int weight)
        {
            ItemData item = new ItemData(type, img, stack, group, name, desc, weight);
            ItemData.ItemDataList.Add(item);

            label.Text = "Объект успешно добавлен!";

            PackJson();
        }
    }
}
