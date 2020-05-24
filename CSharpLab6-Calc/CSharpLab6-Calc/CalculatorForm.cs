using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLab6_Calc
{
    public partial class Calculator : Form
    {
        Double value = 0; //result ?
        String operation = "";
        //String queue = "";
        
        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
            foreach(Button cntrl in this.tableLayoutPanel1.Controls){
                if ((cntrl.Tag.ToString() == "dot")||(int.TryParse(cntrl.Text.ToString(), out _))) 
                    //cntrl.Text.ToString().All(Char.IsDigit)
                {
                    cntrl.Click += bNumeric_Click; }
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
            labelResult.Text = Calculate().ToString();
            //запихнуть это в функцию Calculate а этот handler назвать Equal_Click 
            //switch (operation)
            //{
            //    case "+":
            //        labelResult.Text = (value + Double.Parse(labelResult.Text)).ToString();
            //        break;
            //    case "-":
            //        labelResult.Text = (value - Double.Parse(labelResult.Text)).ToString();
            //        break;
            //    case "*":
            //        labelResult.Text = (value * Double.Parse(labelResult.Text)).ToString();
            //        break;
            //    case "/":
            //        labelResult.Text = (value / Double.Parse(labelResult.Text)).ToString();
            //        break;
            //    default:
            //        break;
            //}
            //добавлять промежуточный результат в буфер обмена!
            //Clipboard.SetText(labelResult.Text);//Clipboard.SetText(value);
            operation_pressed = false;
            operation = "";
        }

        private void bNumeric_Click(object sender, EventArgs e)
        {
            //if (labelResult.Text == "0")
            //result.Clear();

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
                
            //if (labelResult.Text != "0")
            //{
            //    labelResult.Text = "*"; // ((Button)sender).Text.ToString();
            //}

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

        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
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
                case "\b":
                    butCE.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
