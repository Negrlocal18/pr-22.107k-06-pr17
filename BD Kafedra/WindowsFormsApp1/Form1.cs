using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fakul_tetiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fakul_tetiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_107k_12__kafedra_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_107k_12__kafedra_DataSet._Fakul_teti". При необходимости она может быть перемещена или удалена.
            this.fakul_tetiTableAdapter.Fill(this._22_107k_12__kafedra_DataSet._Fakul_teti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fakul_tetiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_107k_12__kafedra_DataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.fakul_tetiBindingSource.RemoveCurrent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
