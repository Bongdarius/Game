using Game_Service;
using System.Collections;

namespace Game
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {

            Service service = new Service();

            string uid = txtUserID.Text;
            string pwd = txtPwd.Text;

            if (uid == "" && pwd == "")
            {
                MessageBox.Show("���̵�� ��й�ȣ�� ��� �Է����ּ���.");
            }
            else if (uid == "")
            {
                MessageBox.Show("���̵� �Է����ּ���.");
            }
            else if (pwd == "")
            {
                MessageBox.Show("��й�ȣ�� �Է����ּ���.");
            }
            else
            {
                int result = service.login(uid, pwd);

                if (result == 1)
                {
                    this.Hide();
                    MessageBox.Show("�α��ο� �����߽��ϴ�.");
                    Main main = new Main();
                    main.ShowDialog();
                }
                else if (result == -1)
                {
                    MessageBox.Show("���̵� �߸� �Է��Ͽ����ϴ�.");
                }
                else if (result == -2)
                {
                    MessageBox.Show("��й�ȣ�� �߸� �Է��Ͽ����ϴ�.");
                }
                else if (result == -3)
                {
                    MessageBox.Show("���̵�� ��й�ȣ�� �ٽ� Ȯ�����ּ���.");
                }
                else
                {
                    MessageBox.Show("�α��ο� �����Ͽ����ϴ�..");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserID.Text = "admin";
            txtPwd.Text = "1234";

            login(sender, e);
        }

        private void SignUp(object sender, EventArgs e)
        {
            Service service = new Service();

            string uid = txtUserID.Text;
            string pwd = txtPwd.Text;

            if (uid == "" && pwd == "")
            {
                MessageBox.Show("���̵�� ��й�ȣ�� ��� �Է����ּ���.");
            }
            else if (uid == "")
            {
                MessageBox.Show("���̵� �Է����ּ���.");
            }
            else if (pwd == "")
            {
                MessageBox.Show("��й�ȣ�� �Է����ּ���.");
            }
            else
            {
                int result = service.signup(uid, pwd);

                if (result == 1)
                {
                    MessageBox.Show("ȸ�����Կ� �����߽��ϴ�.");
                    this.login(sender, e);
                }
                else
                {
                    MessageBox.Show("ȸ�����Կ� �����Ͽ����ϴ�.");
                }
            }
        }
    }
}