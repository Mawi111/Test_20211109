﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Ucet ucet1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ucet1 = new Ucet("Rastislav Zmařil", (float)0.00 200000);

        }
        /*public void ZobrazFormular(Ucet ucet) 
        {
            jmeno.Text = ucet.jmeno;
            stavk.Text = ucet.stavk;
        }*/
         
        private void Stavkonta(Ucet ucet)
        {
            //stavk.Text = ucet;
            
        }

        private void btnVlozit_Click(object sender, EventArgs e)
        {
            //var mnozstvi = mnozstvi.Mnozstvi(Convert.ToInt32(numVlozv.Value));
            //MessageBox.Show($"Vloženo {mnozstvi} kč");
        }

        private void btnVybrat_Click(object sender, EventArgs e)
        {
            //var mnozstvi = mnozstvi.Mnozstvi(Convert.ToInt32(numVlozv.Value));
            //MessageBox.Show($"Vloženo {mnozstvi} kč");


            // VOJTĚCH KOUKAL-IT-3-B    
        }
    }

}
