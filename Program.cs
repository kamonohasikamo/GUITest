using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
	[STAThread]
	static void Main()
	{
		Application.EnableVisualStyles(); // ビジュアルスタイルを有効化
		Application.Run(new Form1());
	}
}

class Form1 : Form
{
	Button button = new Button(); // ボタンコントロール

	public Form1()
	{
		button.Text = "OK";
		button.Location = new Point(10, 10);
		button.Size = new Size(120, 40);

		this.Controls.Add(button); // コントロールをフォームに貼り付け
	}
}