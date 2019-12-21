using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        //===============================
        // showメソッドについて
        // static DialogResult Show(
        // string text,                // メッセージ
        // string caption,             // タイトル
        // MessageBoxButtons buttons,  // ボタン
        // MessageBoxIcon icon         // アイコン
        // )
        //===============================
        /*
        DialogResult result = MessageBox.Show(
            "[はい] か [いいえ] を選択してください。", "確認",
            // ボタンの設定
            MessageBoxButtons.YesNo,
            // アイコンの設定
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            MessageBox.Show("[はい] が選択されました。", "結果");
        }
        else if (result == DialogResult.No)
        {
            MessageBox.Show("[いいえ] が選択されました。", "結果");
        }
        */
        Application.Run(new Form1());
    }
}

class Form1 : Form
{
    // コンストラクタ
    public Form1()
    {
        // this.Text = "Hello!";
        this.Text = "Title"; // ウィンドウタイトル設定
        /*
        bool ControlBox	コントロールボックスを表示
        bool MaximizeBox	最大化ボタンを表示
        bool MinimizeBox	最小化ボタンを表示
        bool TopMost	最前面に表示
        */
        this.MaximizeBox = false; // 最大化ボタンを無効
        /*
         Color BackColor	背景色
         Color ForeColor	前景色
        */
        this.BackColor = SystemColors.Window; // 背景色の設定
        // this.BackColor = Color.Blue;
    }
}