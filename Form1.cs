using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713110.Properties;

namespace WP_2020_01_HW02_3A713110
{
    
    public partial class frmGame : Form
    {
        int a=0;
        List<Image> list;
        Poker p = null;
        List<int> Poker;

        public frmGame()
        {
            InitializeComponent();
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            if (a<54)
            {
                pictureBox1.Image = list[Poker[a]];
                a = a + 1;
            }
            
        }



        private void frmGame_Load_1(object sender, EventArgs e)
        {
            p = new Poker();
            Poker = p.GetPoker(54);
            list = new List<Image>();

            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._007);
            list.Add(Resources._008);
            list.Add(Resources._009);
            list.Add(Resources._010);
            list.Add(Resources._011);
            list.Add(Resources._012);
            list.Add(Resources._013);
            list.Add(Resources._014);
            list.Add(Resources._015);
            list.Add(Resources._016);
            list.Add(Resources._017);
            list.Add(Resources._018);
            list.Add(Resources._019);
            list.Add(Resources._020);
            list.Add(Resources._021);
            list.Add(Resources._022);
            list.Add(Resources._023);
            list.Add(Resources._024);
            list.Add(Resources._025);
            list.Add(Resources._026);
            list.Add(Resources._027);
            list.Add(Resources._028);
            list.Add(Resources._029);
            list.Add(Resources._030);
            list.Add(Resources._031);
            list.Add(Resources._032);
            list.Add(Resources._033);
            list.Add(Resources._034);
            list.Add(Resources._035);
            list.Add(Resources._036);
            list.Add(Resources._037);
            list.Add(Resources._038);
            list.Add(Resources._039);
            list.Add(Resources._040);
            list.Add(Resources._041);
            list.Add(Resources._042);
            list.Add(Resources._043);
            list.Add(Resources._044);
            list.Add(Resources._045);
            list.Add(Resources._046);
            list.Add(Resources._047);
            list.Add(Resources._048);
            list.Add(Resources._049);
            list.Add(Resources._050);
            list.Add(Resources._051);
            list.Add(Resources._052);
            list.Add(Resources._053);
            list.Add(Resources._054);
        }

        private void rtbMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
