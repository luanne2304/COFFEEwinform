namespace Coffee
{
    partial class fHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnexit = new System.Windows.Forms.Button();
            this.btn_adm = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.tp_banhang = new System.Windows.Forms.TabPage();
            this.tb_resultcheck = new System.Windows.Forms.TextBox();
            this.btn_checksdt = new System.Windows.Forms.Button();
            this.cb_khuyenmai = new System.Windows.Forms.ComboBox();
            this.tb_sdtcheck = new System.Windows.Forms.TextBox();
            this.nmadd = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.flwTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lvgoimon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbtongtien = new System.Windows.Forms.TextBox();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.cb_food = new System.Windows.Forms.ComboBox();
            this.tc_home = new System.Windows.Forms.TabControl();
            this.tp_dkikh = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dkikh = new System.Windows.Forms.Button();
            this.dp_ngaysinhkh = new System.Windows.Forms.DateTimePicker();
            this.tb_emailkh = new System.Windows.Forms.TextBox();
            this.tb_sdtkh = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.tp_congthuc = new System.Windows.Forms.TabPage();
            this.tb_loadct = new System.Windows.Forms.TextBox();
            this.dgv_findct = new System.Windows.Forms.DataGridView();
            this.btn_findct = new System.Windows.Forms.Button();
            this.cb_findcate = new System.Windows.Forms.ComboBox();
            this.cb_findfood = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_rfluong = new System.Windows.Forms.Button();
            this.btn_acpsala = new System.Windows.Forms.Button();
            this.tb_luong = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_titlerp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_contentrp = new System.Windows.Forms.TextBox();
            this.btn_submitrp = new System.Windows.Forms.Button();
            this.tp_banhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmadd)).BeginInit();
            this.tc_home.SuspendLayout();
            this.tp_dkikh.SuspendLayout();
            this.tp_congthuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_findct)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(791, 557);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Đăng xuất";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btn_adm
            // 
            this.btn_adm.Location = new System.Drawing.Point(699, 557);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(75, 23);
            this.btn_adm.TabIndex = 4;
            this.btn_adm.Text = "Quản lý";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.btn_adm_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Location = new System.Drawing.Point(41, 19);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(52, 13);
            this.lb_welcome.TabIndex = 5;
            this.lb_welcome.Text = "Welcome";
            // 
            // tp_banhang
            // 
            this.tp_banhang.Controls.Add(this.tb_resultcheck);
            this.tp_banhang.Controls.Add(this.btn_checksdt);
            this.tp_banhang.Controls.Add(this.cb_khuyenmai);
            this.tp_banhang.Controls.Add(this.tb_sdtcheck);
            this.tp_banhang.Controls.Add(this.nmadd);
            this.tp_banhang.Controls.Add(this.btn_add);
            this.tp_banhang.Controls.Add(this.btn_thanhtoan);
            this.tp_banhang.Controls.Add(this.flwTable);
            this.tp_banhang.Controls.Add(this.lvgoimon);
            this.tp_banhang.Controls.Add(this.tbtongtien);
            this.tp_banhang.Controls.Add(this.cb_cate);
            this.tp_banhang.Controls.Add(this.cb_food);
            this.tp_banhang.Location = new System.Drawing.Point(4, 22);
            this.tp_banhang.Name = "tp_banhang";
            this.tp_banhang.Padding = new System.Windows.Forms.Padding(3);
            this.tp_banhang.Size = new System.Drawing.Size(845, 442);
            this.tp_banhang.TabIndex = 1;
            this.tp_banhang.Text = "Bán hàng";
            this.tp_banhang.UseVisualStyleBackColor = true;
            // 
            // tb_resultcheck
            // 
            this.tb_resultcheck.Location = new System.Drawing.Point(440, 412);
            this.tb_resultcheck.Name = "tb_resultcheck";
            this.tb_resultcheck.ReadOnly = true;
            this.tb_resultcheck.Size = new System.Drawing.Size(108, 20);
            this.tb_resultcheck.TabIndex = 17;
            // 
            // btn_checksdt
            // 
            this.btn_checksdt.Location = new System.Drawing.Point(564, 386);
            this.btn_checksdt.Name = "btn_checksdt";
            this.btn_checksdt.Size = new System.Drawing.Size(83, 22);
            this.btn_checksdt.TabIndex = 16;
            this.btn_checksdt.Text = "Check";
            this.btn_checksdt.UseVisualStyleBackColor = true;
            this.btn_checksdt.Click += new System.EventHandler(this.btn_checksdt_Click);
            // 
            // cb_khuyenmai
            // 
            this.cb_khuyenmai.FormattingEnabled = true;
            this.cb_khuyenmai.Location = new System.Drawing.Point(564, 345);
            this.cb_khuyenmai.Name = "cb_khuyenmai";
            this.cb_khuyenmai.Size = new System.Drawing.Size(100, 21);
            this.cb_khuyenmai.TabIndex = 15;
            // 
            // tb_sdtcheck
            // 
            this.tb_sdtcheck.Location = new System.Drawing.Point(440, 386);
            this.tb_sdtcheck.Name = "tb_sdtcheck";
            this.tb_sdtcheck.Size = new System.Drawing.Size(108, 20);
            this.tb_sdtcheck.TabIndex = 14;
            // 
            // nmadd
            // 
            this.nmadd.Location = new System.Drawing.Point(639, 29);
            this.nmadd.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmadd.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nmadd.Name = "nmadd";
            this.nmadd.Size = new System.Drawing.Size(44, 20);
            this.nmadd.TabIndex = 10;
            this.nmadd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(707, 29);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Thêm món";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(678, 341);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(97, 27);
            this.btn_thanhtoan.TabIndex = 13;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // flwTable
            // 
            this.flwTable.AutoScroll = true;
            this.flwTable.Location = new System.Drawing.Point(5, 14);
            this.flwTable.Margin = new System.Windows.Forms.Padding(2);
            this.flwTable.Name = "flwTable";
            this.flwTable.Size = new System.Drawing.Size(415, 405);
            this.flwTable.TabIndex = 2;
            // 
            // lvgoimon
            // 
            this.lvgoimon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvgoimon.GridLines = true;
            this.lvgoimon.HideSelection = false;
            this.lvgoimon.Location = new System.Drawing.Point(440, 79);
            this.lvgoimon.Name = "lvgoimon";
            this.lvgoimon.Size = new System.Drawing.Size(342, 256);
            this.lvgoimon.TabIndex = 12;
            this.lvgoimon.UseCompatibleStateImageBehavior = false;
            this.lvgoimon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // tbtongtien
            // 
            this.tbtongtien.Location = new System.Drawing.Point(440, 345);
            this.tbtongtien.Name = "tbtongtien";
            this.tbtongtien.ReadOnly = true;
            this.tbtongtien.Size = new System.Drawing.Size(100, 20);
            this.tbtongtien.TabIndex = 7;
            this.tbtongtien.Text = "0";
            // 
            // cb_cate
            // 
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(440, 52);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(166, 21);
            this.cb_cate.TabIndex = 9;
            this.cb_cate.SelectedIndexChanged += new System.EventHandler(this.cb_cate_SelectedIndexChanged);
            // 
            // cb_food
            // 
            this.cb_food.FormattingEnabled = true;
            this.cb_food.Location = new System.Drawing.Point(440, 16);
            this.cb_food.Name = "cb_food";
            this.cb_food.Size = new System.Drawing.Size(166, 21);
            this.cb_food.TabIndex = 8;
            // 
            // tc_home
            // 
            this.tc_home.Controls.Add(this.tp_banhang);
            this.tc_home.Controls.Add(this.tp_dkikh);
            this.tc_home.Controls.Add(this.tp_congthuc);
            this.tc_home.Controls.Add(this.tabPage1);
            this.tc_home.Controls.Add(this.tabPage2);
            this.tc_home.Location = new System.Drawing.Point(17, 47);
            this.tc_home.Name = "tc_home";
            this.tc_home.SelectedIndex = 0;
            this.tc_home.Size = new System.Drawing.Size(853, 468);
            this.tc_home.TabIndex = 14;
            // 
            // tp_dkikh
            // 
            this.tp_dkikh.Controls.Add(this.label4);
            this.tp_dkikh.Controls.Add(this.label3);
            this.tp_dkikh.Controls.Add(this.label2);
            this.tp_dkikh.Controls.Add(this.label1);
            this.tp_dkikh.Controls.Add(this.btn_dkikh);
            this.tp_dkikh.Controls.Add(this.dp_ngaysinhkh);
            this.tp_dkikh.Controls.Add(this.tb_emailkh);
            this.tp_dkikh.Controls.Add(this.tb_sdtkh);
            this.tp_dkikh.Controls.Add(this.tb_tenkh);
            this.tp_dkikh.Location = new System.Drawing.Point(4, 22);
            this.tp_dkikh.Name = "tp_dkikh";
            this.tp_dkikh.Padding = new System.Windows.Forms.Padding(3);
            this.tp_dkikh.Size = new System.Drawing.Size(845, 442);
            this.tp_dkikh.TabIndex = 2;
            this.tp_dkikh.Text = "Đăng kí khách hàng";
            this.tp_dkikh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập SDT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập tên:";
            // 
            // btn_dkikh
            // 
            this.btn_dkikh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dkikh.Location = new System.Drawing.Point(359, 308);
            this.btn_dkikh.Name = "btn_dkikh";
            this.btn_dkikh.Size = new System.Drawing.Size(112, 44);
            this.btn_dkikh.TabIndex = 4;
            this.btn_dkikh.Text = "Đăng kí";
            this.btn_dkikh.UseVisualStyleBackColor = true;
            this.btn_dkikh.Click += new System.EventHandler(this.btn_dkikh_Click);
            // 
            // dp_ngaysinhkh
            // 
            this.dp_ngaysinhkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ngaysinhkh.Location = new System.Drawing.Point(297, 246);
            this.dp_ngaysinhkh.Name = "dp_ngaysinhkh";
            this.dp_ngaysinhkh.Size = new System.Drawing.Size(363, 31);
            this.dp_ngaysinhkh.TabIndex = 3;
            // 
            // tb_emailkh
            // 
            this.tb_emailkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_emailkh.Location = new System.Drawing.Point(297, 197);
            this.tb_emailkh.Name = "tb_emailkh";
            this.tb_emailkh.Size = new System.Drawing.Size(363, 31);
            this.tb_emailkh.TabIndex = 2;
            // 
            // tb_sdtkh
            // 
            this.tb_sdtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdtkh.Location = new System.Drawing.Point(297, 136);
            this.tb_sdtkh.Name = "tb_sdtkh";
            this.tb_sdtkh.Size = new System.Drawing.Size(363, 31);
            this.tb_sdtkh.TabIndex = 1;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenkh.Location = new System.Drawing.Point(297, 85);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(363, 31);
            this.tb_tenkh.TabIndex = 0;
            // 
            // tp_congthuc
            // 
            this.tp_congthuc.Controls.Add(this.tb_loadct);
            this.tp_congthuc.Controls.Add(this.dgv_findct);
            this.tp_congthuc.Controls.Add(this.btn_findct);
            this.tp_congthuc.Controls.Add(this.cb_findcate);
            this.tp_congthuc.Controls.Add(this.cb_findfood);
            this.tp_congthuc.Location = new System.Drawing.Point(4, 22);
            this.tp_congthuc.Name = "tp_congthuc";
            this.tp_congthuc.Padding = new System.Windows.Forms.Padding(3);
            this.tp_congthuc.Size = new System.Drawing.Size(845, 442);
            this.tp_congthuc.TabIndex = 3;
            this.tp_congthuc.Text = "Công thức";
            this.tp_congthuc.UseVisualStyleBackColor = true;
            // 
            // tb_loadct
            // 
            this.tb_loadct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loadct.Location = new System.Drawing.Point(23, 170);
            this.tb_loadct.Multiline = true;
            this.tb_loadct.Name = "tb_loadct";
            this.tb_loadct.ReadOnly = true;
            this.tb_loadct.Size = new System.Drawing.Size(402, 233);
            this.tb_loadct.TabIndex = 13;
            // 
            // dgv_findct
            // 
            this.dgv_findct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_findct.Location = new System.Drawing.Point(23, 21);
            this.dgv_findct.Name = "dgv_findct";
            this.dgv_findct.Size = new System.Drawing.Size(402, 99);
            this.dgv_findct.TabIndex = 12;
            // 
            // btn_findct
            // 
            this.btn_findct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findct.Location = new System.Drawing.Point(651, 141);
            this.btn_findct.Name = "btn_findct";
            this.btn_findct.Size = new System.Drawing.Size(90, 53);
            this.btn_findct.TabIndex = 11;
            this.btn_findct.Text = "Tìm";
            this.btn_findct.UseVisualStyleBackColor = true;
            this.btn_findct.Click += new System.EventHandler(this.btn_findct_Click);
            // 
            // cb_findcate
            // 
            this.cb_findcate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_findcate.FormattingEnabled = true;
            this.cb_findcate.Location = new System.Drawing.Point(455, 120);
            this.cb_findcate.Name = "cb_findcate";
            this.cb_findcate.Size = new System.Drawing.Size(166, 33);
            this.cb_findcate.TabIndex = 10;
            this.cb_findcate.SelectedIndexChanged += new System.EventHandler(this.cb_findcate_SelectedIndexChanged);
            // 
            // cb_findfood
            // 
            this.cb_findfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_findfood.FormattingEnabled = true;
            this.cb_findfood.Location = new System.Drawing.Point(455, 188);
            this.cb_findfood.Name = "cb_findfood";
            this.cb_findfood.Size = new System.Drawing.Size(166, 33);
            this.cb_findfood.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_rfluong);
            this.tabPage1.Controls.Add(this.btn_acpsala);
            this.tabPage1.Controls.Add(this.tb_luong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 442);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Lương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_rfluong
            // 
            this.btn_rfluong.Location = new System.Drawing.Point(175, 261);
            this.btn_rfluong.Name = "btn_rfluong";
            this.btn_rfluong.Size = new System.Drawing.Size(197, 87);
            this.btn_rfluong.TabIndex = 2;
            this.btn_rfluong.Text = "Làm mới";
            this.btn_rfluong.UseVisualStyleBackColor = true;
            this.btn_rfluong.Click += new System.EventHandler(this.btn_rfluong_Click);
            // 
            // btn_acpsala
            // 
            this.btn_acpsala.Location = new System.Drawing.Point(486, 262);
            this.btn_acpsala.Name = "btn_acpsala";
            this.btn_acpsala.Size = new System.Drawing.Size(179, 86);
            this.btn_acpsala.TabIndex = 1;
            this.btn_acpsala.Text = "Nhận lương";
            this.btn_acpsala.UseVisualStyleBackColor = true;
            this.btn_acpsala.Click += new System.EventHandler(this.btn_acpsala_Click);
            // 
            // tb_luong
            // 
            this.tb_luong.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_luong.Location = new System.Drawing.Point(202, 121);
            this.tb_luong.Name = "tb_luong";
            this.tb_luong.Size = new System.Drawing.Size(425, 63);
            this.tb_luong.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_submitrp);
            this.tabPage2.Controls.Add(this.tb_contentrp);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_titlerp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 442);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Báo cáo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_titlerp
            // 
            this.tb_titlerp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_titlerp.Location = new System.Drawing.Point(205, 63);
            this.tb_titlerp.Name = "tb_titlerp";
            this.tb_titlerp.Size = new System.Drawing.Size(428, 31);
            this.tb_titlerp.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiêu đề:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nội dung:";
            // 
            // tb_contentrp
            // 
            this.tb_contentrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contentrp.Location = new System.Drawing.Point(205, 124);
            this.tb_contentrp.Multiline = true;
            this.tb_contentrp.Name = "tb_contentrp";
            this.tb_contentrp.Size = new System.Drawing.Size(428, 255);
            this.tb_contentrp.TabIndex = 8;
            // 
            // btn_submitrp
            // 
            this.btn_submitrp.Location = new System.Drawing.Point(678, 333);
            this.btn_submitrp.Name = "btn_submitrp";
            this.btn_submitrp.Size = new System.Drawing.Size(98, 46);
            this.btn_submitrp.TabIndex = 9;
            this.btn_submitrp.Text = "Báo cáo";
            this.btn_submitrp.UseVisualStyleBackColor = true;
            this.btn_submitrp.Click += new System.EventHandler(this.btn_submitrp_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 594);
            this.Controls.Add(this.tc_home);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn_adm);
            this.Name = "fHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.tp_banhang.ResumeLayout(false);
            this.tp_banhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmadd)).EndInit();
            this.tc_home.ResumeLayout(false);
            this.tp_dkikh.ResumeLayout(false);
            this.tp_dkikh.PerformLayout();
            this.tp_congthuc.ResumeLayout(false);
            this.tp_congthuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_findct)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btn_adm;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.TabPage tp_banhang;
        private System.Windows.Forms.NumericUpDown nmadd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.FlowLayoutPanel flwTable;
        private System.Windows.Forms.ListView lvgoimon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbtongtien;
        private System.Windows.Forms.ComboBox cb_cate;
        private System.Windows.Forms.ComboBox cb_food;
        private System.Windows.Forms.TabControl tc_home;
        private System.Windows.Forms.TabPage tp_dkikh;
        private System.Windows.Forms.Button btn_dkikh;
        private System.Windows.Forms.DateTimePicker dp_ngaysinhkh;
        private System.Windows.Forms.TextBox tb_emailkh;
        private System.Windows.Forms.TextBox tb_sdtkh;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.Button btn_checksdt;
        private System.Windows.Forms.ComboBox cb_khuyenmai;
        private System.Windows.Forms.TextBox tb_sdtcheck;
        private System.Windows.Forms.TextBox tb_resultcheck;
        private System.Windows.Forms.TabPage tp_congthuc;
        private System.Windows.Forms.Button btn_findct;
        private System.Windows.Forms.ComboBox cb_findcate;
        private System.Windows.Forms.ComboBox cb_findfood;
        private System.Windows.Forms.TextBox tb_loadct;
        private System.Windows.Forms.DataGridView dgv_findct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_rfluong;
        private System.Windows.Forms.Button btn_acpsala;
        private System.Windows.Forms.TextBox tb_luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_contentrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_titlerp;
        private System.Windows.Forms.Button btn_submitrp;
    }
}