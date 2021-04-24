using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculMoyenne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void etatCalculer()
        {
            if ((txt_NomPrenom.Text != "") && (txt_NoteDS.Text != "") && (txt_NoteExamen.Text != "") && (txt_NoteNP.Text != ""))
            {
                btn_Calculer.Enabled = true;
            } else
            {
                btn_Calculer.Enabled = false;
            }
        }

        public void clear()
        {
            txt_NomPrenom.Clear();
            txt_NoteDS.Clear();
            txt_NoteExamen.Clear();
            txt_NoteNP.Clear();
            txt_Moyenne.Clear();
        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            Etudiant p = new Etudiant();
            p.Initialise(txt_NomPrenom.Text, int.Parse(txt_NoteDS.Text), int.Parse(txt_NoteExamen.Text), int.Parse(txt_NoteNP.Text));
            txt_Moyenne.Text = p.Moyenne().ToString();
        }

        private void txt_NomPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_NoteDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void txt_NoteExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_NoteNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_NoteDS_TextChanged(object sender, EventArgs e)
        {
            etatCalculer();
        }

        private void txt_NoteExamen_TextChanged(object sender, EventArgs e)
        {
            etatCalculer();
        }

        private void txt_NoteNP_TextChanged(object sender, EventArgs e)
        {
            etatCalculer();
        }

        private void txt_Moyenne_TextChanged(object sender, EventArgs e)
        {
            if (txt_Moyenne.Text != "")
            {
                btn_Calculer.Enabled = false;
                btn_Ajouter.Enabled = true;
            } else
            {
                btn_Ajouter.Enabled = false;
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Etudiant p = new Etudiant();
            p.Initialise(txt_NomPrenom.Text, int.Parse(txt_NoteDS.Text), int.Parse(txt_NoteExamen.Text), int.Parse(txt_NoteNP.Text));
            lst_Moyenne.Items.Add(p.Afficher());
            clear();
        }

        private void txt_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            etatCalculer();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Remove(lst_Moyenne.SelectedItem);
        }

        private void lst_Moyenne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Moyenne.SelectedIndex != -1)
            {
                btn_Supprimer.Enabled = true;
            } else
            {
                btn_Supprimer.Enabled = false;
            }
        }
    }
}
