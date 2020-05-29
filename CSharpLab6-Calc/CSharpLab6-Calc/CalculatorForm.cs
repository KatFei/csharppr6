using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharpLab6_Calc
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        Double size = 0;

        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
            foreach(Button cntrl in this.tableLayoutPanel1.Controls){
                if ((cntrl.Tag.ToString() == "dot")||(int.TryParse(cntrl.Text.ToString(), out _))) 
                    //cntrl.Text.ToString().All(Char.IsDigit)
                {
                    cntrl.Click += bNumeric_Click; }
                cntrl.Dock = DockStyle.Fill;
            }

            foreach (Control cntrl in this.flLayoutTop.Controls)
            {
                cntrl.Dock = DockStyle.Fill;
            }
            tableLayoutPanel1.Dock = DockStyle.Fill;
            
            flLayoutTop.Dock = DockStyle.Fill;
            
            size = labelResult.Font.Size;
        }
        private void ResizeLblResult()
        {
            //от какого Width должна зависеть длина текста в label??
            //if (labelResult.Width >= tableLayoutPanel1.Size.Width - 40)
            if (labelResult.Width >= this.Size.Width - 65)
            {
                while (labelResult.Width < System.Windows.Forms.TextRenderer.MeasureText(labelResult.Text,
                new Font(labelResult.Font.FontFamily, labelResult.Font.Size, labelResult.Font.Style)).Width)
                {
                    labelResult.Font = new Font(labelResult.Font.FontFamily, labelResult.Font.Size - 2f, labelResult.Font.Style);
                }
            }
            
            else
            //if (labelResult.Width < tableLayoutPanel1.Size.Width - 60)
            if (labelResult.Width < this.Size.Width - 80)
            {
                float formWidth = this.CurrentAutoScaleDimensions.Width;
                //ResizeLblResult();
                //labelResult.Font = new Font(labelResult.Font.FontFamily, (float)size, labelResult.Font.Style);
                //if (labelResult.Width >= this.ClientSize.Width - 50)
                //{
                //    while (labelResult.Width < System.Windows.Forms.TextRenderer.MeasureText(labelResult.Text,
                //    new Font(labelResult.Font.FontFamily, labelResult.Font.Size, labelResult.Font.Style)).Width)
                //    {
                //        labelResult.Font = new Font(labelResult.Font.FontFamily, labelResult.Font.Size - 2f, labelResult.Font.Style);
                //    }
                //}
                
                if (labelResult.Width >= this.Size.Width - 65)
                {
                    while (labelResult.Width < System.Windows.Forms.TextRenderer.MeasureText(labelResult.Text,
                    new Font(labelResult.Font.FontFamily, labelResult.Font.Size, labelResult.Font.Style)).Width)
                    {
                        labelResult.Font = new Font(labelResult.Font.FontFamily, labelResult.Font.Size - 2f, labelResult.Font.Style);
                    }
                }
            }

        }
        
        private Double Calculate() {
            switch (operation)
            {
                case "+":
                    value = value + Double.Parse(labelResult.Text);
                    break;
                case "-":
                    value = value - Double.Parse(labelResult.Text); 
                    break;
                case "*":
                    value = value * Double.Parse(labelResult.Text);
                    break;
                case "/":
                    value = value / Double.Parse(labelResult.Text);
                    break;
                default:
                    break;
            }
            Clipboard.SetText(value.ToString());
            return value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "";
            //! ! !
            //учитывать возможное изменение длины > n=16 поддерживаемых  символов
            labelResult.Text = Calculate().ToString();
            
            operation_pressed = false;
            operation = "";
        }

        private void bNumeric_Click(object sender, EventArgs e)
        {
            // максимум 16 цифр
            if (labelResult.Text.Replace(".", "").Length < 16) {
                if (labelResult.Text == "NaN")
                    labelResult.Text = "";
                Button b = (Button)sender;
                if ((labelResult.Text == "0") || (operation_pressed))
                { 
                    if(b.Text.ToString() =="."){ 
                        labelResult.Text = "0."; //"0."; переделать в точку везде
                    }
                    else
                        labelResult.Text = b.Text;
                    operation_pressed = false;

                }
                else
                    if ((b.Text != ".") || (!labelResult.Text.Contains("."))) 
                    { 
                        labelResult.Text = labelResult.Text + ((Button)sender).Text;//+ b.Text;
                    }

            }
        }
        private void bOperator_Click(object sender, EventArgs e)
        {
            if (!operation_pressed) {
                //Button b = (Button)sender;
                //передний пробел будет появляться если изначально там пусто

                // если ни на что не влияет:
                labelResult.Text = Double.Parse(labelResult.Text).ToString();
                // или lblEquation.Text += " " + Double.Parse(labelResult.Text).ToString();
                lblEquation.Text += " " + labelResult.Text;
                if (operation != "") {
                    //! ! !
                    //учитывать возможное изменение длины > n=16 поддерживаемых  символов
                    labelResult.Text = Calculate().ToString();
                }
                operation = ((Button)sender).Text;
                // можно как else все равно мы установили в if lblResult = value
                value = Double.Parse(labelResult.Text);
                //value = Double.Parse(labelResult.Text, CultureInfo.InvariantCulture);
                //чтобы точка воспринималась как разделитель (точнее чтобы это зависило от платформы)
                //value = System.Xml.XmlConvert.ToDouble(labelResult.Text);
                operation_pressed = true;
                //передний пробел будет появляться если изначально там пусто
                lblEquation.Text += " " + operation;

            }
            //если кнопка операции нажата 2ой раз подряд
            else
            {
                // удаляем последнюю операцию из lblEquation
                String eq = lblEquation.Text.ToString();
                lblEquation.Text = eq.TrimEnd(operation.ToCharArray());
                //меняем значение operation
                operation = ((Button)sender).Text;
                // добавляем новую операцию в lblEquation
                lblEquation.Text = lblEquation.Text + operation;
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
                labelResult.Text = "0"; // ((Button)sender).Text.ToString();
                lblEquation.Text = "";
                value = 0;
                operation = "";
        }

        private void flLayoutAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculator_ResizeEnd(object sender, EventArgs e)
        {
            this.ResizeLblResult();
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch(e.KeyChar.ToString())
            {
                case "1":
                    but1.PerformClick();
                    break;
                case "2":
                    but2.PerformClick();
                    break;
                case "3":
                    but3.PerformClick();
                    break;
                case "4":
                    but4.PerformClick();
                    break;
                case "5":
                    but5.PerformClick();
                    break;
                case "6":
                    but6.PerformClick();
                    break;
                case "7":
                    but7.PerformClick();
                    break;
                case "8":
                    but8.PerformClick();
                    break;
                case "9":
                    but9.PerformClick();
                    break;
                case "0":
                    butZero.PerformClick();
                    break;
                case ".":
                    butDot.PerformClick();
                    break;
                case "+":
                    butAdd.PerformClick();
                    break;
                case "-":
                    butMinus.PerformClick();
                    break;
                case "*":
                    butMultiply.PerformClick();
                    break;
                case "/":
                    butDiv.PerformClick();
                    break;
                case "=":
                    butEqual.PerformClick();
                    break;
                case "BackSpace":
                    butCE.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void labelResult_TextChanged(object sender, EventArgs e)
        {
            this.ResizeLblResult();
        }

        private void Calculator_SizeChanged(object sender, EventArgs e)
        {
            this.ResizeLblResult();
        }
    }
}
