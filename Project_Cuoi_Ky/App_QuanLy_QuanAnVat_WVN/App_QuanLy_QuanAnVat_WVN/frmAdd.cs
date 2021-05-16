using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLy_QuanAnVat_WVN
{
    public partial class frmAdd : Form
    {
        String tenBan = "";
        public frmAdd(String tenmon,String tenban)
        {
            InitializeComponent();
            lbNameFromMenu.Text = tenmon;
            tenBan = tenban;
            this.ActiveControl = null;
        }
        public String resultSL
        {
            get
            {
                if(Int32.Parse(txtSL.Text) == 0)
                {
                    return "";
                }
                return txtSL.Text;
            }
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            txtSL.Text = "0";
            txtSL.TextAlign = HorizontalAlignment.Center;
            lbDown.ForeColor = Color.White;
            lbDown.BackColor = Color.LightSeaGreen;
            lbUp.ForeColor = Color.White;
            lbUp.BackColor = Color.LightSeaGreen;
            btnXacNhanAdd.BackColor = Color.YellowGreen;
            btnXacNhanAdd.ForeColor = Color.White;
            //String NameOfImage = "";
            //NameOfImage = BUSWVN.Instance.getImageBUS(lbNameFromMenu.Text);
            //pbAdd.Image = Image.FromFile("../../Image/Mon/"+NameOfImage);
        }

        private void lbUp_Click(object sender, EventArgs e)
        {
            int up = Int32.Parse(txtSL.Text);
            up += 1;
            if(up>99)
            {
                MessageBox.Show("Đã đạt tối đa");
            }else
            {
                txtSL.Text = up.ToString();
                txtSL.SelectionStart = txtSL.Text.Length;
            }
            
        }

        private void lbDown_Click(object sender, EventArgs e)
        {
            int down = Int32.Parse(txtSL.Text);
            down -= 1;
            if(down < 0)
            {

            }
            else
            {
                txtSL.Text = down.ToString();
            }
            
        }

        private void btnXacNhanAdd_Click(object sender, EventArgs e)
        {
            if(txtSL.Text == "")
            {
                txtSL.Text = "0";
            }
            if(Int32.Parse(txtSL.Text)!=0)
            {
                BUSWVN.Instance.ThemMonOrderBUS(tenBan, lbNameFromMenu.Text, Int32.Parse(txtSL.Text));
            }
            this.Close();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //if(System.Text.RegularExpressions.Regex.IsMatch(txtSL.Text,"[^0-9]"))
            //{
            //    MessageBox.Show("Chỉ nhập số !!!");
            //    txtSL.Text = txtSL.Text.Remove(txtSL.Text.Length - 1);
            //}
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                //MessageBox.Show("This isn't Number");
                e.Handled = true;
            }
        }
    }
}
