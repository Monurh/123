using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var carBuilder = new CarBuilder();

            if (radioButton1.Checked) 
            {
                carBuilder.SetColor("black");
                MessageBox.Show("Колір авто чорний");
            }
            if (radioButton2.Checked)
            {
                carBuilder.SetColor("white");
                MessageBox.Show("Колір авто білий");
            }

            if(radioButton4.Checked)
            {
                carBuilder.SetEngine("V6");
                MessageBox.Show("Двигун V6");
            }
            if (radioButton5.Checked) 
            {
                carBuilder.SetEngine("V8");
                MessageBox.Show("Двигун V8");
            }
            int numWheels = 4;
            if (radioButton6.Checked)
            {
                carBuilder.SetNumWheels(numWheels);
                MessageBox.Show("У авто шосейні колеса ");
            }
            if (radioButton7.Checked)
            {
                carBuilder.SetNumWheels(numWheels++);
                MessageBox.Show("У авто грязові колеса ");
            }
            if (radioButton8.Checked)
            {
                carBuilder.SetNumWheels(numWheels--);
                MessageBox.Show("У авто спортивні колеса ");
            }


            var car = carBuilder.GetCar();
            var carImage = GetCarImage(car);
        }


        private Image GetCarImage(Car car)
        {
            if (car.Color == "black")
            {
                return pictureBox1.Image = Resource1.blackcar;
            }
            else
            {
                return pictureBox1.Image = Resource1.whitecar;
            }
        }
    }     
}
