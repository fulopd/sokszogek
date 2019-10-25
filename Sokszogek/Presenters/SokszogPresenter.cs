using Sokszogek.Models;
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
        private IHaromszog haromszogView;
        private string sokszogNev { get; set; }
        public bool oldalCLetezik { get; set; }

        public SokszogPresenter(ISokszogView sokszogv, IHaromszog haromszogV)
        {
            sokszogView = sokszogv;
            haromszogView = haromszogV;
            sokszogRepositori = new SokszogRepositori();
        }

        public void LoadData() {
            sokszogView.SokszogLista = sokszogRepositori.GetSokszogek();
        }

        public void ShowOldal(int index) {
            sokszogNev = sokszogRepositori.GetNameByIndex(index);
            switch (sokszogNev)
            {
                case "Háromszög":
                    oldalCLetezik = true;
                    break;
                default:
                    oldalCLetezik = false;
                    break;
            }
        }

        public void Calculate()
        {

            if (string.IsNullOrWhiteSpace(sokszogView.oldalA) || string.IsNullOrWhiteSpace(sokszogView.oldalB))
            {
                return;
            }

            switch (sokszogNev)
            {
                case "Téglalap":
                    var teglalap = new Teglalap(
                        Convert.ToDouble(sokszogView.oldalA), 
                        Convert.ToDouble(sokszogView.oldalB));
                    sokszogView.Kerulet = teglalap.Kerulet().ToString();
                    sokszogView.Terulet = teglalap.Terulet().ToString();
                    break;
                case "Háromszög":
                    var haromszog = new Haromszog(
                        Convert.ToDouble(sokszogView.oldalA), 
                        Convert.ToDouble(sokszogView.oldalB), 
                        Convert.ToDouble(haromszogView.oldalC));
                    sokszogView.Kerulet = haromszog.Kerulet().ToString();
                    sokszogView.Terulet = haromszog.Terulet().ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
