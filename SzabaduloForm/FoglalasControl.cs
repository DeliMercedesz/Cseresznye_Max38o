using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzabaduloForm.Mappa;

namespace SzabaduloForm
{
    public partial class FoglalasControl : UserControl
    {
        context_Szabaduloszoba _context = new context_Szabaduloszoba();
        public FoglalasControl()
        {
            InitializeComponent();
            LoadSzobak();
            LoadJatekosok();
            LoadFoglalas();
        }

        //Szobák betöltése
        public void LoadSzobak()
        {
            var SzobaLista = (from sz in _context.Szobaks
                              where sz.Nev.Contains(SzobaTxt.Text)
                              select sz).ToList();

            szobakBindingSource.DataSource = SzobaLista;
        }

        private void SzobaTxt_TextChanged(object sender, EventArgs e)
        {
            LoadSzobak();
        }


        //Jatekosok betöltése

        public void LoadJatekosok()
        {
            var JatekosLista = (from j in _context.Jatekosoks
                                select j).ToList();

            jatekosokBindingSource.DataSource = JatekosLista;
        }


        //Foglalás betöltés

        private void LoadFoglalas()
        {
            var kivalasztottszoba = (Szobak)SzobaLb.SelectedItem;

            if (kivalasztottszoba == null)
            {
                MessageBox.Show("Nincs kiválasztott szoba");
                return;
            }

            var foglalasok = (from x in _context.Foglalasoks
                              where x.SzobaId == kivalasztottszoba.SzobaId
                              select new megjelenitdto
                              {
                                  FoglalasId = x.FoglalasId,
                                  Szoba = x.SzobaId,
                                  Időpont = x.Idopont,
                                  Állapot = x.Allapot,
                                  Játékos = x.JatekosId


                              }).ToList();

            megjelenitdtoBindingSource.DataSource = foglalasok;

        }

        private void SzobaLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoglalas();
        }

        private void TorlesButton_Click(object sender, EventArgs e)
        {
            var törlendő = SzobaLb.SelectedItem as Szobak;

            var törlendők = (from x in _context.Szobaks
                             where x.SzobaId == törlendő!.SzobaId
                             select x).FirstOrDefault();

            if (MessageBox.Show("Biztos törölni szeretnéd a szobát?", "Szoba törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Szobaks.Remove(törlendők);
                _context.SaveChanges();
                LoadSzobak();
            }
        }
    }


    public class megjelenitdto
    {
        public int FoglalasId { get; set; }

        public int Szoba { get; set; }

        public DateTime? Időpont { get; set; }

        public string? Állapot { get; set; }

        public int Játékos { get; set; }


    }
}
