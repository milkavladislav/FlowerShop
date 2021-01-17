
namespace FlowerShop
{
    partial class FormBucket
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
            this.buttonAddFlower = new System.Windows.Forms.Button();
            this.listFlowerColor = new System.Windows.Forms.ComboBox();
            this.listFlowerHeight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listFlowerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowerCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddWrapper = new System.Windows.Forms.Button();
            this.listWrapperColor = new System.Windows.Forms.ComboBox();
            this.listWrapperType = new System.Windows.Forms.ComboBox();
            this.formFlower = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFlowerCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bucketName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddFlower
            // 
            this.buttonAddFlower.Location = new System.Drawing.Point(665, 39);
            this.buttonAddFlower.Name = "buttonAddFlower";
            this.buttonAddFlower.Size = new System.Drawing.Size(150, 30);
            this.buttonAddFlower.TabIndex = 0;
            this.buttonAddFlower.Text = "Add flower";
            this.buttonAddFlower.UseVisualStyleBackColor = true;
            this.buttonAddFlower.Click += new System.EventHandler(this.buttonAddFlower_Click);
            // 
            // listFlowerColor
            // 
            this.listFlowerColor.FormattingEnabled = true;
            this.listFlowerColor.Items.AddRange(new object[] {
            "black",
            "white",
            "red",
            "yellow",
            "blue",
            "green"});
            this.listFlowerColor.Location = new System.Drawing.Point(36, 39);
            this.listFlowerColor.Name = "listFlowerColor";
            this.listFlowerColor.Size = new System.Drawing.Size(121, 24);
            this.listFlowerColor.TabIndex = 2;
            // 
            // listFlowerHeight
            // 
            this.listFlowerHeight.FormattingEnabled = true;
            this.listFlowerHeight.Items.AddRange(new object[] {
            "50",
            "60",
            "70"});
            this.listFlowerHeight.Location = new System.Drawing.Point(207, 40);
            this.listFlowerHeight.Name = "listFlowerHeight";
            this.listFlowerHeight.Size = new System.Drawing.Size(121, 24);
            this.listFlowerHeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color\r\n";
            // 
            // listFlowerType
            // 
            this.listFlowerType.FormattingEnabled = true;
            this.listFlowerType.Items.AddRange(new object[] {
            "chamomile",
            "rose",
            "orchid",
            "tulip"});
            this.listFlowerType.Location = new System.Drawing.Point(369, 39);
            this.listFlowerType.Name = "listFlowerType";
            this.listFlowerType.Size = new System.Drawing.Size(121, 24);
            this.listFlowerType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // flowerCount
            // 
            this.flowerCount.Location = new System.Drawing.Point(567, 41);
            this.flowerCount.Name = "flowerCount";
            this.flowerCount.Size = new System.Drawing.Size(63, 22);
            this.flowerCount.TabIndex = 8;
            this.flowerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count";
            // 
            // buttonAddWrapper
            // 
            this.buttonAddWrapper.Location = new System.Drawing.Point(665, 128);
            this.buttonAddWrapper.Name = "buttonAddWrapper";
            this.buttonAddWrapper.Size = new System.Drawing.Size(150, 30);
            this.buttonAddWrapper.TabIndex = 10;
            this.buttonAddWrapper.Text = "Add wrapper";
            this.buttonAddWrapper.UseVisualStyleBackColor = true;
            this.buttonAddWrapper.Click += new System.EventHandler(this.buttonAddWrapper_Click);
            // 
            // listWrapperColor
            // 
            this.listWrapperColor.FormattingEnabled = true;
            this.listWrapperColor.Items.AddRange(new object[] {
            "black",
            "white",
            "red",
            "yellow",
            "blue",
            "green"});
            this.listWrapperColor.Location = new System.Drawing.Point(129, 128);
            this.listWrapperColor.Name = "listWrapperColor";
            this.listWrapperColor.Size = new System.Drawing.Size(121, 24);
            this.listWrapperColor.TabIndex = 11;
            // 
            // listWrapperType
            // 
            this.listWrapperType.FormattingEnabled = true;
            this.listWrapperType.Items.AddRange(new object[] {
            "shirring",
            "ordinary",
            "foil"});
            this.listWrapperType.Location = new System.Drawing.Point(402, 128);
            this.listWrapperType.Name = "listWrapperType";
            this.listWrapperType.Size = new System.Drawing.Size(121, 24);
            this.listWrapperType.TabIndex = 12;
            // 
            // formFlower
            // 
            this.formFlower.Location = new System.Drawing.Point(33, 232);
            this.formFlower.Name = "formFlower";
            this.formFlower.Size = new System.Drawing.Size(820, 474);
            this.formFlower.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(363, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Your bucket:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(620, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Flower in bucket: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 16;
            // 
            // labelFlowerCount
            // 
            this.labelFlowerCount.AutoSize = true;
            this.labelFlowerCount.Location = new System.Drawing.Point(739, 261);
            this.labelFlowerCount.Name = "labelFlowerCount";
            this.labelFlowerCount.Size = new System.Drawing.Size(12, 17);
            this.labelFlowerCount.TabIndex = 17;
            this.labelFlowerCount.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 714);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add bucket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bucketName
            // 
            this.bucketName.Location = new System.Drawing.Point(284, 719);
            this.bucketName.Name = "bucketName";
            this.bucketName.Size = new System.Drawing.Size(206, 22);
            this.bucketName.TabIndex = 19;
            this.bucketName.Text = "bucket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(63, 721);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(122, 717);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(26, 39);
            this.labelPrice.TabIndex = 21;
            this.labelPrice.Text = " ";
            // 
            // Buckets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 781);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bucketName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFlowerCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.formFlower);
            this.Controls.Add(this.listWrapperType);
            this.Controls.Add(this.listWrapperColor);
            this.Controls.Add(this.buttonAddWrapper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowerCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listFlowerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFlowerHeight);
            this.Controls.Add(this.listFlowerColor);
            this.Controls.Add(this.buttonAddFlower);
            this.Name = "Buckets";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flowerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFlower;
        private System.Windows.Forms.ComboBox listFlowerColor;
        private System.Windows.Forms.ComboBox listFlowerHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listFlowerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown flowerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddWrapper;
        private System.Windows.Forms.ComboBox listWrapperColor;
        private System.Windows.Forms.ComboBox listWrapperType;
        private System.Windows.Forms.Label formFlower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFlowerCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bucketName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPrice;
    }
}

