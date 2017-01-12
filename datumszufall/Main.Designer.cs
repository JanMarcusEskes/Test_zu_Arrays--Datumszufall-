namespace datumszufall
{
  partial class Zufallsdatum
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnTagErz = new System.Windows.Forms.Button();
      this.btnMonatErz = new System.Windows.Forms.Button();
      this.txtZahlWochentag = new System.Windows.Forms.TextBox();
      this.txtZahlMonat = new System.Windows.Forms.TextBox();
      this.txtAusgabeTag = new System.Windows.Forms.TextBox();
      this.txtAusgabeMonat = new System.Windows.Forms.TextBox();
      this.btnTagAusgeben = new System.Windows.Forms.Button();
      this.btnMonatAusgeben = new System.Windows.Forms.Button();
      this.btnDurchschnitt = new System.Windows.Forms.Button();
      this.txtDurchschnitt = new System.Windows.Forms.TextBox();
      this.txtZahlDatumTag = new System.Windows.Forms.TextBox();
      this.btnTagAlsDatum = new System.Windows.Forms.Button();
      this.btnAusgabeDatum = new System.Windows.Forms.Button();
      this.txtAusgabeGesamt = new System.Windows.Forms.TextBox();
      this.lblAnzahlTage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnTagErz
      // 
      this.btnTagErz.Location = new System.Drawing.Point(40, 29);
      this.btnTagErz.Name = "btnTagErz";
      this.btnTagErz.Size = new System.Drawing.Size(119, 23);
      this.btnTagErz.TabIndex = 0;
      this.btnTagErz.Text = "Wochentag erzeugen";
      this.btnTagErz.UseVisualStyleBackColor = true;
      this.btnTagErz.Click += new System.EventHandler(this.btnTagErz_Click);
      // 
      // btnMonatErz
      // 
      this.btnMonatErz.Location = new System.Drawing.Point(40, 95);
      this.btnMonatErz.Name = "btnMonatErz";
      this.btnMonatErz.Size = new System.Drawing.Size(119, 23);
      this.btnMonatErz.TabIndex = 1;
      this.btnMonatErz.Text = "Monat erzeugen";
      this.btnMonatErz.UseVisualStyleBackColor = true;
      this.btnMonatErz.Click += new System.EventHandler(this.btnMonatErz_Click);
      // 
      // txtZahlWochentag
      // 
      this.txtZahlWochentag.Location = new System.Drawing.Point(165, 32);
      this.txtZahlWochentag.Name = "txtZahlWochentag";
      this.txtZahlWochentag.Size = new System.Drawing.Size(32, 20);
      this.txtZahlWochentag.TabIndex = 2;
      // 
      // txtZahlMonat
      // 
      this.txtZahlMonat.Location = new System.Drawing.Point(165, 98);
      this.txtZahlMonat.Name = "txtZahlMonat";
      this.txtZahlMonat.Size = new System.Drawing.Size(32, 20);
      this.txtZahlMonat.TabIndex = 3;
      // 
      // txtAusgabeTag
      // 
      this.txtAusgabeTag.Location = new System.Drawing.Point(252, 32);
      this.txtAusgabeTag.Name = "txtAusgabeTag";
      this.txtAusgabeTag.Size = new System.Drawing.Size(100, 20);
      this.txtAusgabeTag.TabIndex = 4;
      // 
      // txtAusgabeMonat
      // 
      this.txtAusgabeMonat.Location = new System.Drawing.Point(252, 98);
      this.txtAusgabeMonat.Name = "txtAusgabeMonat";
      this.txtAusgabeMonat.Size = new System.Drawing.Size(100, 20);
      this.txtAusgabeMonat.TabIndex = 5;
      // 
      // btnTagAusgeben
      // 
      this.btnTagAusgeben.Location = new System.Drawing.Point(203, 32);
      this.btnTagAusgeben.Name = "btnTagAusgeben";
      this.btnTagAusgeben.Size = new System.Drawing.Size(43, 20);
      this.btnTagAusgeben.TabIndex = 6;
      this.btnTagAusgeben.Text = " --> ";
      this.btnTagAusgeben.UseVisualStyleBackColor = true;
      this.btnTagAusgeben.Click += new System.EventHandler(this.btnTagAusgeben_Click);
      // 
      // btnMonatAusgeben
      // 
      this.btnMonatAusgeben.Location = new System.Drawing.Point(203, 97);
      this.btnMonatAusgeben.Name = "btnMonatAusgeben";
      this.btnMonatAusgeben.Size = new System.Drawing.Size(43, 21);
      this.btnMonatAusgeben.TabIndex = 7;
      this.btnMonatAusgeben.Text = " --> ";
      this.btnMonatAusgeben.UseVisualStyleBackColor = true;
      this.btnMonatAusgeben.Click += new System.EventHandler(this.btnMonatAusgeben_Click);
      // 
      // btnDurchschnitt
      // 
      this.btnDurchschnitt.Location = new System.Drawing.Point(203, 62);
      this.btnDurchschnitt.Name = "btnDurchschnitt";
      this.btnDurchschnitt.Size = new System.Drawing.Size(75, 23);
      this.btnDurchschnitt.TabIndex = 8;
      this.btnDurchschnitt.Text = "Minimum";
      this.btnDurchschnitt.UseVisualStyleBackColor = true;
      this.btnDurchschnitt.Click += new System.EventHandler(this.btnDurchschnitt_Click);
      // 
      // txtDurchschnitt
      // 
      this.txtDurchschnitt.Location = new System.Drawing.Point(284, 64);
      this.txtDurchschnitt.Name = "txtDurchschnitt";
      this.txtDurchschnitt.Size = new System.Drawing.Size(43, 20);
      this.txtDurchschnitt.TabIndex = 9;
      // 
      // txtZahlDatumTag
      // 
      this.txtZahlDatumTag.Location = new System.Drawing.Point(165, 65);
      this.txtZahlDatumTag.Name = "txtZahlDatumTag";
      this.txtZahlDatumTag.Size = new System.Drawing.Size(32, 20);
      this.txtZahlDatumTag.TabIndex = 11;
      // 
      // btnTagAlsDatum
      // 
      this.btnTagAlsDatum.Location = new System.Drawing.Point(40, 62);
      this.btnTagAlsDatum.Name = "btnTagAlsDatum";
      this.btnTagAlsDatum.Size = new System.Drawing.Size(119, 23);
      this.btnTagAlsDatum.TabIndex = 10;
      this.btnTagAlsDatum.Text = "Tag Datum erzeugen";
      this.btnTagAlsDatum.UseVisualStyleBackColor = true;
      this.btnTagAlsDatum.Click += new System.EventHandler(this.btnTagAlsDatum_Click);
      // 
      // btnAusgabeDatum
      // 
      this.btnAusgabeDatum.Location = new System.Drawing.Point(40, 134);
      this.btnAusgabeDatum.Name = "btnAusgabeDatum";
      this.btnAusgabeDatum.Size = new System.Drawing.Size(75, 23);
      this.btnAusgabeDatum.TabIndex = 12;
      this.btnAusgabeDatum.Text = "Ausgabe";
      this.btnAusgabeDatum.UseVisualStyleBackColor = true;
      this.btnAusgabeDatum.Click += new System.EventHandler(this.btnAusgabeDatum_Click);
      // 
      // txtAusgabeGesamt
      // 
      this.txtAusgabeGesamt.Location = new System.Drawing.Point(165, 136);
      this.txtAusgabeGesamt.Name = "txtAusgabeGesamt";
      this.txtAusgabeGesamt.Size = new System.Drawing.Size(187, 20);
      this.txtAusgabeGesamt.TabIndex = 13;
      // 
      // lblAnzahlTage
      // 
      this.lblAnzahlTage.AutoSize = true;
      this.lblAnzahlTage.Location = new System.Drawing.Point(333, 65);
      this.lblAnzahlTage.Name = "lblAnzahlTage";
      this.lblAnzahlTage.Size = new System.Drawing.Size(19, 13);
      this.lblAnzahlTage.TabIndex = 14;
      this.lblAnzahlTage.Text = "-0-";
      // 
      // Zufallsdatum
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 178);
      this.Controls.Add(this.lblAnzahlTage);
      this.Controls.Add(this.txtAusgabeGesamt);
      this.Controls.Add(this.btnAusgabeDatum);
      this.Controls.Add(this.txtZahlDatumTag);
      this.Controls.Add(this.btnTagAlsDatum);
      this.Controls.Add(this.txtDurchschnitt);
      this.Controls.Add(this.btnDurchschnitt);
      this.Controls.Add(this.btnMonatAusgeben);
      this.Controls.Add(this.btnTagAusgeben);
      this.Controls.Add(this.txtAusgabeMonat);
      this.Controls.Add(this.txtAusgabeTag);
      this.Controls.Add(this.txtZahlMonat);
      this.Controls.Add(this.txtZahlWochentag);
      this.Controls.Add(this.btnMonatErz);
      this.Controls.Add(this.btnTagErz);
      this.Name = "Zufallsdatum";
      this.Text = "Zufälliges Datum";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnTagErz;
    private System.Windows.Forms.Button btnMonatErz;
    private System.Windows.Forms.TextBox txtZahlWochentag;
    private System.Windows.Forms.TextBox txtZahlMonat;
    private System.Windows.Forms.TextBox txtAusgabeTag;
    private System.Windows.Forms.TextBox txtAusgabeMonat;
    private System.Windows.Forms.Button btnTagAusgeben;
    private System.Windows.Forms.Button btnMonatAusgeben;
    private System.Windows.Forms.Button btnDurchschnitt;
    private System.Windows.Forms.TextBox txtDurchschnitt;
    private System.Windows.Forms.TextBox txtZahlDatumTag;
    private System.Windows.Forms.Button btnTagAlsDatum;
    private System.Windows.Forms.Button btnAusgabeDatum;
    private System.Windows.Forms.TextBox txtAusgabeGesamt;
    private System.Windows.Forms.Label lblAnzahlTage;
  }
}

