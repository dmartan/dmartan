using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmeri
{
    public partial class Farmer : Form
    {
        public class Goveda
        {
            public string boja;
            public string spol;

            public Goveda(string boja, string spol)
            {
                this.spol = spol;
                this.boja = boja;
            }
        }

        List<Goveda> listaGoveda = new List<Goveda>();

        public Farmer()
        {
            InitializeComponent();
        }

        private void gumbDodaj_Click(object sender, EventArgs e)
        {
            string spolUnos = spolTextbox.Text;
            string bojaUnos = bojaTextbox.Text;

            listaGoveda.Add(new Goveda(bojaUnos, spolUnos));
            spolTextbox.Text = "";
            bojaTextbox.Text = "";
        }

        private void gumbFiltarBoja_Click(object sender, EventArgs e)
        {
            filtarBojaIspis.Text = "";

            foreach(Goveda govedo in listaGoveda)
            {
                if (filtarBojeTextbox.Text == govedo.boja)
                {
                    filtarBojaIspis.Text = filtarBojaIspis.Text + govedo.boja + " " + govedo.spol + " | ";
                }
            }
        }

        private void gumbFiltarSpola_Click(object sender, EventArgs e)
        {
            ispisFiltarSpola.Text = "";

            foreach (Goveda govedo in listaGoveda)
            {
                if (filtarSpolTextbox.Text == govedo.spol)
                {
                    ispisFiltarSpola.Text = ispisFiltarSpola.Text + govedo.boja + " " + govedo.spol + " | ";
                }
            }
        }

        private void gumbSortiraj_Click(object sender, EventArgs e)
        {
            foreach(Goveda govedo in listaGoveda)
            {
                if (govedo.spol == "m")
                {
                    ispisSortirano.Text += govedo.boja + " " + govedo.spol + " | ";
                }
            }

            foreach (Goveda govedo in listaGoveda)
            {
                if (govedo.spol == "z")
                {
                    ispisSortirano.Text += govedo.boja + " " + govedo.spol + " | ";
                }
            }


            //List<Goveda> sortiranaListaGoveda = listaGoveda.Sort();

        }
    }
}
