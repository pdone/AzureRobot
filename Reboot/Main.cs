using System;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
/*
 * Author: Pdone
 * Create Date: 2014-06-01
 * GitHub: https://github.com/pdone/AzureRobot
 * Weibo: https://weibo.com/pdone/
*/
namespace Robot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            userid = new Random().Next(1, 99);
        }
        int userid = 0;
        private void send_Click(object sender, EventArgs e)
        {
            string input = input_tbx.Text;
            string senddata = "{\"key\":\"" + "fbb2dd8476e67aee22b8a91f242a9c2c" + "\",\"info\":\"" + input + "\",\"userid\":\"" + userid + "\"}";
            string post = GetPostStr("http://www.tuling123.com/openapi/api", senddata);
            JObject obj = JObject.Parse(post);//字符串变成json
            switch ((int)obj["code"])//消息类型编号 
            {
                case 100000://文字类
                    main_tbx.AppendText("我：" + input + "\r\n" + "Azure：" + obj["text"] + "\r\n");
                    break;
                case 200000://链接类
                    main_tbx.AppendText("我：" + input + "\r\n" + "Azure：" + obj["text"] + "\r\n" + obj["url"] + "\r\n");
                    break;
                case 302000://新闻类
                    main_tbx.AppendText("我：" + input + "\r\n" + "Azure：" + obj["text"] + "\r\n" + obj["list"][0]["article"] + obj["list"][0]["detailurl"] + "\r\n" + obj["list"][1]["article"] + obj["list"][1]["detailurl"] + "\r\n" + obj["list"][2]["article"] + obj["list"][2]["detailurl"] + "\r\n");
                    break;
                case 308000://菜谱类
                    main_tbx.AppendText("我：" + input + "\r\n" + "Azure：" + obj["text"] + "：\r\n" + obj["list"][0]["info"] + "\r\n" + obj["list"][0]["detailurl"] + "\r\n");
                    break;
            }
            main_tbx.ScrollToCaret();//光标定位到插入地方
            main_tbx.Focus();//获取焦点
            main_tbx.Select(main_tbx.TextLength, 0);//光标定位到文本最后
            main_tbx.ScrollToCaret();//滚动到光标处
            input_tbx.Text = "";
            input_tbx.Focus();
        }
        public string GetPostStr(string url, string senddata)
        {
            System.Net.WebClient webc = new System.Net.WebClient();
            var apiurl = new Uri(url);
            string sendstr = senddata;
            var arr = webc.UploadData(apiurl, Encoding.UTF8.GetBytes(sendstr));
            return Encoding.UTF8.GetString(arr);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            main_tbx.Clear();
        }

        private void main_tbx_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
