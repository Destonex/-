using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Органайзер_мастера_ремесел
{
    public partial class Добавление_заказа : MetroForm
    {
        public Добавление_заказа()
        {
            InitializeComponent();
        }

        private void Добавление_заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Изделие". При необходимости она может быть перемещена или удалена.
            this.изделиеTableAdapter.Fill(this.cursachDataSet.Изделие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);

        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cursachDataSet);

        }

        private void ДобавитьButton_Click(object sender, EventArgs e)
        {
            CursachDataSet.ЗаказRow newRegionRow;
            newRegionRow = cursachDataSet.Заказ.NewЗаказRow();

            newRegionRow.ФИО = фИОTextBox.Text;
            newRegionRow.Дата_заказа = дата_заказаDateTimePicker.Value;
            newRegionRow.Дата_изготовления = дата_изготовленияDateTimePicker.Value;
            newRegionRow.Стоимость = Convert.ToInt32(стоимостьTextBox.Text);
            newRegionRow.ИД_Изделия = Convert.ToInt32(comboBox1.SelectedValue);


            this.cursachDataSet.Заказ.Rows.Add(newRegionRow);
            Главная for1 = new Главная();
            for1.заказTableAdapter.Update(this.cursachDataSet.Заказ);

            this.Close();
        }

        private void ОтменаButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
