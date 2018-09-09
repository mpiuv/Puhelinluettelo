using System;
using System.Windows.Forms;

namespace Puhelinluettelo
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public static Numerotietue nrotietue;
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      nrotietue = new Numerotietue();  /* Konstruktoria ei saa kutsua ennen SetCompatibleTextRenderingDefault ia*/
      Application.Run(nrotietue);
    }
  }
}
