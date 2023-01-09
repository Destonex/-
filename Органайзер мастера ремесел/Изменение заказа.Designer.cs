namespace Органайзер_мастера_ремесел
{
    partial class Изменение_заказа
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
            System.Windows.Forms.Label иД_ИзделияLabel;
            System.Windows.Forms.Label дата_изготовленияLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изменение_заказа));
            System.Windows.Forms.Label стоимостьLabel;
            this.ИзменитьButton = new Guna.UI2.WinForms.Guna2Button();
            this.ОтменаButton = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.дата_изготовленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.cursachDataSet = new Органайзер_мастера_ремесел.CursachDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.ЗаказTableAdapter();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделиеTableAdapter = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.ИзделиеTableAdapter();
            this.tableAdapterManager1 = new Органайзер_мастера_ремесел.CursachDataSetTableAdapters.TableAdapterManager();
            иД_ИзделияLabel = new System.Windows.Forms.Label();
            дата_изготовленияLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ИзменитьButton
            // 
            this.ИзменитьButton.BorderRadius = 10;
            this.ИзменитьButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ИзменитьButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ИзменитьButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ИзменитьButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ИзменитьButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.ИзменитьButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ИзменитьButton.ForeColor = System.Drawing.Color.White;
            this.ИзменитьButton.Location = new System.Drawing.Point(23, 209);
            this.ИзменитьButton.Name = "ИзменитьButton";
            this.ИзменитьButton.Size = new System.Drawing.Size(96, 29);
            this.ИзменитьButton.TabIndex = 11;
            this.ИзменитьButton.Text = "Изменить";
            this.ИзменитьButton.Click += new System.EventHandler(this.ИзменитьButton_Click);
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
            this.ОтменаButton.TabIndex = 12;
            this.ОтменаButton.Text = "Отмена";
            this.ОтменаButton.Click += new System.EventHandler(this.ОтменаButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заказBindingSource, "ИД_Изделия", true));
            this.comboBox1.DataSource = this.изделиеBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ИД_Изделия";
            // 
            // иД_ИзделияLabel
            // 
            иД_ИзделияLabel.AutoSize = true;
            иД_ИзделияLabel.Location = new System.Drawing.Point(45, 135);
            иД_ИзделияLabel.Name = "иД_ИзделияLabel";
            иД_ИзделияLabel.Size = new System.Drawing.Size(54, 13);
            иД_ИзделияLabel.TabIndex = 24;
            иД_ИзделияLabel.Text = "Изделие:";
            // 
            // дата_изготовленияLabel
            // 
            дата_изготовленияLabel.AutoSize = true;
            дата_изготовленияLabel.Location = new System.Drawing.Point(45, 100);
            дата_изготовленияLabel.Name = "дата_изготовленияLabel";
            дата_изготовленияLabel.Size = new System.Drawing.Size(109, 13);
            дата_изготовленияLabel.TabIndex = 22;
            дата_изготовленияLabel.Text = "Дата изготовления:";
            // 
            // дата_изготовленияDateTimePicker
            // 
            this.дата_изготовленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата изготовления", true));
            this.дата_изготовленияDateTimePicker.Location = new System.Drawing.Point(160, 94);
            this.дата_изготовленияDateTimePicker.Name = "дата_изготовленияDateTimePicker";
            this.дата_изготовленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_изготовленияDateTimePicker.TabIndex = 25;
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(45, 65);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 20;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(160, 59);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заказаDateTimePicker.TabIndex = 23;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(45, 30);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 18;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(160, 27);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 21;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(20, 30);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(370, 25);
            this.заказBindingNavigator.TabIndex = 19;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            this.заказBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(45, 170);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 27;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(160, 167);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 28;
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
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataMember = "Изделие";
            this.изделиеBindingSource.DataSource = this.cursachDataSet;
            // 
            // изделиеTableAdapter
            // 
            this.изделиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Органайзер_мастера_ремесел.CursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Вид_материалаTableAdapter = null;
            this.tableAdapterManager1.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager1.ИзделиеTableAdapter = this.изделиеTableAdapter;
            this.tableAdapterManager1.МатериалTableAdapter = null;
            this.tableAdapterManager1.Состав_изделияTableAdapter = null;
            // 
            // Изменение_заказа
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
            this.Controls.Add(this.заказBindingNavigator);
            this.Controls.Add(this.ОтменаButton);
            this.Controls.Add(this.ИзменитьButton);
            this.DisplayHeader = false;
            this.Name = "Изменение_заказа";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Изменение_заказа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ИзменитьButton;
        private Guna.UI2.WinForms.Guna2Button ОтменаButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker дата_изготовленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private CursachDataSet cursachDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private CursachDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private CursachDataSetTableAdapters.ИзделиеTableAdapter изделиеTableAdapter;
        private CursachDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}