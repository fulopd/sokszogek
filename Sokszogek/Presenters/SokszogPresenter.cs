using Sokszogek.Repositories;
using Sokszogek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Presenters
{
    public class SokszogPresenter
    {
        private ISokszogView sokszogView;
        private ISokszogRepositori sokszogRepositori;

        public SokszogPresenter(ISokszogView sokszogv)
        {
            sokszogView = sokszogv;
            sokszogRepositori = new SokszogRepositori();
        }

        public void LoadData() {
            sokszogView.SokszogLista = sokszogRepositori.GetSokszogek();
        }

    }
}
