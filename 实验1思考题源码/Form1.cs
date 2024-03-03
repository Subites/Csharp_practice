namespace extension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("你确定要退出吗？", "请确认...",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 在按钮点击事件中创建 Form2 实例
            Form2 form2 = new Form2();

            // 显示 Form2 窗口
            form2.Show();

            // 隐藏当前窗口（Form1）
            this.Hide();
        }
    }
}
