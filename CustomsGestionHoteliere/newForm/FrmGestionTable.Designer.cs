﻿namespace CustomsGestionHoteliere.newForm
{
    partial class FrmGestionTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.addUtilisateur = new System.Windows.Forms.TabPage();
            this.txtmontantTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.txtidFacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuCustomDataGrid4 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.easyGestDataSet = new CustomsGestionHoteliere.EasyGestDataSet();
            this.tABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLESTableAdapter = new CustomsGestionHoteliere.EasyGestDataSetTableAdapters.TABLESTableAdapter();
            this.idTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTableidTypeTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.addUtilisateur.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.addUtilisateur);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 51);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(847, 514);
            this.materialTabControl1.TabIndex = 17;
            // 
            // addUtilisateur
            // 
            this.addUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.addUtilisateur.Controls.Add(this.gunaLabel2);
            this.addUtilisateur.Controls.Add(this.guna2ComboBox3);
            this.addUtilisateur.Controls.Add(this.txtmontantTotal);
            this.addUtilisateur.Controls.Add(this.guna2Button16);
            this.addUtilisateur.Controls.Add(this.txtidFacture);
            this.addUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.addUtilisateur.Name = "addUtilisateur";
            this.addUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.addUtilisateur.Size = new System.Drawing.Size(839, 488);
            this.addUtilisateur.TabIndex = 0;
            this.addUtilisateur.Text = "Ajouter Table";
            // 
            // txtmontantTotal
            // 
            this.txtmontantTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.txtmontantTotal.BorderRadius = 16;
            this.txtmontantTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontantTotal.DefaultText = "Nombre de place";
            this.txtmontantTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontantTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontantTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontantTotal.DisabledState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontantTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontantTotal.FocusedState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontantTotal.HoverState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.Location = new System.Drawing.Point(398, 90);
            this.txtmontantTotal.Name = "txtmontantTotal";
            this.txtmontantTotal.PasswordChar = '\0';
            this.txtmontantTotal.PlaceholderText = "";
            this.txtmontantTotal.SelectedText = "";
            this.txtmontantTotal.ShadowDecoration.Parent = this.txtmontantTotal;
            this.txtmontantTotal.Size = new System.Drawing.Size(200, 36);
            this.txtmontantTotal.TabIndex = 1;
            // 
            // guna2Button16
            // 
            this.guna2Button16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.BorderRadius = 19;
            this.guna2Button16.BorderThickness = 2;
            this.guna2Button16.CheckedState.Parent = this.guna2Button16;
            this.guna2Button16.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.CustomImages.Parent = this.guna2Button16;
            this.guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.Parent = this.guna2Button16;
            this.guna2Button16.Location = new System.Drawing.Point(281, 223);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(188, 45);
            this.guna2Button16.TabIndex = 3;
            this.guna2Button16.Text = "Enregistrer";
            // 
            // txtidFacture
            // 
            this.txtidFacture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.txtidFacture.BorderRadius = 16;
            this.txtidFacture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidFacture.DefaultText = "Id Table";
            this.txtidFacture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidFacture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidFacture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidFacture.DisabledState.Parent = this.txtidFacture;
            this.txtidFacture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidFacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidFacture.FocusedState.Parent = this.txtidFacture;
            this.txtidFacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidFacture.HoverState.Parent = this.txtidFacture;
            this.txtidFacture.Location = new System.Drawing.Point(158, 90);
            this.txtidFacture.Name = "txtidFacture";
            this.txtidFacture.PasswordChar = '\0';
            this.txtidFacture.PlaceholderText = "";
            this.txtidFacture.SelectedText = "";
            this.txtidFacture.ShadowDecoration.Parent = this.txtidFacture;
            this.txtidFacture.Size = new System.Drawing.Size(200, 36);
            this.txtidFacture.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.tabPage2.Controls.Add(this.guna2TextBox1);
            this.tabPage2.Controls.Add(this.guna2GradientButton4);
            this.tabPage2.Controls.Add(this.bunifuCustomDataGrid4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste Table";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = " Recherche";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(413, 27);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 10;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(257, 45);
            this.guna2TextBox1.TabIndex = 16;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 16;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(676, 27);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton4.TabIndex = 14;
            this.guna2GradientButton4.Text = "Rechercher";
            // 
            // bunifuCustomDataGrid4
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid4.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTableDataGridViewTextBoxColumn,
            this.nombrePlaceDataGridViewTextBoxColumn,
            this.typeTableidTypeTableDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid4.DataSource = this.tABLESBindingSource;
            this.bunifuCustomDataGrid4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid4.DoubleBuffered = true;
            this.bunifuCustomDataGrid4.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.bunifuCustomDataGrid4.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.bunifuCustomDataGrid4.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.Location = new System.Drawing.Point(3, 104);
            this.bunifuCustomDataGrid4.Name = "bunifuCustomDataGrid4";
            this.bunifuCustomDataGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid4.Size = new System.Drawing.Size(833, 381);
            this.bunifuCustomDataGrid4.TabIndex = 13;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Liste Table";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(190, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(178, 35);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "Liste Table";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ajouter Table";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(172, 30);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Ajouter Table";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.slider.Location = new System.Drawing.Point(12, 35);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(151, 10);
            this.slider.TabIndex = 15;
            this.slider.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(278, 149);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel2.TabIndex = 90;
            this.gunaLabel2.Text = "idTypeTable";
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2ComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.guna2ComboBox3.BorderRadius = 15;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox3.FocusedState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.FormattingEnabled = true;
            this.guna2ComboBox3.HoverState.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.guna2ComboBox3.ItemsAppearance.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Location = new System.Drawing.Point(281, 167);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.ShadowDecoration.Parent = this.guna2ComboBox3;
            this.guna2ComboBox3.Size = new System.Drawing.Size(188, 36);
            this.guna2ComboBox3.TabIndex = 89;
            // 
            // easyGestDataSet
            // 
            this.easyGestDataSet.DataSetName = "EasyGestDataSet";
            this.easyGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tABLESBindingSource
            // 
            this.tABLESBindingSource.DataMember = "TABLES";
            this.tABLESBindingSource.DataSource = this.easyGestDataSet;
            // 
            // tABLESTableAdapter
            // 
            this.tABLESTableAdapter.ClearBeforeFill = true;
            // 
            // idTableDataGridViewTextBoxColumn
            // 
            this.idTableDataGridViewTextBoxColumn.DataPropertyName = "idTable";
            this.idTableDataGridViewTextBoxColumn.HeaderText = "idTable";
            this.idTableDataGridViewTextBoxColumn.Name = "idTableDataGridViewTextBoxColumn";
            // 
            // nombrePlaceDataGridViewTextBoxColumn
            // 
            this.nombrePlaceDataGridViewTextBoxColumn.DataPropertyName = "nombrePlace";
            this.nombrePlaceDataGridViewTextBoxColumn.HeaderText = "Nombre Place";
            this.nombrePlaceDataGridViewTextBoxColumn.Name = "nombrePlaceDataGridViewTextBoxColumn";
            // 
            // typeTableidTypeTableDataGridViewTextBoxColumn
            // 
            this.typeTableidTypeTableDataGridViewTextBoxColumn.DataPropertyName = "TypeTableidTypeTable";
            this.typeTableidTypeTableDataGridViewTextBoxColumn.HeaderText = "idTypeTable";
            this.typeTableidTypeTableDataGridViewTextBoxColumn.Name = "typeTableidTypeTableDataGridViewTextBoxColumn";
            // 
            // FrmGestionTable
            // 
            this.AcceptButton = this.guna2GradientButton4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factures";
            this.Load += new System.EventHandler(this.FrmGestionTable_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.addUtilisateur.ResumeLayout(false);
            this.addUtilisateur.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage addUtilisateur;
        private Guna.UI2.WinForms.Guna2TextBox txtmontantTotal;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2TextBox txtidFacture;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private EasyGestDataSet easyGestDataSet;
        private System.Windows.Forms.BindingSource tABLESBindingSource;
        private EasyGestDataSetTableAdapters.TABLESTableAdapter tABLESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTableidTypeTableDataGridViewTextBoxColumn;
    }
}