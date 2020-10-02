using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Item_Creator.Creator;

namespace Item_Creator
{
    public partial class Form1 : Form
    {
        public delegate void CleanInput(object o, System.EventArgs e);

        public Form1()
        {
            InitializeComponent();

            itemsListGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            itemsListGroups.Items.AddRange(new string[] { "None", "Food", "Cloth", "Weapon", "Access", "Medical", "Scrap", "Personal" });

            itemsListGroups.SelectedIndex = 0;


            button1.Click += CreateItemAction;

            CleanInput cinp = CleanInputs;

            textBoxItemImg.Click += CleanInputs;
            textBoxItemName.Click += CleanInputs;
            textBoxItemDescription.Click += CleanInputs;
            textBoxItemStack.Click += CleanInputs;
            textBoxItemType.Click += CleanInputs;
            textBox1.Click += CleanInputs;


            button2.Click += OpenJsonFileDialog;
            button3.Click += OpenImgFileDialog;


            openFileDialog1.Filter = openFileDialog1.Filter = "Text files(*.json)|*.*";
            openFileDialog2.Filter = openFileDialog2.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.svg) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.svg;";
        }

        private void CreateItemAction(object sender, EventArgs e)
        {
            if (PathData.fileName == null)
            {
                SendBugInDebugLine("Ошибка: Укажите файл itemData.json!");
                return;
            }

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBoxBase)
                {
                    if (ctrl.Text.Contains("Пр.") || ctrl.Text == string.Empty)
                    {
                        SendBugInDebugLine("Ошибка: Введенные данные неверны или отсутствуют!");
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
                SendBugInDebugLine("Ошибка: В поля для целых чисел нужно вводить целые числа!");
                return;
            }

            if (!labelPath.Text.Contains(".json"))
            {
                SendBugInDebugLine("Ошибка: Не указан файл itemData.json!");
            }
            else if (!textBoxItemImg.Text.Contains("."))
            {
                SendBugInDebugLine("Ошибка: Укажите изображение для предмета!");
            }
            else if (textBoxItemType.Text.Length < 5)
            {
                SendBugInDebugLine("Ошибка: Не верно указан тип предмета!");
            }
            else if (ItemData.ItemDataList.Where(x => x.ItemType == textBoxItemType.Text).FirstOrDefault() != null)
            {
                SendBugInDebugLine("Ошибка: Предмет с таким типом уже существует!");
            }
            else if (textBoxItemName.Text.Length <= 0)
            {
                SendBugInDebugLine("Ошибка: Слишком короткое название для предмета!");
            }
            else if (Convert.ToInt32(textBoxItemStack.Text) < 1)
            {
                SendBugInDebugLine("Ошибка: Максимальное кол-во предметов в стаке не может быть меньше 1!");
            }
            else if (Convert.ToInt32(textBox1.Text) < 1)
            {
                SendBugInDebugLine("Ошибка: Вес единицы предмета не может быть меньше 1 грамма!");
            }
            else if (textBoxItemDescription.Text.Length < 1)
            {
                SendBugInDebugLine("Ошибка: Описание не может быть пустым!");
            }
            else
            {
                new ItemController().CreateItem(
                    labelDbg, 
                    textBoxItemType.Text, 
                    textBoxItemImg.Text, 
                    Convert.ToInt32(textBoxItemStack.Text), 
                    itemsListGroups.SelectedItem.ToString(), 
                    textBoxItemName.Text, 
                    textBoxItemDescription.Text, 
                    Convert.ToInt32(textBox1.Text)
                );
            }
        }

        private void OpenJsonFileDialog(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            PathData.fileText = System.IO.File.ReadAllText(PathData.fileName = labelPath.Text = openFileDialog1.FileName);

            new ItemController().UnPackJson(PathData.fileText);
        }

        private void OpenImgFileDialog(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;

            textBoxItemImg.Text = openFileDialog2.SafeFileName;
        }

        private void CleanInputs(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBoxBase input = (System.Windows.Forms.TextBoxBase)sender;

            if (input.Text.Contains("Пр."))
                input.Text = string.Empty;
        }

        private void SendBugInDebugLine(string bug)
        {
            labelDbg.Text = bug;
        }
    }
}
