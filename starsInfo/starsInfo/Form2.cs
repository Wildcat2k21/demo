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
    public partial class AddStart : Form
    {
        DBconnection DB = new DBconnection();
        private List<string> sourceName = new List<string>()
        {
            "no_select",
            "blue_giant",
            "red_giant",
            "white_dwaft"
        };

        public AddStart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "starsDataSet2.spectrum_class". При необходимости она может быть перемещена или удалена.
            this.spectrum_classTableAdapter.Fill(this.starsDataSet2.spectrum_class);
            initDataForImgCombox();
        }

        private void initDataForImgCombox()
        {
            List<string> imgData = new List<string>
            {
                "Не выбрано",
                "Голубой Гигант",
                "Красный Карлик",
                "Белый Карлик"
            };

            photoPath.DataSource = imgData;
            photoPath.DisplayMember = "Name";
        }

        private bool checkDoubleNum(string numstr)
        {
            return Double.TryParse(numstr, out double val);
        }

        private bool checkIntNum(string numstr)
        {
            return Int32.TryParse(numstr, out int val);
        }

        private void photoPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedImageName = sourceName[photoPath.SelectedIndex];
            string direct = Directory.GetCurrentDirectory() + $@"\data\{selectedImageName}.png";
            Bitmap starImg = new Bitmap(direct);
            pictureBox1.Image = starImg;
        }

        private void addButton_Click(object sender, EventArgs e)
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
                    switch (tbox.Name) {
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


        private void addNewData() {
            int classId = Convert.ToInt32(classChar.SelectedValue);
            string imgName = sourceName[photoPath.SelectedIndex];
            string sql = $"INSERT INTO [dbo].[stars_info] values ('{title.Text}', {distance.Text}, {radius.Text}, {blind.Text}, {classId}, '{imgName}')";

            try
            {
                DB.executeNonQuery(sql);
                MessageBox.Show("Запись успешно добавлена.", "Успех");
                this.Close();
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message, "Ошибка");
                this.Close();
            }
        }

        private void cancButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
