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
            if(MessageBox.Show("��ȷ��Ҫ�˳���", "��ȷ��...",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �ڰ�ť����¼��д��� Form2 ʵ��
            Form2 form2 = new Form2();

            // ��ʾ Form2 ����
            form2.Show();

            // ���ص�ǰ���ڣ�Form1��
            this.Hide();
        }
    }
}
