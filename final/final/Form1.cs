using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;




namespace final
{
    public partial class txt_receive_data : Form
    {
        //Frame
        //Start
        byte[] STX =new byte[] { 0X02 } ;
        

        //Command
        byte[] LED12 = { 0X19 };
        byte[] LED13 = { 0X18 };
        byte[] LED14 = { 0X17 };
        byte[] LED15 = { 0X16 };
        byte[] START = { 0x11 };
        byte[] STOP = { 0x12 };
        byte[] KP = { 0x08 };
        byte[] KI = { 0x07 };
        byte[] KD = { 0x10 };
        byte[] SET_POINT = { 0x04 };

        byte[] EMER = { 0X06 };
        //End
        byte[] ETX = { 0x03 };

        

        // Khai báo 1 biến dùng cho timer, chạy cột thời gian tính bằng ms
        int tickStart = 0;
        string SetPoint_temp = "";
        public txt_receive_data()
        {
            InitializeComponent();
            getAvailablePorts();
        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cbb_select_com.Items.AddRange(ports);
        }
        string[] baud = {  "9600", "115200" };
        string[] datasize = { "7", "8","9" };


        double Speed = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // khi khởi động sẽ được chạy
            GraphPane mypane = zedGraphControl1.GraphPane;// Khai báo sửa dụng Graph loại GraphPane;
            // Các thông tin cho đồ thị của mình
            mypane.Title.Text = "Motor Speed";
            mypane.XAxis.Title.Text = "Time";
            mypane.YAxis.Title.Text = "speed";
            // Định nghĩa list để vẽ đồ thị. Để các bạn hiểu rõ cơ chế làm việc ở đây khai báo 2 list điểm <=> 2 đường đồ thị
            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);
            // Ở đây sử dụng list với 6000 điểm (có thể thêm nhiều liệu tại đây)

            // dòng dưới là định nghĩa curve để vẽ.
            LineItem duongline1 = mypane.AddCurve("Setpoint", list1, Color.Red, SymbolType.None);// Color màu đỏ, đặc trưng cho đường 1
            LineItem duongline2 = mypane.AddCurve("Speed", list2, Color.Blue, SymbolType.None);//  Color màu Xanh, đặc trưng cho đường 2


            // Định hiện thị cho trục thời gian (Trục X)
            mypane.XAxis.Scale.Min = 0;// Min  = 0;
            mypane.XAxis.Scale.Max = 300;// Max  = 30;
            mypane.XAxis.Scale.MinorStep = 10;// Đơn vị chia nhỏ nhất 10
            mypane.XAxis.Scale.MajorStep = 20; // Đơn vị chia lớn nhất 20

            // Định hiện thị cho trục tốc độ (Trục Y)
            mypane.YAxis.Scale.Min = -350;
            mypane.YAxis.Scale.Max = 350;
            mypane.YAxis.Scale.MinorStep = 10;
            mypane.YAxis.Scale.MajorStep = 10;


            // Gọi hàm xác định cỡ trục
            zedGraphControl1.AxisChange();

            // Khởi động timer về vị trí ban đầu 
            tickStart = Environment.TickCount;

            string[] myport = SerialPort.GetPortNames();
            cbb_select_com.Items.AddRange(myport);
            cbb_select_baud.Items.AddRange(baud);
            cbb_datasize.Items.AddRange(datasize);
            cbb_parity.Items.AddRange(Enum.GetNames(typeof(Parity)));

            
        }

      
        public void draw(double line1, double line2)
        {
            
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            // Kiểm tra việc khởi tạo các đường curve
            // Đưa về điểm xuất phát
            
            LineItem duongline1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem duongline2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            if (duongline1 == null)
                return;
            if (duongline2 == null)
                return;

            // list chứa các điểm. 
            // Get the PointPairList
            IPointListEdit list1 = duongline1.Points as IPointListEdit;
            IPointListEdit list2 = duongline2.Points as IPointListEdit;


            if (list1 == null)
                return;
            if (list2 == null)
                return;

            // Time được tính bằng ms
            double time = (Environment.TickCount - tickStart) / 1000.0;

            // Tính toán giá trị hiện thị

            // Muốn hiện thị cái gì thì chỉ việc thay vào setpoint, Speed
            double SetPoint;
            
            double.TryParse(SetPoint_temp, out SetPoint);
            double.TryParse(txt_receive.Text, out Speed);


            list1.Add(time, SetPoint);
            list2.Add(time, Speed);


            // đoạn chương trình thực hiện vẽ đồ thị
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                //xScale.Max = time + xScale.MajorStep;
                // xScale.Min = xScale.Max - 30.0; // Timer chạy qua 30 sẽ tự động dịch chuyển tịnh tiến sang trái
                // Nếu ko muốn dịch chuyển mà chạy bắt đầu từ 0 thì : xScale.Min = 0;
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }
            

            // Vẽ đồ thị
            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            draw(5, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                bt_connect.Text = "DISCONNECT";
                serialPort1.PortName = cbb_select_com.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbb_select_baud.Text);
                serialPort1.DataBits = Convert.ToInt32(cbb_datasize.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbb_parity.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            else if(serialPort1.IsOpen)
            {
                bt_connect.Text = "CONNECT";
                
                bt_Start.Text = "START";

                serialPort1.Close();
            }

        }


 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led1.Checked)==true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED12);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 12: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED12);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 12: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            
        }


        private void cb_led2_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led2.Checked) == true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED13);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 13: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED13);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 13: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
           
        }
        private void cb_led14_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led14.Checked) == true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED14);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 14: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED14);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 14: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
        }
        private void cb_led15_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led15.Checked) == true)
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED15);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 15: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED15);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Led 15: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {

            if (bt_Start.Text == "START")
            {
                bt_Start.Text = "STOP";
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(START);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2  +"00000" +s3;
                serialPort1.Write(s);
                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Start/Stop: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else if (bt_Start.Text == "STOP")
            {
                bt_Start.Text = "START";
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(STOP);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 +"00000" +s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "cmd Start/Stop: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }

        }


        private void bt_update_kp_Click(object sender, EventArgs e)
        {
            string s1 = System.Text.Encoding.UTF8.GetString(STX);
  
            string s2 = System.Text.Encoding.UTF8.GetString(KP);

            string s3 = System.Text.Encoding.UTF8.GetString(ETX);

            string s =s1+s2+"00"+txt_kp.Text+s3 ;
            serialPort1.Write(s);

            txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
            txt_syn.Text += "cmd Kp: " + Environment.NewLine;
            txt_syn.Text += s + Environment.NewLine;

            txt_syn.SelectionStart = txt_syn.TextLength;
            txt_syn.ScrollToCaret();

        }

        private void bt_update_ki_Click(object sender, EventArgs e)
        {
            string s1 = System.Text.Encoding.UTF8.GetString(STX);

            string s2 = System.Text.Encoding.UTF8.GetString(KI);

            string s3 = System.Text.Encoding.UTF8.GetString(ETX);

            string s = s1 + s2 + "0000" + txt_ki.Text + s3;
            serialPort1.Write(s);

            txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
            txt_syn.Text += "cmd Ki: " + Environment.NewLine;
            txt_syn.Text += s + Environment.NewLine;

            txt_syn.SelectionStart = txt_syn.TextLength;
            txt_syn.ScrollToCaret();
        }

        private void bt_update_kd_Click(object sender, EventArgs e)
        {
            string s1 = System.Text.Encoding.UTF8.GetString(STX);

            string s2 = System.Text.Encoding.UTF8.GetString(KD);

            string s3 = System.Text.Encoding.UTF8.GetString(ETX);

            string s = s1 + s2 + "00" +txt_kd.Text + s3;
            serialPort1.Write(s);

            txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
            txt_syn.Text += "cmd kd: " + Environment.NewLine;
            txt_syn.Text += s + Environment.NewLine;

            txt_syn.SelectionStart = txt_syn.TextLength;
            txt_syn.ScrollToCaret();
        }

        private void bt_update_set_point_Click(object sender, EventArgs e)
        {
            SetPoint_temp = txt_setpoint.Text;
            
            string s1 = System.Text.Encoding.UTF8.GetString(STX);

            string s2 = System.Text.Encoding.UTF8.GetString(SET_POINT);

            string s3 = System.Text.Encoding.UTF8.GetString(ETX);

            string s = s1 + s2  + txt_setpoint.Text + s3;
            serialPort1.Write(s);

            txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
            txt_syn.Text +="cmd Set point: " + Environment.NewLine;
            txt_syn.Text += s + Environment.NewLine;
            
            txt_syn.SelectionStart = txt_syn.TextLength;
            txt_syn.ScrollToCaret();
        }
        
        private void OnData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            String Data_In = "";
            Data_In = serialPort1.ReadExisting();
            
            if (Data_In != String.Empty)
            {
                SetText(Data_In); // Chính vì vậy phải sử dụng ủy quyền đây.Gọi delegate đã khai báo trước đó.
            }
        }

        private delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.txt_receive.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Substring(0, 1) == "\u0002")
                {
                    txt_ack.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine;
                    this.txt_ack.Text += text;
                    txt_ack.Text += Environment.NewLine;
                    this.txt_ack.SelectionStart = txt_syn.TextLength;
                    this.txt_ack.ScrollToCaret();
                }
                else if(text.Substring(0, 1) == "\u0006")
                {
                    this.txt_emergency.Text = "STOP !!";
                    bt_Start.Text = "START";
                }
                else
                {
                    this.txt_receive.Text = text;
                }
            }
        }
    }
}
