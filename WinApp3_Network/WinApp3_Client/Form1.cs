using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp3_Client
{
    //클라이언트는 서버 쪽 프로세스보다 간단
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        Socket _Sock; 

        private void mnuStart_Click(object sender, EventArgs e)
        {//일정시간 간격으로 데이터를 조립해서 얹어주는 과정 필요 -> 타이머 만들어서 사용
            timer1.Interval = int.Parse(tbInterval.Text); //tb에 입력한 값을 타이머 시간 간격으로 설정
            timer1.Enabled = true;

        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }
        int pCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {//enabled가 true가 됐을 때
            string s1 = tbCode.Text;    // 10001 ->보통 5자리
            string s2 = tbModel.Text;   // 00000 ->5자리
            string s3 = tbTemp.Text;    // 10.5 ->5자리
            string s4 = tbHum.Text;    // 30.00 ->5자리
            string s5 = tbWind.Text;    // 05.70 ->5자리
            string s6 = dateTimePicker1.Text;   // 2020년10월00일 00:00:00
            //프로토콜 정의 : [STX:02][s1:05][s2:05][s3:05][s4:05][s5:05][ETX:03] 패킷의 시작과 끝을 표현(헥사 코드) [05]: 자리수
            string sPro = $"[STX]{s1}{s2}{s3}{s4}{s5}[ETX]"; //가능하다면 긴 자리는 쓰지 않는게 좋음(5자 이하)

            _Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _Sock.Connect(tbServerIP.Text, int.Parse(tbServerPort.Text)); //사용 시 IP, 포트설정 해줘야 함
            _Sock.Send(Encoding.Default.GetBytes(sPro + "\r\n")); //프로토콜 string(2byte)을 1byte type으로 전달 default는 시스템 설정값(UTF-8이나 아스키코드 등으로도 가능함)
            tbProtocol.Text = $"[{pCount++}] {sPro}"; //multi가 아니니까 계속 갱신해야함(+=가 아님)
        }
    }
}
