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
	Panel panel = new Panel(); // Panel
	Label label1 = new Label(); // ラベルコントロール
	Label label2 = new Label();
	Button[] button = new Button[3];
	public Form1()
	{
		panel.BorderStyle = BorderStyle.FixedSingle; // 境界線
		panel.Size = new Size(200, 200);
		panel.Location = new Point(20, 20);

		for (int i = 0; i < 3; i++) {
			button[i] = new Button();
			button[i].Text = "ボタン" + i;
			button[i].Top = i * 40;
			panel.Controls.Add(button[i]); // buttonをPanelに追加
		}
		button[0].Click += new EventHandler(clickAction);
		this.Controls.Add(panel); // Panelをフォームに追加
	}
	void clickAction(object sender, EventArgs e) {
		MessageBox.Show("ボタンが押されました." + sender.GetType(), "clickAction" );
	}
}