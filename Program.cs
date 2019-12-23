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
	int clickCount = 0; // クリック回数のカウント
	Panel panel = new Panel(); // Panel
	Label label1 = new Label(); // ラベルコントロール
	Label label2 = new Label();
	Button button;
	public Form1()
	{
		panel.BorderStyle = BorderStyle.FixedSingle; // 境界線
		panel.Size = new Size(200, 200);
		panel.Location = new Point(20, 20);
		button = new Button()
		{
			Text = "ボタン をクリックしてください。",
			Location = new Point(10, 10),
			Size = new Size(160, 40),
		};
		button.Click += new EventHandler(clickAction);
		panel.Controls.Add(button); // buttonをPanelに追加
		this.Controls.Add(panel); // Panelをフォームに追加

		this.FormClosing += new FormClosingEventHandler(closingAction);
	}
	
	void clickAction(object sender, EventArgs e)
	{
		clickCount++;
		button.Text = clickCount + " 回クリックされました";
	}

	void closingAction(Object sender, FormClosingEventArgs e)
	{
		DialogResult result = MessageBox.Show(
			"終了しますか？", 
			"確認",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		);
		if (result == DialogResult.No)
		{
			e.Cancel = true;
		}
	}
}