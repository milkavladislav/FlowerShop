
namespace FlowerShop
{
    partial class FormSweet
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
            this.buttonCookie = new System.Windows.Forms.Button();
            this.buttonCandy = new System.Windows.Forms.Button();
            this.buttonEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCookie
            // 
            this.buttonCookie.Location = new System.Drawing.Point(73, 12);
            this.buttonCookie.Name = "buttonCookie";
            this.buttonCookie.Size = new System.Drawing.Size(122, 61);
            this.buttonCookie.TabIndex = 0;
            this.buttonCookie.Text = "Cookie";
            this.buttonCookie.UseVisualStyleBackColor = true;
            this.buttonCookie.Click += new System.EventHandler(this.buttonCookie_Click);
            // 
            // buttonCandy
            // 
            this.buttonCandy.Location = new System.Drawing.Point(73, 99);
            this.buttonCandy.Name = "buttonCandy";
            this.buttonCandy.Size = new System.Drawing.Size(122, 61);
            this.buttonCandy.TabIndex = 1;
            this.buttonCandy.Text = "Candy";
            this.buttonCandy.UseVisualStyleBackColor = true;
            this.buttonCandy.Click += new System.EventHandler(this.buttonCandy_Click);
            // 
            // buttonEsc
            // 
            this.buttonEsc.Location = new System.Drawing.Point(265, 12);
            this.buttonEsc.Name = "buttonEsc";
            this.buttonEsc.Size = new System.Drawing.Size(47, 23);
            this.buttonEsc.TabIndex = 2;
            this.buttonEsc.Text = "Esc";
            this.buttonEsc.UseVisualStyleBackColor = true;
            this.buttonEsc.Click += new System.EventHandler(this.buttonEsc_Click);
            // 
            // FormSweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 182);
            this.Controls.Add(this.buttonEsc);
            this.Controls.Add(this.buttonCandy);
            this.Controls.Add(this.buttonCookie);
            this.Name = "FormSweet";
            this.Text = "FormSweet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCookie;
        private System.Windows.Forms.Button buttonCandy;
        private System.Windows.Forms.Button buttonEsc;
    }
}