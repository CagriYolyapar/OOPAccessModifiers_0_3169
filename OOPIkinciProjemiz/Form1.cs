﻿using OOPAccessModifiers_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPIkinciProjemiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            Egitmen egt = new Egitmen();
            egt.Isim = "Cagri"; //Isim property'sini public yapmadıgımız zaman internal veya private yaptıgımız zaman buradan erişemeyecegimizi gözlemleyeceksiniz...
          
        }
    }
}
