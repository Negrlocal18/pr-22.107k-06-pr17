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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void prepodiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prepodiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_107k_12__kafedra_DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_107k_12__kafedra_DataSet.Prepodi". При необходимости она может быть перемещена или удалена.
            this.prepodiTableAdapter.Fill(this._22_107k_12__kafedra_DataSet.Prepodi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= prepodiDataGridView.Rows.Count - 1; i++)
            {



                prepodiDataGridView.Rows[i].Selected = false;


            }
            for (int i = 0; i <= prepodiDataGridView.Rows.Count - 1; i++)
            {

                for (int j = 0; j <= prepodiDataGridView.ColumnCount - 1; j++)
                {
                    if (prepodiDataGridView.Rows[i].Cells[j].Value != null && prepodiDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                    {
                        prepodiDataGridView.Rows[i].Selected = true;
                    }
                }
            }
        }
    }
}
