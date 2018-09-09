using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Puhelinluettelo
{
  public partial class Numerotietue : Form
  {

    private static class Tietokanta
    {
      /* Bugi: Data sourcen nimi voi vaihdella */
      private static SqlConnection connect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=puhelinluettelo;Integrated Security=True; MultipleActiveResultSets=True");

      static public void talleta()
      {
        try
        {
          connect.Open();
          using (SqlCommand db_saver = new SqlCommand("INSERT INTO puhelinluettelo (etunimi,sukunimi,puhelinnumero) values (@etunimi,@sukunimi,@puhelinnumero)", connect))
          {
            db_saver.Parameters.AddWithValue("@etunimi", Program.nrotietue.txt_etunimi.Text);
            db_saver.Parameters.AddWithValue("@sukunimi", Program.nrotietue.txt_sukunimi.Text);
            db_saver.Parameters.AddWithValue("@puhelinnumero", Program.nrotietue.txt_puhelinnumero.Text);
            db_saver.ExecuteNonQuery();
          }
          connect.Close();
        }
        catch (SqlException ex)
        {
          MessageBox.Show("Tietueen lisäys epäonnistui:" + ex.Message);
        }
      }

      static public void nayta()
      {
        Program.nrotietue.listviewdatabase.Items.Clear();
        try
        {
          connect.Open();
          using (SqlCommand db_displayer = new SqlCommand("SELECT * FROM puhelinluettelo", connect))
          {
            SqlDataReader reader = db_displayer.ExecuteReader();
            var items = new List<ListViewItem>();
            while (reader.Read())
            {
              ListViewItem adder = new ListViewItem(reader["etunimi"].ToString());
              adder.SubItems.Add(reader["sukunimi"].ToString());
              adder.SubItems.Add(reader["puhelinnumero"].ToString());
              items.Add(adder);
            }
            Program.nrotietue.listviewdatabase.Items.AddRange(items.ToArray());
          }
          connect.Close();
        }
        catch (SqlException ex)
        {
          MessageBox.Show("Virhe tietuetta näytettäessä: " + ex.Message);
        }
      }

      static public void paivita()
      {
        String query =
          "UPDATE puhelinluettelo SET etunimi=@etunimi, sukunimi=@sukunimi, puhelinnumero=@puhelinnumero WHERE etunimi=@etunimi AND sukunimi=@sukunimi";
        try
        {
          connect.Open();
          using (SqlCommand db_updater = new SqlCommand(query, connect))
          {
            db_updater.Parameters.Clear();
            db_updater.Parameters.AddWithValue("@etunimi", Program.nrotietue.txt_etunimi.Text);
            db_updater.Parameters.AddWithValue("@sukunimi", Program.nrotietue.txt_sukunimi.Text);
            db_updater.Parameters.AddWithValue("@puhelinnumero", Program.nrotietue.txt_puhelinnumero.Text);
            db_updater.ExecuteNonQuery();
          }
          connect.Close();
        }
        catch (SqlException ex)
        {
          MessageBox.Show("Virhe tietuetta päivitettäessä: " + ex.Message);
        }
      }

      static public void poista()
      {
        try
        {
          connect.Open();
          using (SqlCommand eraser = new SqlCommand(
              "DELETE FROM puhelinluettelo WHERE etunimi=@etunimi and sukunimi=@sukunimi and puhelinnumero=@puhelinnumero", connect))
          {
            eraser.Parameters.AddWithValue("@etunimi", Program.nrotietue.txt_etunimi.Text);
            eraser.Parameters.AddWithValue("@sukunimi", Program.nrotietue.txt_sukunimi.Text);
            eraser.Parameters.AddWithValue("@puhelinnumero", Program.nrotietue.txt_puhelinnumero.Text);
            eraser.ExecuteNonQuery();

          }
          connect.Close();
        }
        catch (SqlException ex)
        {
          MessageBox.Show("Tietueen poisto epäonnistui: " + ex.Message);
        }
      }
    }  /* Tietokanta - sisäisen luokan loppu*/
    
    public Numerotietue()
    {
      InitializeComponent();
    }
    
    private void button_display_Click(object sender, EventArgs e)
    {
      Tietokanta.nayta();
    }

    private void button_save_Click(object sender, EventArgs e)
    {
      Tietokanta.talleta();
      listviewdatabase.Items.Clear();
      txt_etunimi.Text = "";
      txt_sukunimi.Text = "";
      txt_puhelinnumero.Text = "";
      Tietokanta.nayta();
    }

    private void listviewdatabase_MouseClick(object sender, MouseEventArgs e)
    {
      txt_etunimi.Text = listviewdatabase.SelectedItems[0].SubItems[1].Text;
      txt_sukunimi.Text = listviewdatabase.SelectedItems[0].SubItems[2].Text;
      txt_puhelinnumero.Text = listviewdatabase.SelectedItems[0].SubItems[3].Text;
    }

    private void button_update_Click(object sender, EventArgs e)
    {
      Tietokanta.paivita();
      listviewdatabase.Items.Clear();
      txt_etunimi.Text = "";
      txt_sukunimi.Text = "";
      txt_puhelinnumero.Text = "";
      Tietokanta.nayta();
    }

    private void button_delete_Click(object sender, EventArgs e)
    {
      Tietokanta.poista();
      listviewdatabase.Items.Clear();
      txt_etunimi.Text = "";
      txt_sukunimi.Text = "";
      txt_puhelinnumero.Text = "";
      Tietokanta.nayta();
    }
  }
}
