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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Читачі_Запрос". При необходимости она может быть перемещена или удалена.
            this.читачі_ЗапросTableAdapter.Fill(this.bibliotekaDataSet.Читачі_Запрос);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Читачі". При необходимости она может быть перемещена или удалена.
            this.читачіTableAdapter.Fill(this.bibliotekaDataSet.Читачі);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Видача_Запрос". При необходимости она может быть перемещена или удалена.
            //this.видача_ЗапросTableAdapter.Fill(this.bibliotekaDataSet.Видача_Запрос);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void читачіBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            //int id;
            //int index;

            //index = dataGridView1.CurrentRow.Index;

            //// взять значения id = Worker.ID_Worker
            //id = (int)dataGridView1.Rows[index].Cells[0].Value;
            //читачіBindingSource.Filter = "id_читач = " + id.ToString();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;

            читачіЗапросBindingSource.Filter = "id_читач = " + id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData f = new AddData(); // создать форму
            int index;
            index = dataGridView1.CurrentRow.Index; // позиция в dataGridView1

            f.comboBox1.Visible = false;
            f.label1.Text = "Вы выбрали читателя - " + dataGridView1.Rows[index].Cells[2].Value + "\n"
                + "Номер карты читателя - " + dataGridView1.Rows[index].Cells[1].Value;

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить работника
                int id_chitat, id_khighi;
                DateTime data_vid, data_sd, data_f;

               
                id_chitat = (int)dataGridView1.Rows[index].Cells[0].Value;

                id_khighi = int.Parse(f.comboBox2.SelectedValue.ToString());
                data_vid = Convert.ToDateTime(f.dateTimePicker1.Text);
                     data_sd = Convert.ToDateTime(f.dateTimePicker2.Text);
                data_f = Convert.ToDateTime(f.dateTimePicker3.Text);

                //this.вBindingSource.EndEdit();
                this.видачаTableAdapter1.Insert(id_khighi, id_chitat, null, data_vid, data_sd, data_f); // вставка
               // this.видачаTableAdapter1.Update(bibliotekaDataSet);

                this.читачі_ЗапросTableAdapter.Fill(this.bibliotekaDataSet.Читачі_Запрос); // отображение
            }

            
        }

        private void читачіЗапросBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AddData f = new AddData(); // создать форму

             if (f.ShowDialog() == DialogResult.OK) // отобразить форму
             {
                 // если OK, то добавить работника
                 int id_chitat, id_khighi;
                 DateTime data_vid, data_sd, data_f;

                 id_chitat = int.Parse(f.comboBox1.SelectedValue.ToString());
                 id_khighi = int.Parse(f.comboBox2.SelectedValue.ToString());
                 data_vid = Convert.ToDateTime(f.dateTimePicker1.Text);
                 data_sd = Convert.ToDateTime(f.dateTimePicker2.Text);
                 data_f = Convert.ToDateTime(f.dateTimePicker3.Text);

                 //this.вBindingSource.EndEdit();
                 this.видачаTableAdapter1.Insert(id_khighi, id_chitat, null, data_vid, data_sd, data_f); // вставка
                 this.видачаTableAdapter1.Update(bibliotekaDataSet);

                 this.читачі_ЗапросTableAdapter.Fill(this.bibliotekaDataSet.Читачі_Запрос); // отображение
             }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Inventory => Delete
            DeleteData f = new DeleteData();
            int id_vid, id_chitat, id_khighi;
            String name, shifr, kniga, avtor, karta;
            DateTime data_vid, data_sd, data_f;
            int index;

            // взять индекс выделенной (текущей) строки в dataGridView2
            index = dataGridView2.CurrentRow.Index;

            // взять значения полей строки с номером index
            
            id_khighi = Convert.ToInt32(dataGridView2[0, index].Value);
            shifr = Convert.ToString(dataGridView2[1, index].Value);
            kniga = Convert.ToString(dataGridView2[2, index].Value);
            avtor = Convert.ToString(dataGridView2[3, index].Value);
            id_chitat = Convert.ToInt32(dataGridView2[4, index].Value);
            karta = Convert.ToString(dataGridView2[5, index].Value);
            name = Convert.ToString(dataGridView2[6, index].Value);
            data_vid = Convert.ToDateTime(dataGridView2[7, index].Value);
            data_sd = Convert.ToDateTime(dataGridView2[8, index].Value);
            data_f = Convert.ToDateTime(dataGridView2[9, index].Value);
            id_vid = Convert.ToInt32(dataGridView2[10, index].Value);
          
            // сформировать информационную строку в окне FormDelAccount
            f.label2.Text = name + " / " + shifr + " / " + kniga;

            if (f.ShowDialog() == DialogResult.OK) // вывести окно
            {
                this.видачаTableAdapter1.Delete(id_khighi, id_chitat, 0, data_vid, data_sd, data_f, id_vid); // удалить строку
                this.читачі_ЗапросTableAdapter.Fill(this.bibliotekaDataSet.Читачі_Запрос); // зафиксировать изменения
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.читачі_ЗапросTableAdapter.FillBy(this.bibliotekaDataSet.Читачі_Запрос);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
