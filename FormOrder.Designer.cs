
namespace FlowerShop
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBucket = new System.Windows.Forms.Button();
            this.buttonSweet = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBucket
            // 
            this.buttonBucket.Location = new System.Drawing.Point(145, 76);
            this.buttonBucket.Name = "buttonBucket";
            this.buttonBucket.Size = new System.Drawing.Size(144, 40);
            this.buttonBucket.TabIndex = 0;
            this.buttonBucket.Text = "Bucket";
            this.buttonBucket.UseVisualStyleBackColor = true;
            this.buttonBucket.Click += new System.EventHandler(this.buttonBucket_Click);
            // 
            // buttonSweet
            // 
            this.buttonSweet.Location = new System.Drawing.Point(504, 76);
            this.buttonSweet.Name = "buttonSweet";
            this.buttonSweet.Size = new System.Drawing.Size(144, 40);
            this.buttonSweet.TabIndex = 1;
            this.buttonSweet.Text = "Sweet";
            this.buttonSweet.UseVisualStyleBackColor = true;
            this.buttonSweet.Click += new System.EventHandler(this.buttonSweet_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.Location = new System.Drawing.Point(108, 201);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(568, 207);
            this.labelOrder.TabIndex = 3;
            this.labelOrder.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(322, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your order:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total price:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.Location = new System.Drawing.Point(294, 457);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(27, 39);
            this.labelTotalPrice.TabIndex = 6;
            this.labelTotalPrice.Text = " ";
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeOrder.Location = new System.Drawing.Point(504, 447);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(261, 49);
            this.buttonMakeOrder.TabIndex = 7;
            this.buttonMakeOrder.Text = "Make an order";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(743, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMakeOrder);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonSweet);
            this.Controls.Add(this.buttonBucket);
            this.Name = "FormOrder";
            this.Text = "DefaultUser";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBucket;
        private System.Windows.Forms.Button buttonSweet;
        public System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button buttonExit;
    }
}