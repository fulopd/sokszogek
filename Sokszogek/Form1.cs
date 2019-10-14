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

        public string oldalA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string oldalB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Kerulet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Terulet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<string> SokszogLista { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
