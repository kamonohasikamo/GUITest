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
	Label label;
	Button button;
	public Form1()
	{
		button = new Button()
		{
			Text = "ボタン をクリックしてください。",
			Location = new Point(10, 10),
			Size = new Size(160, 40),
		};
		button.Click += new EventHandler(clickAction);
		this.ClientSize = new Size(500, 500);
		this.Controls.Add(button); // Panelをフォームに追加

		this.FormClosing += new FormClosingEventHandler(closingAction);
		label = new Label() {
			AutoSize = true
		};
		this.Controls.Add(label);
		this.MouseMove += new MouseEventHandler(mouseMoving);
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
	void mouseMoving(Object sender, MouseEventArgs e)
	{
		// マウスと同じ位置
		label.Location = e.Location;
		// ラベルにx,y座標を表示
		label.Text = string.Format("({0}, {1})", e.X, e.Y);
	}
}