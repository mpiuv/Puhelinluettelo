namespace Puhelinluettelo
{
  partial class Numerotietue
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_sukunimi = new System.Windows.Forms.TextBox();
      this.txt_etunimi = new System.Windows.Forms.TextBox();
      this.button_lisaa = new System.Windows.Forms.Button();
      this.button_hae = new System.Windows.Forms.Button();
      this.button_poista = new System.Windows.Forms.Button();
      this.button_paivita = new System.Windows.Forms.Button();
      this.lbl_phonenumber = new System.Windows.Forms.Label();
      this.txt_puhelinnumero = new System.Windows.Forms.TextBox();
      this.column_etunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.column_sukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.column_puhelinnumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listviewdatabase = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Sukunimi:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(29, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Etunimi:";
      // 
      // txt_sukunimi
      // 
      this.txt_sukunimi.Location = new System.Drawing.Point(171, 99);
      this.txt_sukunimi.Name = "txt_sukunimi";
      this.txt_sukunimi.Size = new System.Drawing.Size(100, 20);
      this.txt_sukunimi.TabIndex = 2;
      // 
      // txt_etunimi
      // 
      this.txt_etunimi.Location = new System.Drawing.Point(171, 65);
      this.txt_etunimi.Name = "txt_etunimi";
      this.txt_etunimi.Size = new System.Drawing.Size(100, 20);
      this.txt_etunimi.TabIndex = 1;
      // 
      // button_lisaa
      // 
      this.button_lisaa.Location = new System.Drawing.Point(147, 202);
      this.button_lisaa.Name = "button_lisaa";
      this.button_lisaa.Size = new System.Drawing.Size(75, 23);
      this.button_lisaa.TabIndex = 5;
      this.button_lisaa.Text = "Lisää";
      this.button_lisaa.UseVisualStyleBackColor = true;
      this.button_lisaa.Click += new System.EventHandler(this.button_save_Click);
      // 
      // button_hae
      // 
      this.button_hae.Location = new System.Drawing.Point(32, 202);
      this.button_hae.Name = "button_hae";
      this.button_hae.Size = new System.Drawing.Size(75, 23);
      this.button_hae.TabIndex = 4;
      this.button_hae.Text = "Hae";
      this.button_hae.UseVisualStyleBackColor = true;
      this.button_hae.Click += new System.EventHandler(this.button_display_Click);
      // 
      // button_poista
      // 
      this.button_poista.Location = new System.Drawing.Point(388, 202);
      this.button_poista.Name = "button_poista";
      this.button_poista.Size = new System.Drawing.Size(75, 23);
      this.button_poista.TabIndex = 7;
      this.button_poista.Text = "Poista";
      this.button_poista.UseVisualStyleBackColor = true;
      this.button_poista.Click += new System.EventHandler(this.button_delete_Click);
      // 
      // button_paivita
      // 
      this.button_paivita.Location = new System.Drawing.Point(265, 202);
      this.button_paivita.Name = "button_paivita";
      this.button_paivita.Size = new System.Drawing.Size(75, 23);
      this.button_paivita.TabIndex = 6;
      this.button_paivita.Text = "Muokkaa";
      this.button_paivita.UseVisualStyleBackColor = true;
      this.button_paivita.Click += new System.EventHandler(this.button_update_Click);
      // 
      // lbl_phonenumber
      // 
      this.lbl_phonenumber.AutoSize = true;
      this.lbl_phonenumber.Location = new System.Drawing.Point(29, 138);
      this.lbl_phonenumber.Name = "lbl_phonenumber";
      this.lbl_phonenumber.Size = new System.Drawing.Size(80, 13);
      this.lbl_phonenumber.TabIndex = 12;
      this.lbl_phonenumber.Text = "Puhelinnumero:";
      // 
      // txt_puhelinnumero
      // 
      this.txt_puhelinnumero.Location = new System.Drawing.Point(171, 135);
      this.txt_puhelinnumero.Name = "txt_puhelinnumero";
      this.txt_puhelinnumero.Size = new System.Drawing.Size(100, 20);
      this.txt_puhelinnumero.TabIndex = 3;
      // 
      // column_etunimi
      // 
      this.column_etunimi.Text = "Etunimi";
      this.column_etunimi.Width = 68;
      // 
      // column_sukunimi
      // 
      this.column_sukunimi.Text = "Sukunimi";
      this.column_sukunimi.Width = 93;
      // 
      // column_puhelinnumero
      // 
      this.column_puhelinnumero.Text = "Puhelinnumero";
      this.column_puhelinnumero.Width = 114;
      // 
      // listviewdatabase
      // 
      this.listviewdatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_etunimi,
            this.column_sukunimi,
            this.column_puhelinnumero});
      this.listviewdatabase.Location = new System.Drawing.Point(23, 284);
      this.listviewdatabase.Name = "listviewdatabase";
      this.listviewdatabase.Size = new System.Drawing.Size(431, 125);
      this.listviewdatabase.TabIndex = 0;
      this.listviewdatabase.UseCompatibleStateImageBehavior = false;
      this.listviewdatabase.View = System.Windows.Forms.View.Details;
      this.listviewdatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewdatabase_MouseClick);
      // 
      // Numerotietue
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(478, 421);
      this.Controls.Add(this.txt_puhelinnumero);
      this.Controls.Add(this.lbl_phonenumber);
      this.Controls.Add(this.button_paivita);
      this.Controls.Add(this.button_poista);
      this.Controls.Add(this.button_hae);
      this.Controls.Add(this.button_lisaa);
      this.Controls.Add(this.txt_etunimi);
      this.Controls.Add(this.txt_sukunimi);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listviewdatabase);
      this.Name = "Numerotietue";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_sukunimi;
    private System.Windows.Forms.TextBox txt_etunimi;
    private System.Windows.Forms.Button button_lisaa;
    private System.Windows.Forms.Button button_hae;
    private System.Windows.Forms.Button button_poista;
    private System.Windows.Forms.Button button_paivita;
    private System.Windows.Forms.Label lbl_phonenumber;
    private System.Windows.Forms.TextBox txt_puhelinnumero;
    private System.Windows.Forms.ColumnHeader column_etunimi;
    private System.Windows.Forms.ColumnHeader column_sukunimi;
    private System.Windows.Forms.ColumnHeader column_puhelinnumero;
    private System.Windows.Forms.ListView listviewdatabase;
  }
}

