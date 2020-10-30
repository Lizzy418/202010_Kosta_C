using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp3_Network
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }
        public string GetToken(int n, string str, string sep = ",") //","를 default로 구분자(->sep) 설정, 디폴트 값이 있는 애를 맨 뒤에 써야 함
        {
            int i; //local index, int i, j, k;로 미리 만들어 두면 루프돌리기 편함
            int n1 = 0, n2 = 0, n3 = 0; //temp int 변수
            for (i = 0; i < n; i++)
            {
                n1 = str.IndexOf(sep, n1) + 1; // i번째 구분자
                if (n1 == 0) return "";
            }
            n2 = str.IndexOf(sep, n1); //n+1번째 구분자
            if (n2 == -1) n2 = str.Length;

            n3 = n2 - n1; //문자열 길이 계산
            string sRet = str.Substring(n1, n3);
            return sRet;
        }
        
        //C에서 함수 포인터랑 같은 역할, 함수를 클래스 멤버로서 호출하는게 아니라 주소를 호출
        delegate void AddTextCallBack(string str); //로컬함수가 아닌 함수의 포인터
        private void AddText(string str)
        {   //스레드는 form1에 직접 액세스 X, 그래서 콜백할 수 있게 만들어주는 것
            if (this.tbMemo.InvokeRequired) 
            {
                AddTextCallBack d = new AddTextCallBack(AddText);
                this.Invoke(d, new object[] { str });
            }
            else
                tbMemo.Text += str;
        }

        TcpListener _Listen;
        TcpClient _Sock;
        byte[] buf = new byte[20000];
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(_Listen == null) //여러번 버튼 클릭 방지
                _Listen = new TcpListener(int.Parse(tbPort.Text));
            _Listen.Start(); //서버 연결 준비
            // Waiting... - if문까지 thread로 넘겨줘야 할 부분
            Thread ServerThread = new Thread(ServerProcess);
            ServerThread.Start(); //일반함수와 같아서 계속 돌아가는 게 아니라 끝나면 종료됨 -> 따라서 무한루프로 만들어야 함
            //_Listen.Stop();        
        }

        //서버 Thread 함수
        private void ServerProcess()
        {
            while(true)//C#은 1 안됨
            {
                _Sock = _Listen.AcceptTcpClient(); //Session Open(대기시작) 외부로부터 접속을 받아서 처리
                //tbMemo.Text += _Sock.Client.RemoteEndPoint.ToString(); //성공 시 어디서부터 접속되는지 확인
                //Cross Thread Error : tbMemo에 직접 접근 불가 ==> Invoke 필요
                string s1 = GetToken(0, _Sock.Client.RemoteEndPoint.ToString(), ":");
                AddText($"원격 접속 요청 : {s1}\r\n"); //성공 시 어디서부터 접속되는지 확인
                //외부 스레드 받으면 위 라인이 예외처리 안됐다는 에러가 뜸
                NetworkStream ns = _Sock.GetStream();//소켓에 대해 스트림 연결 지어줌
                if (ns.DataAvailable) //데이터가 현재 들어온 값이 있는지
                {
                    ns.Read(buf, 0, (int)(buf.Length)); //Read는 버퍼를 만들어 줘야 함, ns.Length는 long 값이라 int로 바꿔줘야 함
                                                       //buf: byte array
                    AddText(Encoding.Default.GetString(buf) + "\r\n");
                    //버퍼는 통신에서 이미 받은 것, 넷스트림으로 넘길 땐 바이트지만 다시 출력되어 보일 때는 스트링으로 변환해줘야 하니까
                }
            }            
        }
    }
}
