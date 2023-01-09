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
    public partial class Удаление : MetroForm
    {
        static public bool DeleteBool = false;
        public Удаление()
        {
            InitializeComponent();
        }

        private void Удаление_Load(object sender, EventArgs e)
        {

        }

        private void УдалитьButton_Click(object sender, EventArgs e)
        {
            DeleteBool = true;
            Close();
        }

        private void ОтменаButton_Click(object sender, EventArgs e)
        {
            DeleteBool = false;
            Close();
        }
    }
}
