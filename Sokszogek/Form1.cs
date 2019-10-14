using Sokszogek.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszogek
{
    public partial class Form1 : Form ,ISokszog
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public string oldalA {
            get => textBoxOldalA.Text;
            set => textBoxOldalA.Text = value; }

        public string oldalB {
            get => textBoxOldalB.Text;
            set => textBoxOldalB.Text = value; }

        public string Kerulet {
            get => textBoxKerulet.Text;
            set => textBoxKerulet.Text = value; }

        public string Terulet {
            get => textBoxTerulet.Text;
            set => textBoxTerulet.Text = value; }

        public IList<string> SokszogLista {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
    }
}
