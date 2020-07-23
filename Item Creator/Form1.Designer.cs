namespace Item_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxItemImg = new System.Windows.Forms.TextBox();
            this.textBoxItemType = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelDbg = new System.Windows.Forms.Label();
            this.textBoxItemDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxItemStack = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemsListGroups = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип предмета: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ссылка на изображение (client side): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Путь к файлу ItemData.json: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Группа предмета: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Название предмета: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Описание предмета: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить предмет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxItemImg
            // 
            this.textBoxItemImg.Enabled = false;
            this.textBoxItemImg.Location = new System.Drawing.Point(353, 12);
            this.textBoxItemImg.Name = "textBoxItemImg";
            this.textBoxItemImg.Size = new System.Drawing.Size(234, 20);
            this.textBoxItemImg.TabIndex = 8;
            this.textBoxItemImg.Text = "Должно остаться точное название";
            // 
            // textBoxItemType
            // 
            this.textBoxItemType.Location = new System.Drawing.Point(353, 46);
            this.textBoxItemType.Name = "textBoxItemType";
            this.textBoxItemType.Size = new System.Drawing.Size(264, 20);
            this.textBoxItemType.TabIndex = 9;
            this.textBoxItemType.Text = "Пр. ITEM_AID_KIT";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(353, 123);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(264, 20);
            this.textBoxItemName.TabIndex = 10;
            this.textBoxItemName.Text = "Пр. Аптечка";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(212, 363);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(16, 13);
            this.labelPath.TabIndex = 13;
            this.labelPath.Text = "...";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelDbg
            // 
            this.labelDbg.AutoSize = true;
            this.labelDbg.Location = new System.Drawing.Point(15, 334);
            this.labelDbg.Name = "labelDbg";
            this.labelDbg.Size = new System.Drawing.Size(115, 13);
            this.labelDbg.TabIndex = 14;
            this.labelDbg.Text = "Заполните все поля..";
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Location = new System.Drawing.Point(353, 228);
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(264, 93);
            this.textBoxItemDescription.TabIndex = 15;
            this.textBoxItemDescription.Text = "Пр. Обычная гражданская аптечка первой помощи. Восстанавливает 20-30% здоровья.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Кол-во предметов в стаке: ";
            // 
            // textBoxItemStack
            // 
            this.textBoxItemStack.Location = new System.Drawing.Point(353, 159);
            this.textBoxItemStack.Name = "textBoxItemStack";
            this.textBoxItemStack.Size = new System.Drawing.Size(264, 20);
            this.textBoxItemStack.TabIndex = 17;
            this.textBoxItemStack.Text = "Пр. 3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Пр. 300";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вес единицы предмета (в граммах): ";
            // 
            // itemsListGroups
            // 
            this.itemsListGroups.FormattingEnabled = true;
            this.itemsListGroups.Location = new System.Drawing.Point(353, 86);
            this.itemsListGroups.Name = "itemsListGroups";
            this.itemsListGroups.Size = new System.Drawing.Size(264, 21);
            this.itemsListGroups.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 20);
            this.button3.TabIndex = 21;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.itemsListGroups);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxItemStack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.labelDbg);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.textBoxItemType);
            this.Controls.Add(this.textBoxItemImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxItemImg;
        private System.Windows.Forms.TextBox textBoxItemType;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelDbg;
        private System.Windows.Forms.RichTextBox textBoxItemDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxItemStack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox itemsListGroups;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

