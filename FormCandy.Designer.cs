
namespace FlowerShop
{
    partial class FormCandy
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
            this.listCandy = new System.Windows.Forms.ComboBox();
            this.weight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(596, 75);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listCandy
            // 
            this.listCandy.FormattingEnabled = true;
            this.listCandy.Items.AddRange(new object[] {
            "Bite Size",
            "Bon Bons",
            "Brittle Candy",
            "Bubble Gum",
            "Candy Bars",
            "Candy Buttons",
            "Candy Canes",
            "Candy Coated Popcorn"});
            this.listCandy.Location = new System.Drawing.Point(36, 86);
            this.listCandy.Name = "listCandy";
            this.listCandy.Size = new System.Drawing.Size(121, 24);
            this.listCandy.TabIndex = 3;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(349, 88);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(120, 22);
            this.weight.TabIndex = 4;
            // 
            // FormCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 192);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.listCandy);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormCandy";
            this.Text = "FormCandy";
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox listCandy;
        private System.Windows.Forms.NumericUpDown weight;
    }
}