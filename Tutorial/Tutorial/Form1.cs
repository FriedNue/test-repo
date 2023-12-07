using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Form1 : Form
    {
        struct Tutorial_ImageDB
        {
            public Image Tutorial_Image;
        }
        Tutorial_ImageDB[] ImageDB = new Tutorial_ImageDB[8]; // 이미지 수대로 임의수정

        public void Tuto_Iamge()
        {
            ImageDB[0].Tutorial_Image = Properties.Resources.TTI1;
            ImageDB[1].Tutorial_Image = Properties.Resources.TTI2;
            ImageDB[2].Tutorial_Image = Properties.Resources.TTI3;
            ImageDB[3].Tutorial_Image = Properties.Resources.TTI4;
            ImageDB[4].Tutorial_Image = Properties.Resources.TTI5;
            ImageDB[5].Tutorial_Image = Properties.Resources.TTI6;
            ImageDB[6].Tutorial_Image = Properties.Resources.TTI7;
            ImageDB[7].Tutorial_Image = Properties.Resources.TTI8;

        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
