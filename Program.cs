using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Form form = new Form();
        form.Text = "Hello!";
        Application.Run(form);
    }
}