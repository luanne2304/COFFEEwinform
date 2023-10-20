using Coffee.db;
using Coffee.frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Coffee
{
    public partial class fQuanly : Form
    {
        int i = 1;
        BindingSource nvList = new BindingSource();
        BindingSource namenvList = new BindingSource();
        BindingSource foodList = new BindingSource();
        BindingSource congthucList = new BindingSource();
        BindingSource khList = new BindingSource();
        BindingSource rpList = new BindingSource();
        public fQuanly()
        {
            InitializeComponent();
            load();
        }

        #region

        bool Checksogio(string acc)
        {
            return Regex.IsMatch(acc, "^[0-9]{1,3}$");
        }
        bool Checkacc(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{6,20}$");
        }
        bool Checksdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10}$");
        }
        bool Checkemail(string ema)
        {
            return Regex.IsMatch(ema, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        void load()
        {
            dgv_showrp.DataSource = rpList;
            dgv_lsttentksala.DataSource = namenvList;
            dgv_lstnv.DataSource = nvList;
            dgv_congthuc.DataSource = congthucList;
            dgv_food.DataSource = foodList;
            dgv_editkh.DataSource = khList;
            loadlstbill(dp_tungay.Value, dp_dengay.Value);
            loadtotalPrice(dp_tungay.Value, dp_dengay.Value);
            loadlstFood();
            loadlstcongthuc();
            LoadCategoryIntoCombobox(cb_idcate);
            FoodBinding();
            ShowCate();
            LoadCategoryfind();
            CongthucBinding();
            rpBinding();
            loadlstkh();
            Loadlistnv();
            loadlstnamenv();
            loadlvbangcong();
            loadcbrank();
            loadlistrp();
            if (i == 1)
            {
                khcBinding();
                nvBinding();
                namenvBinding();
                i++;
            }

        }

        void loadcbrank()
        {
            List<Rank> listCategory = Dbrank.Instance.getlstrank();
            cb_rankkh.DataSource = listCategory;
            cb_rankkh.DisplayMember = "id";
        }

        void loadlvbangcong()
        {
            lv_bangcong.Items.Clear();
            List<Sala> listsala = Dbsala.Instance.getlstsala();
            foreach (Sala item in listsala)
            {
                ListViewItem lsvItem = new ListViewItem(item.Idstaff.ToString());
                lsvItem.SubItems.Add(item.Luong.ToString());
                lv_bangcong.Items.Add(lsvItem);
            }
        }

        void loadlistrp()
        {
            rpList.DataSource = DbReport.Instance.getlstrp();
        }

        void loadlstnamenv()
        {
            namenvList.DataSource = Dbstaff.Instance.getlstnamenv();
        }

        void Loadlistnv()
        {
            nvList.DataSource = Dbstaff.Instance.getlstnv();
        }

        void loadlstkh()
        {
            List<Customers> lstcus = Dbcustomers.Instance.getlstkh();
            khList.DataSource = lstcus;
        }

        void rpBinding()
        {
            tb_showcontentrp.DataBindings.Add(new Binding("Text", dgv_showrp.DataSource, "content", true, DataSourceUpdateMode.Never));
            tb_showtitlerp.DataBindings.Add(new Binding("Text", dgv_showrp.DataSource, "title", true, DataSourceUpdateMode.Never));
        }

        void namenvBinding()
        {
            tb_idsala.DataBindings.Add(new Binding("Text", dgv_lsttentksala.DataSource,"Id", true, DataSourceUpdateMode.Never));
        }

        void khcBinding()
        {
            tb_idkh.DataBindings.Add(new Binding("Text", dgv_editkh.DataSource, "id", true, DataSourceUpdateMode.Never));
            tb_sdtkh.DataBindings.Add(new Binding("Text", dgv_editkh.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            tb_tenkh.DataBindings.Add(new Binding("Text", dgv_editkh.DataSource, "Tenkh", true, DataSourceUpdateMode.Never));
            tb_emailkh.DataBindings.Add(new Binding("Text", dgv_editkh.DataSource, "email", true, DataSourceUpdateMode.Never));
            cb_rankkh.DataBindings.Add(new Binding("Text", dgv_editkh.DataSource, "idrank", true, DataSourceUpdateMode.Never));
            dpk_ngaysinhkh.DataBindings.Add(new Binding("Value", dgv_editkh.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
        }
                                           
        void nvBinding()
        {
            tb_manv.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "id", true, DataSourceUpdateMode.Never));
            tb_tennv.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "tennv", true, DataSourceUpdateMode.Never));
            tb_sdtnv.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            tb_diachi.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            tb_emailnv.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "email", true, DataSourceUpdateMode.Never));
            tb_chucvu.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "Chucvu", true, DataSourceUpdateMode.Never));
            tb_tk.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "tentk", true, DataSourceUpdateMode.Never));
            tb_mk.DataBindings.Add(new Binding("Text", dgv_lstnv.DataSource, "mk", true, DataSourceUpdateMode.Never));
            chb_Admin.DataBindings.Add(new Binding("Checked", dgv_lstnv.DataSource, "admin", true, DataSourceUpdateMode.Never));
        }

        void loadlstbill(DateTime tungay , DateTime denngay)
        {
            dgv_doanhthu.DataSource = Dbbill.Instance.GetBillListByDate(tungay, denngay);
            //sp_showlstbill
        }

        void loadtotalPrice(DateTime tungay, DateTime denngay)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            float doanhthu= Dbbill.Instance.GettotalPricefromlist(tungay, denngay);
            tb_doanhthu.Text = doanhthu.ToString("c",culture);
        }

        void loadlstFood()
        {
            foodList.DataSource = Dbfood.Instance.GetListFoodAdmin();
        }
        void loadlstcongthuc()
        {
            congthucList.DataSource = Dbcongthuc.Instance.GetListCongthuc();
        }

        void CongthucBinding()
        {
            tb_guide.DataBindings.Add(new Binding("Text", dgv_congthuc.DataSource, "guide", true, DataSourceUpdateMode.Never));
            tb_idfoodupdate.DataBindings.Add(new Binding("Text", dgv_congthuc.DataSource, "idfood", true, DataSourceUpdateMode.Never));
        }

        void FoodBinding()
        {
            tb_namefood.DataBindings.Add(new Binding("Text", dgv_food.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tb_idfood.DataBindings.Add(new Binding("Text", dgv_food.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nm_dongia.DataBindings.Add(new Binding("Value", dgv_food.DataSource, "Price", true, DataSourceUpdateMode.Never));
            chb_oos.DataBindings.Add(new Binding("Checked", dgv_food.DataSource, "Oos", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = Dbcategory.Instance.GetListCategory();
            cb.DisplayMember = "id";
        }

        void ShowCate()
        {
            lv_showcate.Items.Clear();
            List<Category> lstcate = Dbcategory.Instance.GetListCategory();
            foreach (Category item in lstcate)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.ID.ToString());
                lv_showcate.Items.Add(lsvItem);
            }
        }

        void LoadCategoryfind()
        {
            List<Category> listCategory = Dbcategory.Instance.GetListCategory();
            cb_findcate.DataSource = listCategory;
            cb_findcate.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryIDfind(int id)
        {
            List<Food> listFood = Dbfood.Instance.GetFoodByCategoryIDAdmin(id);
            cb_findfood.DataSource = listFood;
            cb_findfood.DisplayMember = "Name";
        }

        #endregion


        #region event



        private void btn_load_Click(object sender, EventArgs e)
        {
            loadlstbill(dp_tungay.Value, dp_dengay.Value);
            loadtotalPrice(dp_tungay.Value, dp_dengay.Value);
        }

        private void tb_idfood_TextChanged(object sender, EventArgs e)
        {
            int id = (int)dgv_food.SelectedCells[0].OwningRow.Cells["IdCate"].Value;
            cb_idcate.SelectedIndex = id - 1;
        }
        private event EventHandler addFood;
        public event EventHandler AddFood
        {
            add { addFood += value; }
            remove { addFood -= value; }
        }

        private event EventHandler editFood;
        public event EventHandler EditFood
        {
            add { editFood += value; }
            remove { editFood -= value; }
        }


        private void btn_addfood_Click(object sender, EventArgs e)
        {
            string name = tb_namefood.Text;
            int categoryID = (cb_idcate.SelectedItem as Category).ID;
            float price = (float)nm_dongia.Value;

            if (Dbfood.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                loadlstFood(); 
                if (addFood != null)
                    addFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }


        private void btn_editfood_Click(object sender, EventArgs e)
        {
            string name = tb_namefood.Text;
            int categoryID = (cb_idcate.SelectedItem as Category).ID;
            float price = (float)nm_dongia.Value;
            int id = Convert.ToInt32(tb_idfood.Text);
            bool Ngungban = chb_oos.Checked;
            int oos;
            if (!Ngungban)
            {
                oos = 0;
            }
            else
            {
                oos = 1;
            }
            if (Dbfood.Instance.UpdateFood(id, name, categoryID, price, oos))
            {
                MessageBox.Show("Sửa món thành công");
                loadlstFood();
                if (editFood != null)
                    editFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            int foodID = (cb_findfood.SelectedItem as Food).ID;
            Dbcongthuc.Instance.GetCongthucs2(foodID);
            loadlstcongthuc();
        }

        private void btn_updatect_Click(object sender, EventArgs e)
        {
            string guide = tb_guide.Text;
            int i =int.Parse(tb_idfoodupdate.Text);
            if (Dbcongthuc.Instance.UpdateCongthuc(guide,i))
            {
                MessageBox.Show("Update thành công");
                loadlstcongthuc();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btn_newkh_Click(object sender, EventArgs e)
        {
            loadlstkh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            khList.DataSource = Dbcustomers.Instance.SearchkhBysdt(tb_search.Text);
        }

        private void btn_editkh_Click(object sender, EventArgs e)
        {
            int sdt = int.Parse(tb_sdtkh.Text);
            string tenkh = tb_tenkh.Text;
            string email = tb_emailkh.Text;
            DateTime snkh=dpk_ngaysinhkh.Value;
            int idrank = (cb_rankkh.SelectedItem as Rank).Id;
            if (Dbcustomers.Instance.updateKh(tenkh, sdt, email, snkh,idrank))
            {
                MessageBox.Show("cập nhập thành công");
                loadlstkh();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btn_capnhatnv_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_manv.Text);
            string tennv = tb_tennv.Text;
            string sdt = tb_sdtnv.Text;
            string diachi = tb_diachi.Text;
            string email = tb_emailnv.Text;
            int idpos = int.Parse(tb_chucvu.Text);
            string tentk = tb_tk.Text;
            string mk = tb_mk.Text;
            bool checkadmin = chb_Admin.Checked;
            int admin;
            if (!checkadmin)
            {
                admin = 0;
            }
            else admin = 1;
            if (Dbstaff.Instance.updatestaff(id, tennv, sdt, diachi, email, idpos, mk, admin))
            {
                MessageBox.Show("cập nhập thành công");
                Loadlistnv();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadlvbangcong();
        }

        private void tb_sdtkh_TextChanged(object sender, EventArgs e)
        {
            //int id = (int)dgv_editkh.SelectedCells[0].OwningRow.Cells["idrank"].Value;
            //cb_rankkh.SelectedIndex = id - 1;
        }

        #endregion

        private void btn_timnv_Click(object sender, EventArgs e)
        {
            nvList.DataSource = Dbstaff.Instance.SearchstaffBysdt(tb_timnv.Text);
        }

        private void btn_loadnv_Click(object sender, EventArgs e)
        {
            Loadlistnv();
        }

        private void btn_addstaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_manv.Text);
            string tennv = tb_tennv.Text;
            string sdt = tb_sdtnv.Text;
            string diachi = tb_diachi.Text;
            string email = tb_emailnv.Text;
            int idpos = int.Parse(tb_chucvu.Text);
            string tentk = tb_tk.Text;
            string mk = tb_mk.Text;
            bool checkadmin = chb_Admin.Checked;
            int admin;
            if (!checkadmin)
            {
                admin = 0;
            }
            else admin = 1;
            if (Dbstaff.Instance.checktentk(tentk))
            {
                if (Dbstaff.Instance.addstaff(tennv, sdt, diachi, email, idpos, tentk, mk, admin))
                {
                    MessageBox.Show("Thêm thành công");
                    Loadlistnv();
                }
                else
                {
                    MessageBox.Show("Có lỗi");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }

        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            if (tb_salah.Text == "")
            {
                MessageBox.Show("Nhap so gio");return;
            }
            if (!Checksogio(tb_salah.Text.Trim())){
                MessageBox.Show("Nhap so va toi da 3 ki tu");return;
            }
            int idstaff = int.Parse(tb_idsala.Text);
            float sogio = float.Parse(tb_salah.Text);
            string query = string.Format("Select luong1h from Position p, Staff s where idpos=p.id and s.id ={0}", idstaff);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            object luong1h = dt.Rows[0][0];
            float finalluong = sogio*(float)Double.Parse(luong1h.ToString());
            if (Dbsala.Instance.editluong(idstaff, finalluong))
            {
                MessageBox.Show("Chấm công thành công!");
                tb_salah.Clear();
                loadlvbangcong();
            }
            else
            {
                MessageBox.Show("Có lỗi!");
            }
        }
    }
}
