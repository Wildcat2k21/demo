using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starsInfo
{
    public partial class Form1 : Form
    {
        private DBconnection DB = new DBconnection();
        private BindingSource binding = new BindingSource();
        private List<int> valMembers;
        private int selItemID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = binding;
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStart starForm = new AddStart();
            starForm.ShowDialog();
            updateView();
        }

        private void getData() {
            string sql = "select stars_info.id, title as 'Наименование', distance as 'Дистанция', radius as 'Радиус', blind as 'Блеск', class as 'Класс' from stars_info join spectrum_class on spectrum_class.id = stars_info.classId";

            try
            {
                DataTable result = DB.ExecuteSqlCommand(sql);
                valMembers = new List<int>();

                foreach (DataRow row in result.Rows)
                {
                    valMembers.Add(Convert.ToInt32(row["id"]));
                }

                DataTable copy = result;
                copy.Columns.RemoveAt(0);
                binding.DataSource = copy;

            } catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка");
            }
        }

        private void updateView() {
            try
            {
                DB.executeNonQuery("select stars_info.id, title as 'Наименование', distance as 'Дистанция', radius as 'Радиус', blind as 'Блеск', class as 'Класс' from stars_info join spectrum_class on spectrum_class.id = stars_info.classId");
                /*int selIndex = dataGridView1.CurrentCell.RowIndex;*/
                //string str = dataGridView1[0, selIndex].Value.ToString();

                /*                selItemID = valMembers[selIndex];*/
                dataGridView1.DataSource = binding;
                getData();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selItemID != null) {
                Attension delAtten = new Attension();
                delAtten.ShowDialog();
                if (delAtten.IsDeleteSelect())
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    int id = valMembers[index];
                    string sql = $"delete from stars_info where id = {id}";
                    try
                    {
                        DB.executeNonQuery(sql);
                        MessageBox.Show("Запись успешно удалена", "успех");
                        updateView();
                    }
                    catch(Exception exp) {
                        MessageBox.Show(exp.Message, "Ошибка");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int itemindx = dataGridView1.CurrentCell.RowIndex;
            int itemId = valMembers[itemindx];

            Form3 addForm = new Form3(itemId);
            addForm.ShowDialog();
            updateView();
        }
    }
}
