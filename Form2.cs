using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistical_reports
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            chart1.Titles.Add("Report 2");
            chart1.Series["s1"].Points.AddXY("(Otro)", "35");
            chart1.Series["s1"].Points.AddXY("Antioquia", "11");
            chart1.Series["s1"].Points.AddXY("Boyaca", "10");
            chart1.Series["s1"].Points.AddXY("Cundinamarca", "10");
            chart1.Series["s1"].Points.AddXY("Santander", "7");
            chart1.Series["s1"].Points.AddXY("Nariño", "5");
            chart1.Series["s1"].Points.AddXY("Tolima", "4");
            chart1.Series["s1"].Points.AddXY("Bolivar", "4");
            chart1.Series["s1"].Points.AddXY("Cauca", "3");
            chart1.Series["s1"].Points.AddXY("Valle del Cauca", "3");
            chart1.Series["s1"].Points.AddXY("Norte de Santander", "3");
            chart1.Series["s1"].Points.AddXY("Huila", "3");
            chart1.Series["s1"].Points.AddXY("Choco", "2");

        }

    }
}
