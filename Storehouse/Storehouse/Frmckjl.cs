using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StorehouseBLL;
using StorehouseModels;
namespace Storehouse
{
    public partial class Frmckjl : Form
    {
        public Frmckjl()
        {
            InitializeComponent();
        }

        private void Frmckjl_Load(object sender, EventArgs e)
        {
            Goodszr();
        }
        public void Goodszr()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = JiLuManager.GetAllshGoods();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
