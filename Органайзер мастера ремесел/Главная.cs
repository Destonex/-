using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Органайзер_мастера_ремесел
{
    public partial class Главная : MetroForm
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cursach.mdb";
        OleDbConnection myConnection;
        public Главная()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Состав_изделия". При необходимости она может быть перемещена или удалена.
            this.состав_изделияTableAdapter.Fill(this.cursachDataSet.Состав_изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Изделие". При необходимости она может быть перемещена или удалена.
            this.изделиеTableAdapter.Fill(this.cursachDataSet.Изделие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter.Fill(this.cursachDataSet.Материал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Вид_материала". При необходимости она может быть перемещена или удалена.
            this.вид_материалаTableAdapter.Fill(this.cursachDataSet.Вид_материала);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursachDataSet.Заказ". При необходимости она может быть перемещена или удалена.

        }

        private void Главная_Activated(object sender, EventArgs e)
        {
            Validate();
            заказBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cursachDataSet);

            заказTableAdapter.Update(cursachDataSet);
            this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);
        }

        private void Заказ1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void Заказ2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void Заказ3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void Заказ4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void Заказ5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
        }

        private void ВидМатериала1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void ВидМатериала2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void ВидМатериала3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void ВидМатериала4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void ВидМатериала5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void Материал1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void Материал2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void Материал3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void Материал4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void Материал5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
        }

        private void Изделие1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void Изделие2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void Изделие3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void Изделие4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void Изделие5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 3;
        }

        private void СоставИзделия1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void СоставИзделия2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void СоставИзделия3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void СоставИзделия4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void СоставИзделия5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 4;
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cursachDataSet);

        }

        /// Таблица заказ
        private void buttonДобавитьЗаказ_Click(object sender, EventArgs e)
        {
            Добавление_заказа добавление = new Добавление_заказа();
            добавление.ShowDialog();
        }

        private void buttonИзменитьЗаказ_Click(object sender, EventArgs e)
        {
            Изменение_заказа form = new Изменение_заказа();
            form.ShowDialog();
        }

        private void buttonУдалитьЗаказ_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Index;
            Удаление form = new Удаление();
            form.ShowDialog();

            try
            {
                bool DeleteBool = Удаление.DeleteBool;
                if (DeleteBool == true)
                {
                    заказBindingSource.RemoveAt(index);
                    Validate();
                    заказBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cursachDataSet);
                }
            }

            catch (System.Data.OleDb.OleDbException)
            {
                заказTableAdapter.Fill(cursachDataSet.Заказ);
                MessageBox.Show("Элемент не может быть удалён, так как он используется в программе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonРасчетЗаказ_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView1.Rows.Count + 1; i++)//cursachDataSet.ЗаказDataTable
            {
                //CursachDataSet.ИзделиеDataTable составs = new CursachDataSet.ИзделиеDataTable();
                //double sum = Convert.ToDouble(изделиеTableAdapter.FillBy(составs, i));

                CursachDataSet.ЗаказDataTable заказs = new CursachDataSet.ЗаказDataTable();
                double sum = Convert.ToDouble(заказTableAdapter.FillBy(заказs, i));

                string query = "UPDATE Заказ SET Стоимость = " + sum + " WHERE [ИД_Заказа] = " + Convert.ToInt32(dataGridView1.Rows[i - 1].Cells["иДЗаказаDataGridViewTextBoxColumn"].Value);
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
            }

            this.заказTableAdapter.Fill(this.cursachDataSet.Заказ);
        }

        private void buttonОтчет_Click(object sender, EventArgs e)
        {

        }

        private void buttonСохранитьОтчет_Click(object sender, EventArgs e)
        {

        }

        /// Таблица вид материала
        private void buttonДобавитьВидМатериала_Click(object sender, EventArgs e)
        {
            buttonДобавитьВидМатериала.Enabled = false;
            buttonИзменитьВидМатериала.Enabled = false;
            buttonУдалитьВидМатериала.Enabled = false;
            buttonСохранитьВидМатериала.Enabled = true;
            buttonОтменаВидМатериала.Enabled = true;

            вид_материалаLabel.Visible = true;
            вид_материалаTextBox.Visible = true;

            вид_материалаBindingSource.AddNew();

            dataGridView2.Enabled = false;
        }

        private void buttonИзменитьВидМатериала_Click(object sender, EventArgs e)
        {
            buttonДобавитьВидМатериала.Enabled = false;
            buttonИзменитьВидМатериала.Enabled = false;
            buttonУдалитьВидМатериала.Enabled = false;
            buttonСохранитьВидМатериала.Enabled = true;
            buttonОтменаВидМатериала.Enabled = true;

            вид_материалаLabel.Visible = true;
            вид_материалаTextBox.Visible = true;
        }

        private void buttonУдалитьВидМатериала_Click(object sender, EventArgs e)
        {
            Удаление form = new Удаление();
            form.ShowDialog();

            try
            {
                bool DeleteBool = Удаление.DeleteBool;
                if (DeleteBool == true)
                {
                    вид_материалаBindingSource.RemoveCurrent();
                    Validate();
                    вид_материалаBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cursachDataSet);
                }
            }

            catch (System.Data.OleDb.OleDbException)
            {
                вид_материалаTableAdapter.Fill(cursachDataSet.Вид_материала);
                MessageBox.Show("Элемент не может быть удалён, так как он используется в программе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonСохранитьВидМатериала_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                вид_материалаBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cursachDataSet);

                вид_материалаTableAdapter.Update(cursachDataSet);
                this.вид_материалаTableAdapter.Fill(this.cursachDataSet.Вид_материала);

                buttonДобавитьВидМатериала.Enabled = true;
                buttonИзменитьВидМатериала.Enabled = true;
                buttonУдалитьВидМатериала.Enabled = true;
                buttonСохранитьВидМатериала.Enabled = false;
                buttonОтменаВидМатериала.Enabled = false;

                вид_материалаLabel.Visible = false;
                вид_материалаTextBox.Visible = false;

                dataGridView2.Enabled = true;
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonОтменаВидМатериала_Click(object sender, EventArgs e)
        {
            buttonДобавитьВидМатериала.Enabled = true;
            buttonИзменитьВидМатериала.Enabled = true;
            buttonУдалитьВидМатериала.Enabled = true;
            buttonСохранитьВидМатериала.Enabled = false;
            buttonОтменаВидМатериала.Enabled = false;

            вид_материалаLabel.Visible = false;
            вид_материалаTextBox.Visible = false;

            вид_материалаBindingSource.CancelEdit();
        }

        /// Таблица материал
        private void buttonДобавитьМатериал_Click(object sender, EventArgs e)
        {

            buttonДобавитьМатериал.Enabled = false;
            buttonИзменитьМатериал.Enabled = false;
            buttonУдалитьМатериал.Enabled = false;
            buttonСохранитьМатериал.Enabled = true;
            buttonОтменаМатериал.Enabled = true;

            наименованиеLabel.Visible = true;
            количествоLabel.Visible = true;
            ценаLabel.Visible = true;
            видLabel.Visible = true;
            иД_вид_материалаLabel.Visible = true;

            наименованиеTextBox.Visible = true;
            количествоTextBox.Visible = true;
            ценаTextBox.Visible = true;
            видTextBox.Visible = true;
            иД_вид_материалаTextBox.Visible = true;

            материалBindingSource.AddNew();

            dataGridView3.Enabled = false;
        }

        private void buttonИзменитьМатериал_Click(object sender, EventArgs e)
        {
            buttonДобавитьМатериал.Enabled = false;
            buttonИзменитьМатериал.Enabled = false;
            buttonУдалитьМатериал.Enabled = false;
            buttonСохранитьМатериал.Enabled = true;
            buttonОтменаМатериал.Enabled = true;

            наименованиеLabel.Visible = true;
            количествоLabel.Visible = true;
            ценаLabel.Visible = true;
            видLabel.Visible = true;
            иД_вид_материалаLabel.Visible = true;

            наименованиеTextBox.Visible = true;
            количествоTextBox.Visible = true;
            ценаTextBox.Visible = true;
            видTextBox.Visible = true;
            иД_вид_материалаTextBox.Visible = true;
        }

        private void buttonУдалитьМатериал_Click(object sender, EventArgs e)
        {
            Удаление form = new Удаление();
            form.ShowDialog();

            try
            {
                bool DeleteBool = Удаление.DeleteBool;
                if (DeleteBool == true)
                {
                    материалBindingSource.RemoveCurrent();
                    Validate();
                    материалBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cursachDataSet);
                }
            }

            catch (System.Data.OleDb.OleDbException)
            {
                материалTableAdapter.Fill(cursachDataSet.Материал);
                MessageBox.Show("Элемент не может быть удалён, так как он используется в программе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonСохранитьМатериал_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                материалBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cursachDataSet);

                материалTableAdapter.Update(cursachDataSet);
                this.материалTableAdapter.Fill(this.cursachDataSet.Материал);

                buttonДобавитьМатериал.Enabled = true;
                buttonИзменитьМатериал.Enabled = true;
                buttonУдалитьМатериал.Enabled = true;
                buttonСохранитьМатериал.Enabled = false;
                buttonОтменаМатериал.Enabled = false;

                наименованиеLabel.Visible = false;
                количествоLabel.Visible = false;
                ценаLabel.Visible = false;
                видLabel.Visible = false;
                иД_вид_материалаLabel.Visible = false;

                наименованиеTextBox.Visible = false;
                количествоTextBox.Visible = false;
                ценаTextBox.Visible = false;
                видTextBox.Visible = false;
                иД_вид_материалаTextBox.Visible = false;

                dataGridView3.Enabled = true;
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonОтменаМатериал_Click(object sender, EventArgs e)
        {
            buttonДобавитьМатериал.Enabled = true;
            buttonИзменитьМатериал.Enabled = true;
            buttonУдалитьМатериал.Enabled = true;
            buttonСохранитьМатериал.Enabled = false;
            buttonОтменаМатериал.Enabled = false;

            наименованиеLabel.Visible = false;
            количествоLabel.Visible = false;
            ценаLabel.Visible = false;
            видLabel.Visible = false;
            иД_вид_материалаLabel.Visible = false;

            наименованиеTextBox.Visible = false;
            количествоTextBox.Visible = false;
            ценаTextBox.Visible = false;
            видTextBox.Visible = false;
            иД_вид_материалаTextBox.Visible = false;

            материалBindingSource.CancelEdit();
        }

        /// Таблица изделие
        private void buttonДобавитьИзделие_Click(object sender, EventArgs e)
        {
            buttonДобавитьИзделие.Enabled = false;
            buttonИзменитьИзделие.Enabled = false;
            buttonУдалитьИзделие.Enabled = false;
            buttonСохранитьИзделие.Enabled = true;
            buttonОтменаИзделие.Enabled = true;

            названиеLabel.Visible = true;
            ценаLabel1.Visible = true;

            названиеTextBox.Visible = true;
            ценаTextBox1.Visible = true;


            изделиеBindingSource.AddNew();

            dataGridView4.Enabled = false;
        }

        private void buttonИзменитьИзделие_Click(object sender, EventArgs e)
        {
            buttonДобавитьИзделие.Enabled = false;
            buttonИзменитьИзделие.Enabled = false;
            buttonУдалитьИзделие.Enabled = false;
            buttonСохранитьИзделие.Enabled = true;
            buttonОтменаИзделие.Enabled = true;

            названиеLabel.Visible = true;
            ценаLabel1.Visible = true;

            названиеTextBox.Visible = true;
            ценаTextBox1.Visible = true;
        }

        private void buttonУдалитьИзделие_Click(object sender, EventArgs e)
        {
            Удаление form = new Удаление();
            form.ShowDialog();

            try
            {
                bool DeleteBool = Удаление.DeleteBool;
                if (DeleteBool == true)
                {
                    изделиеBindingSource.RemoveCurrent();
                    Validate();
                    изделиеBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cursachDataSet);
                }
            }

            catch (System.Data.OleDb.OleDbException)
            {
                изделиеTableAdapter.Fill(cursachDataSet.Изделие);
                MessageBox.Show("Элемент не может быть удалён, так как он используется в программе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonСохранитьИзделие_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                изделиеBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cursachDataSet);

                изделиеTableAdapter.Update(cursachDataSet);
                this.изделиеTableAdapter.Fill(this.cursachDataSet.Изделие);


                buttonДобавитьИзделие.Enabled = true;
                buttonИзменитьИзделие.Enabled = true;
                buttonУдалитьИзделие.Enabled = true;
                buttonСохранитьИзделие.Enabled = false;
                buttonОтменаИзделие.Enabled = false;

                названиеLabel.Visible = false;
                ценаLabel1.Visible = false;

                названиеTextBox.Visible = false;
                ценаTextBox1.Visible = false;

                dataGridView4.Enabled = true;
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonОтменаИзделие_Click(object sender, EventArgs e)
        {
            buttonДобавитьИзделие.Enabled = true;
            buttonИзменитьИзделие.Enabled = true;
            buttonУдалитьИзделие.Enabled = true;
            buttonСохранитьИзделие.Enabled = false;
            buttonОтменаИзделие.Enabled = false;

            названиеLabel.Visible = false;
            ценаLabel1.Visible = false;

            названиеTextBox.Visible = false;
            ценаTextBox1.Visible = false;

            изделиеBindingSource.CancelEdit();
        }

        private void buttonРасчетИзделие_Click(object sender, EventArgs e)
        {

        }

        /// Таблица состав изделия
        private void buttonДобавитьСоставИзделия_Click(object sender, EventArgs e)
        {
            buttonДобавитьСоставИзделия.Enabled = false;
            buttonИзменитьСоставИзделия.Enabled = false;
            buttonУдалитьСоставИзделия.Enabled = false;
            buttonСохранитьСоставИзделия.Enabled = true;
            buttonОтменаСоставИзделия.Enabled = true;

            количествоLabel1.Visible = true;
            иД_МатериалаLabel.Visible = true;
            иД_ИзделияLabel.Visible = true;

            количествоTextBox1.Visible = true;
            иД_МатериалаTextBox.Visible = true;
            иД_ИзделияTextBox.Visible = true;


            состав_изделияBindingSource.AddNew();

            dataGridView5.Enabled = false;
        }

        private void buttonИзменитьСоставИзделия_Click(object sender, EventArgs e)
        {
            buttonДобавитьСоставИзделия.Enabled = false;
            buttonИзменитьСоставИзделия.Enabled = false;
            buttonУдалитьСоставИзделия.Enabled = false;
            buttonСохранитьСоставИзделия.Enabled = true;
            buttonОтменаСоставИзделия.Enabled = true;

            количествоLabel1.Visible = true;
            иД_МатериалаLabel.Visible = true;
            иД_ИзделияLabel.Visible = true;

            количествоTextBox1.Visible = true;
            иД_МатериалаTextBox.Visible = true;
            иД_ИзделияTextBox.Visible = true;
        }

        private void buttonУдалитьСоставИзделия_Click(object sender, EventArgs e)
        {
            Удаление form = new Удаление();
            form.ShowDialog();

            try
            {
                bool DeleteBool = Удаление.DeleteBool;
                if (DeleteBool == true)
                {
                    состав_изделияBindingSource.RemoveCurrent();
                    Validate();
                    состав_изделияBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(cursachDataSet);
                }
            }

            catch (System.Data.OleDb.OleDbException)
            {
                состав_изделияTableAdapter.Fill(cursachDataSet.Состав_изделия);
                MessageBox.Show("Элемент не может быть удалён, так как он используется в программе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonСохранитьСоставИзделия_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                состав_изделияBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(cursachDataSet);

                состав_изделияTableAdapter.Update(cursachDataSet);
                this.состав_изделияTableAdapter.Fill(this.cursachDataSet.Состав_изделия);


                buttonДобавитьСоставИзделия.Enabled = true;
                buttonИзменитьСоставИзделия.Enabled = true;
                buttonУдалитьСоставИзделия.Enabled = true;
                buttonСохранитьСоставИзделия.Enabled = false;
                buttonОтменаСоставИзделия.Enabled = false;

                количествоLabel1.Visible = false;
                иД_МатериалаLabel.Visible = false;
                иД_ИзделияLabel.Visible = false;

                количествоTextBox1.Visible = false;
                иД_МатериалаTextBox.Visible = false;
                иД_ИзделияTextBox.Visible = false;

                dataGridView5.Enabled = true;
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Не все обязательные поля заполнены", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonОтменаСоставИзделия_Click(object sender, EventArgs e)
        {
            buttonДобавитьСоставИзделия.Enabled = true;
            buttonИзменитьСоставИзделия.Enabled = true;
            buttonУдалитьСоставИзделия.Enabled = true;
            buttonСохранитьСоставИзделия.Enabled = false;
            buttonОтменаСоставИзделия.Enabled = false;

            количествоLabel1.Visible = false;
            иД_МатериалаLabel.Visible = false;
            иД_ИзделияLabel.Visible = false;

            количествоTextBox1.Visible = false;
            иД_МатериалаTextBox.Visible = false;
            иД_ИзделияTextBox.Visible = false;

            состав_изделияBindingSource.CancelEdit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                заказBindingSource.Filter = string.Format("ФИО LIKE '{0}%'", textBox1.Text);
            }
            else if (textBox1.Text == null)
                заказBindingSource.RemoveFilter();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                материалBindingSource.Filter = string.Format("Наименование LIKE '{0}%'", textBox2.Text);
            }
            else if (textBox2.Text == null)
            материалBindingSource.RemoveFilter();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                изделиеBindingSource.Filter = string.Format("Название LIKE '{0}%'", textBox3.Text);
            }
            else if (textBox3.Text == null)
                изделиеBindingSource.RemoveFilter();
        }

        private void Главная_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
