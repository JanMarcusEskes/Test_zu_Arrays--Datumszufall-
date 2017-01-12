using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace datumszufall
{
	public partial class Zufallsdatum : Form
	{
		ArrayList datumsTage = new ArrayList();
		int eingegebeneTage = 0;

		public Zufallsdatum()
		{
			InitializeComponent();
		}
		
		private void btnTagAusgeben_Click(object sender, EventArgs e)
		{
			String[] alleTage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };

			try
			{
				int derTag = Convert.ToInt16(txtZahlWochentag.Text);
				txtAusgabeTag.Text = alleTage[derTag].ToString();
			}
			catch (Exception error)
			{
				errorMsgBox(error, null);
			}
		}

		#region Zufallsbuttons

		private void btnTagAlsDatum_Click(object sender, EventArgs e)
		{
			int tag = randomizer(30);
			txtZahlDatumTag.Text = tag.ToString();
			datumsTage.Add(tag);
			lblAnzahlTage.Text = eingegebeneTage++.ToString();
		}

		private void btnTagErz_Click(object sender, EventArgs e)
		{
			int tag = randomizer(7);
			txtZahlWochentag.Text = tag.ToString();

		}

		private void btnMonatErz_Click(object sender, EventArgs e)
		{
			int monat = randomizer(12);
			txtZahlMonat.Text = monat.ToString();
		}

		private int randomizer(int max)
		{
			int seed = unchecked(DateTime.Now.Ticks.GetHashCode());
			Random r = new Random(seed);
			int random = r.Next(0, max);
			return random;
		}

		#endregion

		private void btnDurchschnitt_Click(object sender, EventArgs e)
		{
			int min = int.MaxValue;
			if (eingegebeneTage < 1)
			{
				errorMsgBox(null, "Es wurde noch kein Datum erzeugt!");
				return;
			}
			foreach (object tag in datumsTage)
			{
				if ((int)tag < min) min = (int)tag;
			}
			txtDurchschnitt.Text = min.ToString();
		}

		private void btnMonatAusgeben_Click(object sender, EventArgs e)
		{
			string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };

			try
			{

				int derMonat = int.Parse(txtZahlMonat.Text);
				txtAusgabeMonat.Text = monate[derMonat].ToString();
			}
			catch (Exception error)
			{
				errorMsgBox(error, null);
			}
		}

		private void btnAusgabeDatum_Click(object sender, EventArgs e)
		{
			string ausgabe;
			ausgabe = txtAusgabeTag.Text + ", der " + txtZahlDatumTag.Text + ". " + txtAusgabeMonat.Text + " " + DateTime.Now.Year.ToString();
			txtAusgabeGesamt.Text = ausgabe;
		}

		private void errorMsgBox(Exception error, string custromError)
		{

			StringWriter sw = new StringWriter();
			sw.WriteLine("Es ist ein Fehler aufgetreten!");
			if (custromError == null)
			{
				sw.WriteLine("Meldung: " + error.Message);
			}
			else
			{
				sw.WriteLine("Meldung: " + custromError);
			}
			MessageBox.Show(sw.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}
	}
}
