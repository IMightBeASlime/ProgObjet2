using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_exercice3
{
    public partial class frmExercice3 : Form
    {
        IFraction _fraction;
        public frmExercice3()
        {
            InitializeComponent();
            _fraction = new Fraction("1/1");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = new Fraction(txtFraction1.Text);
            Fraction fraction2 = new Fraction(txtFraction2.Text);

            Fraction reponse = _fraction.Additionner(fraction1, fraction2);
            txtFractionReponse.Text = reponse.ToString();
        }

        private void btnSoustraire_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = new Fraction(txtFraction1.Text);
            Fraction fraction2 = new Fraction(txtFraction2.Text);

            Fraction reponse = _fraction.Soustraire(fraction1, fraction2);
            txtFractionReponse.Text = reponse.ToString();
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = new Fraction(txtFraction1.Text);
            Fraction fraction2 = new Fraction(txtFraction2.Text);

            Fraction reponse = _fraction.Multiplier(fraction1, fraction2);
            txtFractionReponse.Text = reponse.ToString();
        }
    }
}
