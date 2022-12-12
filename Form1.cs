using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forum_12_12_2022_input_output_file
{
    public partial class Form1 : Form
    {
        string? fileText =null;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
           
        }
        private void button1_Click(object sender, EventArgs e) // TODO ��������� ����
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // �������� ��������� ����
            string filename = openFileDialog1.FileName;
            // ������ ���� � ������
            fileText = System.IO.File.ReadAllText(filename);
            for (int i = 0; i < fileText.Length; i++)
            {
                progressBar1.PerformStep();
            }
            button2.Enabled = true;
           // MessageBox.Show("���� ������");
        }

        private void button2_Click(object sender, EventArgs e) // TODO �������� ���� � ������ �����
        { 
           Form2 form2= new Form2( fileText);
            form2.ShowDialog();
            
            this.Close();  
        }

        private void progressBar1_Click(object sender, EventArgs e) // ��������� �������� ��������
        {
           progressBar1.Minimum= 0;
            progressBar1.Maximum= fileText.Length;
        }
        private void Download_Popup(object sender, PopupEventArgs e) // ��������� ��������
        {

        }
        private void Save_Popup(object sender, PopupEventArgs e) // ��������� ����������
        {

        }

        private void Progress_Popup(object sender, PopupEventArgs e) // ��������� ������ ���������, ��������
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // �������� ����� ���������
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // ���������� ����� ���������
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}