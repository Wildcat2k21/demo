using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace starsInfo
{
    public partial class Form3 : Form
    {
        DBconnection DB = new DBconnection();
        private static int itemId;
        List<TextBox> textBoxes;
        List<string> sourcesName;

        public Form3(int id)
        {
            InitializeComponent();
            itemId = id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "starsDataSet3.spectrum_class". При необходимости она может быть перемещена или удалена.
            this.spectrum_classTableAdapter.Fill(this.starsDataSet3.spectrum_class);
            string sql = $"select stars_info.id, title, distance, radius, blind, class, photoPath from stars_info join spectrum_class on spectrum_class.id = stars_info.classId where stars_info.id = {itemId}";

            textBoxes = new List<TextBox>(){
                title,
                distance,
                radius,
                blind
            };

            List<string> starNames = new List<string>() {
                "Не выбрано",
                "Голубой гигант",
                "Красный гигант",
                "Белый карлик"
            };

            photoPath.DataSource = starNames;

            try {
                DataTable info = DB.ExecuteSqlCommand(sql);
                updateFiledsInForm(info);
            } catch (Exception exp) {
                MessageBox.Show(exp.Message, "Ошибка");
            }
        }

        private void updateFiledsInForm(DataTable table) {
            foreach (DataColumn col in table.Columns) {
                textBoxes.ForEach(tbox => {
                    if (tbox.Name == col.ColumnName) {
                        tbox.Text = table.Rows[0][col.ColumnName].ToString();
                    }
                });
            }

            Bitmap img;
            string imgName = table.Rows[0]["photoPath"].ToString();
            if (imgName == "") imgName = "no_select";
            string direct = Directory.GetCurrentDirectory() + $@"\data\{imgName}.png";
            img = new Bitmap(direct);
            pictureBox1.Image = img;

            photoPath.SelectedIndex = sourcesName.IndexOf(table.Rows[0]["photoPath"].ToString());
        }

        private void photoPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            sourcesName = new List<string>()
            {
               "no_select",
               "blue_giant",
               "red_giant",
               "white_dwaft"
            };

            int index = photoPath.SelectedIndex;
            string selRes = sourcesName[index];
            string direct = Directory.GetCurrentDirectory() + $@"\data\{selRes}.png";
            Bitmap img = new Bitmap(direct);
            pictureBox1.Image = img;
        }

        private bool checkDoubleNum(string numstr)
        {
            return Double.TryParse(numstr, out double val);
        }

        private bool checkIntNum(string numstr)
        {
            return Int32.TryParse(numstr, out int val);
        }

        private void cancButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewData()
        {
            int classId = Convert.ToInt32(classChar.SelectedValue);
            string selImage = sourcesName[photoPath.SelectedIndex];
            if (selImage == "no_select") selImage = "";
            string sql = $"UPDATE STARS_INFO SET title = '{title.Text}', distance = '{distance.Text.Replace(',','.')}', radius = '{radius.Text.Replace(',', '.')}', blind = '{blind.Text.Replace(',', '.')}', classId = '{classChar.SelectedValue}', photoPath = '{selImage}' WHERE id = {itemId}";
            try
            {
                DB.executeNonQuery(sql);
                MessageBox.Show("Запись успешна изменена.", "Успех");
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка");
                this.Close();
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            bool isValidEnter = true;
            List<TextBox> textBoxList = new List<TextBox>() {
                title,
                distance,
                radius,
                blind
            };

            List<ComboBox> comboxList = new List<ComboBox>() {
                classChar,
                photoPath
            };

            textBoxList.ForEach(tbox => {
                if (tbox.Text.Length == 0)
                {
                    switch (tbox.Name)
                    {
                        case "Title":
                            if (tbox.Text.Length == 0)
                                isValidEnter = false;
                            break;

                        case "distance":
                            if (!checkDoubleNum(classChar.Text))
                                isValidEnter = false;

                            break;

                        case "blind":
                            if (!checkDoubleNum(classChar.Text))
                                isValidEnter = false;

                            break;

                        case "radius":
                            if (!checkIntNum(radius.Text))
                                isValidEnter = false;

                            break;
                    }
                }
            });

            if (isValidEnter) addNewData();
            else MessageBox.Show("Название звезды обязательное поле. \n Поля Блеск, Дистанция, Радиус должны быть числом. \n Поле Радиус должно быть целочисленным.", "Ошибка заполнения");
        }
    }
}
