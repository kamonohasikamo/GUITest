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
	Label label1 = new Label(); // ラベルコントロール
	Label label2 = new Label();
	Button button1 = new Button(); // ボタンコントロール
	Button button2 = new Button(); // ボタンコントロール

	public Form1()
	{
		label1.Text = "label1";
		label1.Location = new Point(10, 10);
		label1.AutoSize = true;

		label2.Text = "label2";
		label2.Location = new Point(10, 30);
		label2.AutoSize = true;

		button1.Text = "button1";
		button1.Location = new Point(10, 50);

		button2.Text = "button2";
		button2.Location = new Point(10, 80);

		// コントロール群を配列にまとめて追加
		this.Controls.AddRange(new Control[] {
			label1, label2, button1, button2
		});
		/*
			or
			this.Controls.Add(label1);
			this.Controls.Add(label2);
			this.Controls.Add(button1);
			this.Controls.Add(button2);
		*/
	}
}