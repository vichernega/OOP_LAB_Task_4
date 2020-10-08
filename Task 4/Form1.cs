using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        Angle angle = new Angle();
        Angle angleCopy = new Angle();

        public Form1()
        {
            InitializeComponent();
            tb_number_multiply.Visible = false;
        }
        public void FormToObject()
        {
            if (tb_degree.Text == "") { angle.Degree = 0; }
            else { angle.Degree = Convert.ToDouble(tb_degree.Text); }

            if (tb_minute.Text == "") { angle.Minute = 0; }
            else { angle.Minute = Convert.ToDouble(tb_minute.Text); }

            if (tb_second.Text == "") { angle.Second = 0; }
            else { angle.Second = Convert.ToDouble(tb_second.Text); }

        }
        public void ObjectToForm()
        {
            tb_degree.Text = Convert.ToString(angle.Degree);
            tb_minute.Text = Convert.ToString(angle.Minute);
            tb_second.Text = Convert.ToString(angle.Second);
        }
        private void btn_plus_Click(object sender, EventArgs e)     //WORKS
        {
            FormToObject();
            label_output_1.Text = angle.ToString();
            CopyOfFirstAngle();
            label_action.Text = "+";
            ClearTextBoxes();
        }
        private void btn_minus_Click(object sender, EventArgs e)    //WORKS
        {
            FormToObject();
            label_output_1.Text = angle.ToString();
            CopyOfFirstAngle();
            label_action.Text = "-";
            ClearTextBoxes();
        }
        private void btn_multiply_Click(object sender, EventArgs e)     //WORKS
        {
            FormToObject();
            label_output_1.Text = angle.ToString();
            label_action.Text = "*";
            tb_number_multiply.Visible = true;
            label_output_2.Visible = false;
        }
        private void btn_to_radian_Click(object sender, EventArgs e)    //WORKS
        {
            FormToObject();
            label_result.Text = Convert.ToString(angle.ToRadians());
            ClearTextBoxes();
        }
        private void btn_to_angle_Click(object sender, EventArgs e)     //WORKS
        {
            if (tb_to_angle.Text == "")
            {
                angle.ToAngle(0);
                label_result.Text = angle.ToString();
                ClearTextBoxes();
            }
            else
            {
                double number = Convert.ToDouble(tb_to_angle.Text);
                angle.ToAngle(number);
                label_result.Text = angle.ToString();
                ClearTextBoxes();
            }
        }



        private void btn_result_Click(object sender, EventArgs e)
        {
            FormToObject();
            label_output_2.Text = angle.ToString();
            ActionCheck();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            ClearLabels();
            ClearTextBoxes();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            FormToObject();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"{saveFileDialog.FileName}\nГрадуси: {tb_degree.Text};" +
                    $"\nХвилини: {tb_minute.Text};\nСекунди: {tb_second.Text};");
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                angle.Write(streamWriter);
                streamWriter.Close();
            }

            /* SaveFileDialog - Запрашивает у пользователя местоположение для сохранения файла.
               Filter - "Сохранить как файл типа"
               ShowDialog() - Запускает общее диалоговое окно с заданным по умолчанию владельцем.
               DialogResult.OK - нажата ли кнопка OK
               MessageBox.Show() - окно сообщения*/
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                angle.Read(streamReader);
                streamReader.Close();
                ActionCheck();
                ObjectToForm();
            }
        }

        private void ClearTextBoxes()
        {
            tb_degree.Text = "";
            tb_minute.Text = "";
            tb_second.Text = "";
            tb_number_multiply.Text = "";
            tb_to_angle.Text = "";
        }
        private void ClearLabels()
        {
            label_output_1.Text = "";
            label_output_2.Text = "";
            label_action.Text = "";
            label_result.Text = "";
            tb_number_multiply.Visible = false;
        }
        private void CopyOfFirstAngle()
        {
            angleCopy.Degree = angle.Degree;
            angleCopy.Minute = angle.Minute;
            angleCopy.Second = angle.Second;
        }
        private void ActionCheck()
        {
            if (label_action.Text == "+")
            {
                FormToObject();
                label_result.Text = (angleCopy + angle).ToString();
                tb_number_multiply.Visible = false;
            } 
            else if (label_action.Text == "-")
            {
                FormToObject();
                label_result.Text = (angleCopy - angle).ToString();
                tb_number_multiply.Visible = false;
            }
            else if (label_action.Text == "*")
            {
                double number = Convert.ToDouble(tb_number_multiply.Text);
                label_result.Text = (angle * number).ToString();
                
            } 
            else if (label_action.Text == "")
            {
                label_result.Text = angle.ToString();
                label_output_2.Text = "";
            }
        }

    }
}
