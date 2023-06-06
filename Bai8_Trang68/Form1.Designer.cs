namespace Bai8_Trang68
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.clbMenu = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.Turquoise;
            this.btnHoanThanh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHoanThanh.Location = new System.Drawing.Point(0, 392);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(800, 58);
            this.btnHoanThanh.TabIndex = 0;
            this.btnHoanThanh.Text = "&Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // clbMenu
            // 
            this.clbMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.clbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbMenu.FormattingEnabled = true;
            this.clbMenu.Location = new System.Drawing.Point(0, 0);
            this.clbMenu.Name = "clbMenu";
            this.clbMenu.Size = new System.Drawing.Size(800, 392);
            this.clbMenu.TabIndex = 1;
            this.clbMenu.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMenu_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbMenu);
            this.Controls.Add(this.btnHoanThanh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.CheckedListBox clbMenu;
    }
}

