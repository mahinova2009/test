using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.bibliotekaDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Читачі". При необходимости она может быть перемещена или удалена.
            this.читачіTableAdapter.Fill(this.bibliotekaDataSet.Читачі);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
