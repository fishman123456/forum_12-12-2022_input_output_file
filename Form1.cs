using System.IO;
using System.Windows.Forms;

namespace forum_12_12_2022_input_output_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void button1_Click(object sender, EventArgs e) // TODO ЗАГРУЗИТЬ ФАЙЛ
        {

        }

        private void button2_Click(object sender, EventArgs e) // TODO СОХРАНИТЬ  ФАЙЛ
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) // Изменение скорости загрузки
        {

        }
        private void Download_Popup(object sender, PopupEventArgs e) // подсказки загрузки
        {

        }
        private void Save_Popup(object sender, PopupEventArgs e) // подсказки сохранение
        {

        }

        private void Progress_Popup(object sender, PopupEventArgs e) // подсказки статус программы, скорость
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // загрузка файла системное
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // сохранение файла системное
        {

        }
    }
}