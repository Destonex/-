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
    public partial class Изменение_заказа : MetroForm
    {
        public Изменение_заказа()
        {
            InitializeComponent();
        }

        private void Изменение_заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Изделие". При необходимости она может быть перемещена или удалена.
            this.изделиеTableAdapter.Fill(this.cursachDataSet.Изделие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);

        }

        private void ИзменитьButton_Click(object sender, EventArgs e)
        {
            try
            {

                Validate();
                заказBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(cursachDataSet);

                заказTableAdapter.Update(cursachDataSet);
                this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);

                this.Close();
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ОтменаButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
