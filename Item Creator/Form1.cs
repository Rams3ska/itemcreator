using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            itemsListGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            itemsListGroups.Items.AddRange(new string[] { "None", "Food", "Cloth", "Weapon", "Access", "Medical", "Scrap", "Personal" });

            itemsListGroups.SelectedIndex = 0;
            

            button1.Click += (s, e) =>
            {
                if(PathData.fileName == null)
                {
                    labelDbg.Text = "Ошибка: Укажите файл itemData.json!";
                    return;
                }

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(RichTextBox))
                    {
                        if (ctrl.Text.Contains("Пр.") || ctrl.Text == string.Empty)
                        {
                            labelDbg.Text = "Ошибка: Введенные данные неверны или отсутствуют!";
                            return;
                        }
                    }
                }

                try
                {
                    Convert.ToInt32(textBoxItemStack.Text);
                    Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    labelDbg.Text = "Ошибка: В поля для целых чисел нужно вводить целые числа!";
                    return;
                }

                if (!labelPath.Text.Contains(".json"))
                {
                    labelDbg.Text = "Ошибка: Не указан файл itemData.json!";
                    return;
                }
                else if(!textBoxItemImg.Text.Contains("."))
                {
                    labelDbg.Text = "Ошибка: Укажите изображение для предмета!";
                    return;
                }
                else if(textBoxItemType.Text.Length < 5)
                {
                    labelDbg.Text = "Ошибка: Не верно указан тип предмета!";
                    return;
                }
                else if (ItemData.ItemDataList.Where(x => x.ItemType == textBoxItemType.Text).FirstOrDefault() != null)
                {
                    labelDbg.Text = "Ошибка: Предмет с таким типом уже существует!";
                    return;
                }
                else if(textBoxItemName.Text.Length <= 0)
                {
                    labelDbg.Text = "Ошибка: Слишком короткое название для предмета!";
                }
                else if(Convert.ToInt32(textBoxItemStack.Text) < 1)
                {
                    labelDbg.Text = "Ошибка: Максимальное кол-во предметов в стаке не может быть меньше 1!";
                }
                else if(Convert.ToInt32(textBox1.Text) < 1)
                {
                    labelDbg.Text = "Ошибка: Вес единицы предмета не может быть меньше 1 грамма!";
                }
                else if(textBoxItemDescription.Text.Length < 1)
                {
                    labelDbg.Text = "Ошибка: Описание не может быть пустым!";
                }

                ItemZalupa.CreateItem(textBoxItemType.Text, textBoxItemImg.Text, Convert.ToInt32(textBoxItemStack.Text), itemsListGroups.SelectedItem.ToString(), textBoxItemName.Text, textBoxItemDescription.Text, Convert.ToInt32(textBox1.Text));
                labelDbg.Text = string.Empty;
            };

            textBoxItemImg.Click += (s, e) => 
            {
                if (textBoxItemImg.Text.Contains("Пр."))
                    textBoxItemImg.Text = string.Empty;
            };

            textBoxItemName.Click += (s, e) =>
            {
                if (textBoxItemName.Text.Contains("Пр."))
                    textBoxItemName.Text = string.Empty;
            };

            textBoxItemDescription.Click += (s, e) =>
            {
                if (textBoxItemDescription.Text.Contains("Пр."))
                    textBoxItemDescription.Text = string.Empty;
            };

            textBoxItemStack.Click += (s, e) =>
            {
                if (textBoxItemStack.Text.Contains("Пр."))
                    textBoxItemStack.Text = string.Empty;
            };
            
            textBoxItemType.Click += (s, e) =>
            {
                if (textBoxItemType.Text.Contains("Пр."))
                    textBoxItemType.Text = string.Empty;
            };

            textBox1.Click += (s, e) => 
            {
                if (textBox1.Text.Contains("Пр."))
                    textBox1.Text = string.Empty;
            };


            button2.Click += (s, e) =>
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

                PathData.fileText = System.IO.File.ReadAllText(PathData.fileName = labelPath.Text = openFileDialog1.FileName);

                ItemZalupa.UnPackJson(PathData.fileText);
            };

            button3.Click += (s, e) =>
            {
                if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;

                textBoxItemImg.Text = openFileDialog2.SafeFileName;
            };

            openFileDialog1.Filter = openFileDialog1.Filter = "Text files(*.json)|*.*";
            openFileDialog2.Filter = openFileDialog2.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }
    }

    public static class PathData
    {
        public static string fileText { get; set; }
        public static string fileName { get; set; }
    }

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
        [JsonProperty("ItemWeigth")]
        public int ItemWeigth { get; private set; }

        private ItemData() { }
        public ItemData(string type, string img, int stack, string group, string name, string desc, int weight)
        {
            this.ItemType = type;
            this.ItemImg = img;
            this.ItemStack = stack;
            this.ItemGroup = group;
            this.ItemName = name;
            this.ItemDescription = desc;
            this.ItemWeigth = weight;
        }

        public override string ToString()
        {
            return "ItemType: " + ItemType + " | ItemImg: " + ItemImg + " | ItemStack: " + ItemStack + " | ItemGroup: " + ItemGroup + " | ItemName: " + ItemName + " | ItemDesc: " + ItemDescription + " | ItemWeight: " + ItemWeigth;
        }
    }

    public class ItemZalupa
    {
        public static void UnPackJson(string json)
        {
            var j = JsonConvert.DeserializeObject<Dictionary<string, ItemData>>(json);

            foreach (var r in j)
            {
                ItemData t = r.Value;
                ItemData.ItemDataList.Add(new ItemData(r.Key, t.ItemImg, t.ItemStack, t.ItemGroup, t.ItemName, t.ItemDescription, t.ItemWeigth));
            }
        }

        public static void PackJson()
        {
            Dictionary<string, ItemData> kp = new Dictionary<string, ItemData>();

            foreach(var i in ItemData.ItemDataList)
            {
                kp.Add(i.ItemType, i);
            }

            var ser = JsonConvert.SerializeObject(kp);

            System.IO.File.WriteAllText(PathData.fileName, ser);
        }

        public static void CreateItem(string type, string img, int stack, string group, string name, string desc, int weigth)
        {
            ItemData item = new ItemData(type, img, stack, group, name, desc, weigth);
            ItemData.ItemDataList.Add(item);

            PackJson();
        }
    }
}
