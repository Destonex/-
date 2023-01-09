namespace Органайзер_мастера_ремесел
{
    partial class Добавление_заказа
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label дата_изготовленияLabel;
            System.Windows.Forms.Label иД_ИзделияLabel;
            System.Windows.Forms.Label стоимостьLabel;
            this.ДобавитьButton = new Guna.UI2.WinForms.Guna2Button();
            this.ОтменаButton = new Guna.UI2.WinForms.Guna2Button();
            this.cursachDataSet = new Органайзер_мастера_ремесел.CursachDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.TableAdapterManager();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделиеTableAdapter = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.ИзделиеTableAdapter();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_изготовленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            фИОLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            дата_изготовленияLabel = new System.Windows.Forms.Label();
            иД_ИзделияLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(45, 30);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 12;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(45, 65);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 13;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // дата_изготовленияLabel
            // 
            дата_изготовленияLabel.AutoSize = true;
            дата_изготовленияLabel.Location = new System.Drawing.Point(45, 100);
            дата_изготовленияLabel.Name = "дата_изготовленияLabel";
            дата_изготовленияLabel.Size = new System.Drawing.Size(109, 13);
            дата_изготовленияLabel.TabIndex = 14;
            дата_изготовленияLabel.Text = "Дата изготовления:";
            // 
            // иД_ИзделияLabel
            // 
            иД_ИзделияLabel.AutoSize = true;
            иД_ИзделияLabel.Location = new System.Drawing.Point(45, 135);
            иД_ИзделияLabel.Name = "иД_ИзделияLabel";
            иД_ИзделияLabel.Size = new System.Drawing.Size(54, 13);
            иД_ИзделияLabel.TabIndex = 15;
            иД_ИзделияLabel.Text = "Изделие:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(45, 170);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 19;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // ДобавитьButton
            // 
            this.ДобавитьButton.BorderRadius = 10;
            this.ДобавитьButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ДобавитьButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ДобавитьButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ДобавитьButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ДобавитьButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.ДобавитьButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ДобавитьButton.ForeColor = System.Drawing.Color.White;
            this.ДобавитьButton.Location = new System.Drawing.Point(23, 209);
            this.ДобавитьButton.Name = "ДобавитьButton";
            this.ДобавитьButton.Size = new System.Drawing.Size(96, 29);
            this.ДобавитьButton.TabIndex = 10;
            this.ДобавитьButton.Text = "Добавить";
            this.ДобавитьButton.Click += new System.EventHandler(this.ДобавитьButton_Click);
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
            this.ОтменаButton.Location = new System.Drawing.Point(291, 209);
            this.ОтменаButton.Name = "ОтменаButton";
            this.ОтменаButton.Size = new System.Drawing.Size(96, 29);
            this.ОтменаButton.TabIndex = 11;
            this.ОтменаButton.Text = "Отмена";
            this.ОтменаButton.Click += new System.EventHandler(this.ОтменаButton_Click);
            // 
            // cursachDataSet
            // 
            this.cursachDataSet.DataSetName = "CursachDataSet";
            this.cursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.cursachDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Органайзер_мастера_ремесел.CursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_материалаTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ИзделиеTableAdapter = null;
            this.tableAdapterManager.МатериалTableAdapter = null;
            this.tableAdapterManager.Состав_изделияTableAdapter = null;
            // 
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataMember = "Изделие";
            this.изделиеBindingSource.DataSource = this.cursachDataSet;
            // 
            // изделиеTableAdapter
            // 
            this.изделиеTableAdapter.ClearBeforeFill = true;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Location = new System.Drawing.Point(160, 27);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 13;
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(160, 59);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заказаDateTimePicker.TabIndex = 14;
            // 
            // дата_изготовленияDateTimePicker
            // 
            this.дата_изготовленияDateTimePicker.Location = new System.Drawing.Point(160, 94);
            this.дата_изготовленияDateTimePicker.Name = "дата_изготовленияDateTimePicker";
            this.дата_изготовленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_изготовленияDateTimePicker.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.изделиеBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ИД_Изделия";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(160, 167);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 20;
            // 
            // Добавление_заказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 250);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(иД_ИзделияLabel);
            this.Controls.Add(дата_изготовленияLabel);
            this.Controls.Add(this.дата_изготовленияDateTimePicker);
            this.Controls.Add(дата_заказаLabel);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.ОтменаButton);
            this.Controls.Add(this.ДобавитьButton);
            this.DisplayHeader = false;
            this.Name = "Добавление_заказа";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Добавление_заказа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ДобавитьButton;
        private Guna.UI2.WinForms.Guna2Button ОтменаButton;
        private CursachDataSet cursachDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private CursachDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private CursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private CursachDataSetTableAdapters.ИзделиеTableAdapter изделиеTableAdapter;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_изготовленияDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox стоимостьTextBox;
    }
}