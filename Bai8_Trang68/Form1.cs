using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Trang68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cho phép hiển thị trên nhiều cột
            clbMenu.MultiColumn = true;
            //Cho phép hiển thị trên n cột
            clbMenu.ColumnWidth = clbMenu.Width / 3;
            //Thêm các phần tử vào CheckedListBox
            clbMenu.Items.Add("Ba chỉ cuốn nắm");
            clbMenu.Items.Add("Ba chỉ luộc chấm mắm tép");
            clbMenu.Items.Add("Thịt gà rang muối");
            clbMenu.Items.Add("Thịt gà nướng");
            clbMenu.Items.Add("Bê nướng");
            clbMenu.Items.Add("Chả cá lã vọng");
            clbMenu.Items.Add("Bún ốc");
            clbMenu.Items.Add("Cháo chim bồ câu");
            clbMenu.Items.Add("Cháo sườn");
            clbMenu.Items.Add("Đậu rán");
            clbMenu.Items.Add("Rau muống xào tỏi");
            clbMenu.Items.Add("Rau bí ngô luộc");

            clbMenu.Items.Add("Ba chỉ cuốn nắm");
            clbMenu.Items.Add("Ba chỉ luộc chấm mắm tép");
            clbMenu.Items.Add("Thịt gà rang muối");
            clbMenu.Items.Add("Thịt gà nướng");
            clbMenu.Items.Add("Bê nướng");
            clbMenu.Items.Add("Chả cá lã vọng");
            clbMenu.Items.Add("Bún ốc");
            clbMenu.Items.Add("Cháo chim bồ câu");
            clbMenu.Items.Add("Cháo sườn");
            clbMenu.Items.Add("Đậu rán");
            clbMenu.Items.Add("Rau muống xào tỏi");
            clbMenu.Items.Add("Rau bí ngô luộc");

            clbMenu.Items.Add("Ba chỉ cuốn nắm");
            clbMenu.Items.Add("Ba chỉ luộc chấm mắm tép");
            clbMenu.Items.Add("Thịt gà rang muối");
            clbMenu.Items.Add("Thịt gà nướng");
            clbMenu.Items.Add("Bê nướng");
            clbMenu.Items.Add("Chả cá lã vọng");
            clbMenu.Items.Add("Bún ốc");
            clbMenu.Items.Add("Cháo chim bồ câu");
            clbMenu.Items.Add("Cháo sườn");
            clbMenu.Items.Add("Đậu rán");
            clbMenu.Items.Add("Rau muống xào tỏi");
            clbMenu.Items.Add("Rau bí ngô luộc");

            clbMenu.Items.Add("Ba chỉ cuốn nắm");
            clbMenu.Items.Add("Ba chỉ luộc chấm mắm tép");
            clbMenu.Items.Add("Thịt gà rang muối");
            clbMenu.Items.Add("Thịt gà nướng");
            clbMenu.Items.Add("Bê nướng");
            clbMenu.Items.Add("Chả cá lã vọng");
            clbMenu.Items.Add("Bún ốc");
            clbMenu.Items.Add("Cháo chim bồ câu");
            clbMenu.Items.Add("Cháo sườn");
            clbMenu.Items.Add("Đậu rán");
            clbMenu.Items.Add("Rau muống xào tỏi");
            clbMenu.Items.Add("Rau bí ngô luộc");
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (string item in clbMenu.CheckedItems)
                str = str + item + ", ";
            //Xóa dấu phẩy và dấu cách thừa cuối chuỗi
            str = str.Remove(str.Length - 2, 2);
            MessageBox.Show("Bạn đã chọn các món sau: " + str);
        }

        private void clbMenu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                MessageBox.Show("Bạn vừa chọn thêm món: " + clbMenu.SelectedItem,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
