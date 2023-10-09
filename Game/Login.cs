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
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
            }
            else if (uid == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
            }
            else if (pwd == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }
            else
            {
                int result = service.login(uid, pwd);

                if (result == 1)
                {
                    this.Hide();
                    MessageBox.Show("로그인에 성공했습니다.");
                    Main main = new Main();
                    main.ShowDialog();
                }
                else if (result == -1)
                {
                    MessageBox.Show("아이디를 잘못 입력하였습니다.");
                }
                else if (result == -2)
                {
                    MessageBox.Show("비밀번호를 잘못 입력하였습니다.");
                }
                else if (result == -3)
                {
                    MessageBox.Show("아이디와 비밀번호를 다시 확인해주세요.");
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다..");
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
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.");
            }
            else if (uid == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
            }
            else if (pwd == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }
            else
            {
                int result = service.signup(uid, pwd);

                if (result == 1)
                {
                    MessageBox.Show("회원가입에 성공했습니다.");
                    this.login(sender, e);
                }
                else
                {
                    MessageBox.Show("회원가입에 실패하였습니다.");
                }
            }
        }
    }
}