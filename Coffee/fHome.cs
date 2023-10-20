using Coffee.db;
using Coffee.frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{

    public partial class fHome : Form
    {
        int i = 1;
        BindingSource congthucList = new BindingSource();
        bool Checksdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10}$");
        }
        bool Checkemail(string ema)
        {
            return Regex.IsMatch(ema, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        string Tennv = "";
        int Idstaff;
        int CheckAdmin;
        string Chucvu="";
        bool isThoat = true;
        public fHome(string name, int checkadmin, int checkchucvu,int id)
        {
            
            this.Tennv = name;
            this.CheckAdmin = checkadmin;
            Idstaff = id;
            InitializeComponent();
            LoadTable();
            LoadCategoryfind();
            LoadCategory();
            loadlstcongthuc();
            Loadpromotion();
            loadluong();
            if (checkchucvu == 1)
            {
                Chucvu = "Nhân viên parttime";
            }
            else if(checkchucvu == 2)
            {
                Chucvu = "Nhân viên fulltime";
            }
            else
            {
                Chucvu = "Quản lý";
            }
            if (i == 1)
            {
                CongthucBinding();
                i++;
            }

            if (CheckAdmin == 1)
            {
                btn_adm.Enabled = true;               
            }
            else 
            {
                btn_adm.Enabled = false;
                Chucvu = "Nhân viên"; 
            }
            lb_welcome.Text="Chào "+ Tennv + " - "+ Chucvu;
        }


        #region 

        void loadluong()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            tb_luong.Text = Dbsala.Instance.showluong(Idstaff).ToString("c", culture);
        }

        void Loadpromotion()
        {
            List<Promotion> listpro = Dbpromotion.Instance.getlstpro();
            cb_khuyenmai.DataSource = listpro;
            cb_khuyenmai.DisplayMember = "Name";
        }

        void loadlstcongthuc()
        {
            dgv_findct.DataSource = congthucList;
            congthucList.DataSource = Dbcongthuc.Instance.LoadCongthucs((cb_findfood.SelectedItem as Food).ID);
            //congthucList.DataSource = Dbcongthuc.Instance.GetListCongthuc();
        }

        void CongthucBinding()
        {
            tb_loadct.DataBindings.Add(new Binding("Text", dgv_findct.DataSource, "guide", true, DataSourceUpdateMode.Never));
        }

        void LoadTable()
        {
            flwTable.Controls.Clear();
            List<Table> tableList = Dbtable.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width =90, Height =90};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                if(item.Status== "Trống")
                {
                    btn.BackColor = Color.LightSeaGreen;
                }
                else { btn.BackColor = Color.LightPink; }
                flwTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lvgoimon.Items.Clear();
            List<frames.Menu> listBillInfo = Dbmenu.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (frames.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvgoimon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            tbtongtien.Text = totalPrice.ToString("c", culture);

        }
        void LoadCategory()
        {
            List<Category> listCategory = Dbcategory.Instance.GetListCategory();
            cb_cate.DataSource = listCategory;
            cb_cate.DisplayMember = "Name";
        }
        void LoadCategoryfind()
        {
            List<Category> listCategory = Dbcategory.Instance.GetListCategory();
            cb_findcate.DataSource = listCategory;
            cb_findcate.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = Dbfood.Instance.GetFoodByCategoryID(id);
            cb_food.DataSource = listFood;
            cb_food.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryIDfind(int id)
        {
            List<Food> listFood = Dbfood.Instance.GetFoodByCategoryID(id);
            cb_findfood.DataSource = listFood;
            cb_findfood.DisplayMember = "Name";
        }
        #endregion

        #region event

        private void btnexit_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            flogin l = new flogin();
            l.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvgoimon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_cate.SelectedItem as Category).ID);
            if (lvgoimon.Tag != null)
                ShowBill((lvgoimon.Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_cate.SelectedItem as Category).ID);
            if (lvgoimon.Tag != null)
                ShowBill((lvgoimon.Tag as Table).ID);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_cate.SelectedItem as Category).ID);
            if (lvgoimon.Tag != null)
                ShowBill((lvgoimon.Tag as Table).ID);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Table table = lvgoimon.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Cần chọn bàn!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int idBill = Dbbill.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cb_food.SelectedItem as Food).ID;
            int count = (int)nmadd.Value;

            if (idBill == -1)
            {
                Dbbill.Instance.InsertBill(table.ID);
                DbbillInfo.Instance.InsertBillInfo(Dbbill.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                DbbillInfo.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }
        private void cb_cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void cb_findcate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryIDfind(id);
        }
        private void btn_adm_Click(object sender, EventArgs e)
        {
            fQuanly q= new fQuanly();
            q.ShowDialog();
            q.AddFood += Q_AddFood;
            q.EditFood += Q_EditFood;
        }

        private void Q_EditFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_cate.SelectedItem as Category).ID);
            LoadFoodListByCategoryID((cb_findcate.SelectedItem as Category).ID);
            if (lvgoimon.Tag != null)
                ShowBill((lvgoimon.Tag as Table).ID);
            LoadTable();
        }



        private void Q_AddFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_cate.SelectedItem as Category).ID);
            LoadFoodListByCategoryID((cb_findcate.SelectedItem as Category).ID);
            if (lvgoimon.Tag != null)
                ShowBill((lvgoimon.Tag as Table).ID);
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
            {
            if (tb_sdtcheck.Text == "")
            {
                MessageBox.Show("vui lòng nhập sdt khách hàng!"); return;
            }
            if (!Dbcustomers.Instance.Checksdtkh(tb_sdtcheck.Text))
            {
                MessageBox.Show("Sdt chưa đăng kí!"); return;
            }
            Table table = lvgoimon.Tag as Table;
            if (table != null)
            {

                int kmid = (cb_khuyenmai.SelectedItem as Promotion).ID;
                double discount = (cb_khuyenmai.SelectedItem as Promotion).Discount;
                string sdt = tb_sdtcheck.Text;
                int idBill = Dbbill.Instance.GetUncheckBillIDByTableID(table.ID);
                String format = tbtongtien.Text.Replace(".", "");
                double totalPrice = double.Parse(format.Split(',')[0]);
                if (idBill != -1)
                {
                    double finalprice = totalPrice * discount;
                    Dbbill.Instance.CheckOut(idBill, (float)totalPrice, sdt, kmid,Idstaff);
                    ShowBill(table.ID);
                    MessageBox.Show(string.Format("{0} và Mã giảm:{1}\nTổng tiền= {2} VNĐ\n Thành tiền={3} VNĐ"
                        , table.Name,discount,totalPrice ,finalprice), "Thông báo", MessageBoxButtons.OK);
                    LoadTable();
                }
            }
            tb_sdtcheck.Clear();
        }

        private void btn_dkikh_Click(object sender, EventArgs e)
        {

            string tenkh = tb_tenkh.Text.Trim();
            string sdt = tb_sdtkh.Text;
            string email=tb_emailkh.Text;
            DateTime nskh = dp_ngaysinhkh.Value;
            if (tenkh == "") { MessageBox.Show("Vui lòng nhập tên khách hàng"); return; }
            if (!Checksdt(sdt)) { MessageBox.Show("Vui lòng nhập đầy đủ sdt"); return; }
            if (nskh > DateTime.Today) { MessageBox.Show("Vui lòng nhập đúng ngày sinh"); return; }
            if (!Checkemail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng"); return; }
            bool i = Dbcustomers.Instance.Checksdtkh(sdt);
            if (i)
            {
                MessageBox.Show("Sdt đã được đăng kí"); return;
            }
            else
            {
                Dbcustomers.Instance.Insertkh(tenkh, sdt, email, nskh);
                MessageBox.Show("Đăng kí thành công");
                tb_tenkh.Clear();
                tb_sdtkh.Clear();
                tb_emailkh.Clear();
                return;
            }

        }

        private void btn_checksdt_Click(object sender, EventArgs e)
        {
            if (tb_sdtcheck.Text == "")
            {
                MessageBox.Show("vui lòng nhập sdt khách hàng!"); return;
            }
            DataTable dt = Dbcustomers.Instance.Checkvip(tb_sdtcheck.Text);
            if(dt.Rows.Count > 0)
            {
                tb_resultcheck.Text = dt.Rows[0][1].ToString() +" - "+dt.Rows[0][0].ToString();
            }
            else
            {
                tb_resultcheck.Text = "Số điện thoại chưa đăng kí!";
            }
        }

        private void btn_rfluong_Click(object sender, EventArgs e)
        {
            loadluong();
        }

        private void btn_acpsala_Click(object sender, EventArgs e)
        {
            string repl = tb_luong.Text.Replace(".", "");
            float nhanluong = float.Parse(repl.Split(',')[0]);
            if (nhanluong == 0)
            {
                MessageBox.Show("Chưa có lương!");return;
            }
            else
            {
                Dbsala.Instance.getluong(Idstaff);
                loadluong();
                MessageBox.Show("Nhận lương thành công!"); return;
            }
        }

        private void btn_findct_Click(object sender, EventArgs e)
        {
            loadlstcongthuc();
        }
        #endregion

        private void btn_submitrp_Click(object sender, EventArgs e)
        {
            if (tb_titlerp.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung"); return;
            }
            if(tb_contentrp.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập nội dung"); return;
            }
            if(!DbReport.Instance.InsertRP(tb_titlerp.Text, tb_contentrp.Text, Idstaff))
            {
                MessageBox.Show("có lỗi"); return;
            }
            else
            {
                MessageBox.Show("Báo cáo thành công!");
                tb_contentrp.Clear();
                tb_titlerp.Clear();
                return;
            }
        }
    }
}
