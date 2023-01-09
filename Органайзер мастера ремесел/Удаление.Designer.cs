namespace Органайзер_мастера_ремесел
{
    partial class Удаление
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
            this.ОтменаButton = new Guna.UI2.WinForms.Guna2Button();
            this.УдалитьButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ОтменаButton
            // 
            this.ОтменаButton.BorderRadius = 10;
            this.ОтменаButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ОтменаButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ОтменаButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ОтменаButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ОтменаButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.ОтменаButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ОтменаButton.ForeColor = System.Drawing.Color.White;
            this.ОтменаButton.Location = new System.Drawing.Point(315, 159);
            this.ОтменаButton.Name = "ОтменаButton";
            this.ОтменаButton.Size = new System.Drawing.Size(96, 29);
            this.ОтменаButton.TabIndex = 14;
            this.ОтменаButton.Text = "Отмена";
            this.ОтменаButton.Click += new System.EventHandler(this.ОтменаButton_Click);
            // 
            // УдалитьButton
            // 
            this.УдалитьButton.BorderRadius = 10;
            this.УдалитьButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.УдалитьButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.УдалитьButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.УдалитьButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.УдалитьButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.УдалитьButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.УдалитьButton.ForeColor = System.Drawing.Color.White;
            this.УдалитьButton.Location = new System.Drawing.Point(23, 159);
            this.УдалитьButton.Name = "УдалитьButton";
            this.УдалитьButton.Size = new System.Drawing.Size(96, 29);
            this.УдалитьButton.TabIndex = 13;
            this.УдалитьButton.Text = "Удалить";
            this.УдалитьButton.Click += new System.EventHandler(this.УдалитьButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 58);
            this.label2.TabIndex = 26;
            this.label2.Text = "Вы действительно хотите \r\nудалить этот элемент?";
            // 
            // Удаление
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ОтменаButton);
            this.Controls.Add(this.УдалитьButton);
            this.DisplayHeader = false;
            this.Name = "Удаление";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Удаление_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ОтменаButton;
        private Guna.UI2.WinForms.Guna2Button УдалитьButton;
        private System.Windows.Forms.Label label2;
    }
}