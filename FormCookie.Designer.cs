
namespace FlowerShop
{
    partial class FormCookie
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listCookie = new System.Windows.Forms.ComboBox();
            this.weight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(618, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listCookie
            // 
            this.listCookie.FormattingEnabled = true;
            this.listCookie.Items.AddRange(new object[] {
            "Chocolate Chip Cookies",
            "Shortbread Cookies",
            "Macaron Cookies",
            "Biscotti Cookies",
            "Sugar Cookies",
            "Gingerbread Cookies"});
            this.listCookie.Location = new System.Drawing.Point(40, 52);
            this.listCookie.Name = "listCookie";
            this.listCookie.Size = new System.Drawing.Size(121, 24);
            this.listCookie.TabIndex = 2;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(369, 58);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(120, 22);
            this.weight.TabIndex = 3;
            // 
            // FormCookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.listCookie);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormCookie";
            this.Text = "FormCookie";
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox listCookie;
        private System.Windows.Forms.NumericUpDown weight;
    }
}