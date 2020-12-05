﻿
namespace CustomsGestionHoteliere.newForm
{
    partial class FrmGestionFactures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionFactures));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.addUtilisateur = new System.Windows.Forms.TabPage();
            this.dateFacturation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtmontantTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.txtidFacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuCustomDataGrid4 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNomPlat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtQuantiter = new Guna.UI2.WinForms.Guna2TextBox();
            this.easyGestDataSet10 = new CustomsGestionHoteliere.EasyGestDataSet10();
            this.fACTURESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURESTableAdapter = new CustomsGestionHoteliere.EasyGestDataSet10TableAdapters.FACTURESTableAdapter();
            this.idFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFacturationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.slider = new System.Windows.Forms.PictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.materialTabControl1.SuspendLayout();
            this.addUtilisateur.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
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
            this.materialTabControl1.TabIndex = 0;
            // 
            // addUtilisateur
            // 
            this.addUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.addUtilisateur.Controls.Add(this.txtQuantiter);
            this.addUtilisateur.Controls.Add(this.txtNomPlat);
            this.addUtilisateur.Controls.Add(this.dateFacturation);
            this.addUtilisateur.Controls.Add(this.txtmontantTotal);
            this.addUtilisateur.Controls.Add(this.guna2Button16);
            this.addUtilisateur.Controls.Add(this.txtidFacture);
            this.addUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.addUtilisateur.Name = "addUtilisateur";
            this.addUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.addUtilisateur.Size = new System.Drawing.Size(839, 488);
            this.addUtilisateur.TabIndex = 0;
            this.addUtilisateur.Text = "Ajouter Facture";
            this.addUtilisateur.Click += new System.EventHandler(this.addUtilisateur_Click);
            // 
            // dateFacturation
            // 
            this.dateFacturation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.dateFacturation.BorderRadius = 16;
            this.dateFacturation.BorderThickness = 1;
            this.dateFacturation.CheckedState.Parent = this.dateFacturation;
            this.dateFacturation.FillColor = System.Drawing.Color.White;
            this.dateFacturation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateFacturation.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFacturation.HoverState.Parent = this.dateFacturation;
            this.dateFacturation.Location = new System.Drawing.Point(423, 105);
            this.dateFacturation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFacturation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFacturation.Name = "dateFacturation";
            this.dateFacturation.ShadowDecoration.Parent = this.dateFacturation;
            this.dateFacturation.Size = new System.Drawing.Size(211, 36);
            this.dateFacturation.TabIndex = 1;
            this.dateFacturation.Value = new System.DateTime(2020, 8, 29, 0, 0, 0, 0);
            // 
            // txtmontantTotal
            // 
            this.txtmontantTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.txtmontantTotal.BorderRadius = 16;
            this.txtmontantTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontantTotal.DefaultText = "Montant Total";
            this.txtmontantTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontantTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontantTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontantTotal.DisabledState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontantTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontantTotal.FocusedState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontantTotal.HoverState.Parent = this.txtmontantTotal;
            this.txtmontantTotal.Location = new System.Drawing.Point(194, 171);
            this.txtmontantTotal.Name = "txtmontantTotal";
            this.txtmontantTotal.PasswordChar = '\0';
            this.txtmontantTotal.PlaceholderText = "";
            this.txtmontantTotal.SelectedText = "";
            this.txtmontantTotal.SelectionStart = 13;
            this.txtmontantTotal.ShadowDecoration.Parent = this.txtmontantTotal;
            this.txtmontantTotal.Size = new System.Drawing.Size(200, 36);
            this.txtmontantTotal.TabIndex = 2;
            // 
            // guna2Button16
            // 
            this.guna2Button16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.BorderRadius = 19;
            this.guna2Button16.BorderThickness = 2;
            this.guna2Button16.CheckedState.Parent = this.guna2Button16;
            this.guna2Button16.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.CustomImages.Parent = this.guna2Button16;
            this.guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.Parent = this.guna2Button16;
            this.guna2Button16.Location = new System.Drawing.Point(294, 337);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(188, 45);
            this.guna2Button16.TabIndex = 6;
            this.guna2Button16.Text = "Enregistrer";
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // txtidFacture
            // 
            this.txtidFacture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.txtidFacture.BorderRadius = 16;
            this.txtidFacture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidFacture.DefaultText = "Id Facture";
            this.txtidFacture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidFacture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidFacture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidFacture.DisabledState.Parent = this.txtidFacture;
            this.txtidFacture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidFacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidFacture.FocusedState.Parent = this.txtidFacture;
            this.txtidFacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidFacture.HoverState.Parent = this.txtidFacture;
            this.txtidFacture.Location = new System.Drawing.Point(194, 105);
            this.txtidFacture.Name = "txtidFacture";
            this.txtidFacture.PasswordChar = '\0';
            this.txtidFacture.PlaceholderText = "";
            this.txtidFacture.SelectedText = "";
            this.txtidFacture.SelectionStart = 10;
            this.txtidFacture.ShadowDecoration.Parent = this.txtidFacture;
            this.txtidFacture.Size = new System.Drawing.Size(200, 36);
            this.txtidFacture.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.tabPage2.Controls.Add(this.guna2GradientButton3);
            this.tabPage2.Controls.Add(this.guna2GradientButton2);
            this.tabPage2.Controls.Add(this.guna2GradientButton1);
            this.tabPage2.Controls.Add(this.guna2GradientButton4);
            this.tabPage2.Controls.Add(this.bunifuCustomDataGrid4);
            this.tabPage2.Controls.Add(this.guna2TextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "liste Facture";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 16;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.DarkGoldenrod;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(724, 6);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton4.TabIndex = 14;
            this.guna2GradientButton4.Text = "Rechercher";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactureDataGridViewTextBoxColumn,
            this.dataFacturationDataGridViewTextBoxColumn,
            this.montantTotalDataGridViewTextBoxColumn,
            this.nomPlatDataGridViewTextBoxColumn,
            this.quantiterDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid4.DataSource = this.fACTURESBindingSource;
            this.bunifuCustomDataGrid4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid4.DoubleBuffered = true;
            this.bunifuCustomDataGrid4.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid4.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
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
            this.bunifuFlatButton2.ButtonText = "Liste Facture";
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
            this.bunifuFlatButton2.Text = "Liste Facture";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ajouter Facture";
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
            this.bunifuFlatButton1.Text = "Ajouter Facture";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtNomPlat
            // 
            this.txtNomPlat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.txtNomPlat.BorderRadius = 16;
            this.txtNomPlat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPlat.DefaultText = "Nom Plat";
            this.txtNomPlat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomPlat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomPlat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPlat.DisabledState.Parent = this.txtNomPlat;
            this.txtNomPlat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPlat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPlat.FocusedState.Parent = this.txtNomPlat;
            this.txtNomPlat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPlat.HoverState.Parent = this.txtNomPlat;
            this.txtNomPlat.Location = new System.Drawing.Point(426, 171);
            this.txtNomPlat.Name = "txtNomPlat";
            this.txtNomPlat.PasswordChar = '\0';
            this.txtNomPlat.PlaceholderText = "";
            this.txtNomPlat.SelectedText = "";
            this.txtNomPlat.ShadowDecoration.Parent = this.txtNomPlat;
            this.txtNomPlat.Size = new System.Drawing.Size(200, 36);
            this.txtNomPlat.TabIndex = 81;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 16;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DarkGoldenrod;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(135, 53);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton1.TabIndex = 17;
            this.guna2GradientButton1.Text = "Refresh";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 16;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.DarkGoldenrod;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(6, 53);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton2.TabIndex = 18;
            this.guna2GradientButton2.Text = "Update";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // txtQuantiter
            // 
            this.txtQuantiter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.txtQuantiter.BorderRadius = 16;
            this.txtQuantiter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiter.DefaultText = "Quantiter";
            this.txtQuantiter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantiter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantiter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiter.DisabledState.Parent = this.txtQuantiter;
            this.txtQuantiter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantiter.FocusedState.Parent = this.txtQuantiter;
            this.txtQuantiter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantiter.HoverState.Parent = this.txtQuantiter;
            this.txtQuantiter.Location = new System.Drawing.Point(370, 226);
            this.txtQuantiter.Name = "txtQuantiter";
            this.txtQuantiter.PasswordChar = '\0';
            this.txtQuantiter.PlaceholderText = "";
            this.txtQuantiter.SelectedText = "";
            this.txtQuantiter.ShadowDecoration.Parent = this.txtQuantiter;
            this.txtQuantiter.Size = new System.Drawing.Size(200, 36);
            this.txtQuantiter.TabIndex = 82;
            this.txtQuantiter.TextChanged += new System.EventHandler(this.txtQuantiter_TextChanged);
            // 
            // easyGestDataSet10
            // 
            this.easyGestDataSet10.DataSetName = "EasyGestDataSet10";
            this.easyGestDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURESBindingSource
            // 
            this.fACTURESBindingSource.DataMember = "FACTURES";
            this.fACTURESBindingSource.DataSource = this.easyGestDataSet10;
            // 
            // fACTURESTableAdapter
            // 
            this.fACTURESTableAdapter.ClearBeforeFill = true;
            // 
            // idFactureDataGridViewTextBoxColumn
            // 
            this.idFactureDataGridViewTextBoxColumn.DataPropertyName = "idFacture";
            this.idFactureDataGridViewTextBoxColumn.HeaderText = "idFacture";
            this.idFactureDataGridViewTextBoxColumn.Name = "idFactureDataGridViewTextBoxColumn";
            // 
            // dataFacturationDataGridViewTextBoxColumn
            // 
            this.dataFacturationDataGridViewTextBoxColumn.DataPropertyName = "dataFacturation";
            this.dataFacturationDataGridViewTextBoxColumn.HeaderText = "dataFacturation";
            this.dataFacturationDataGridViewTextBoxColumn.Name = "dataFacturationDataGridViewTextBoxColumn";
            // 
            // montantTotalDataGridViewTextBoxColumn
            // 
            this.montantTotalDataGridViewTextBoxColumn.DataPropertyName = "montantTotal";
            this.montantTotalDataGridViewTextBoxColumn.HeaderText = "montantTotal";
            this.montantTotalDataGridViewTextBoxColumn.Name = "montantTotalDataGridViewTextBoxColumn";
            // 
            // nomPlatDataGridViewTextBoxColumn
            // 
            this.nomPlatDataGridViewTextBoxColumn.DataPropertyName = "nomPlat";
            this.nomPlatDataGridViewTextBoxColumn.HeaderText = "nomPlat";
            this.nomPlatDataGridViewTextBoxColumn.Name = "nomPlatDataGridViewTextBoxColumn";
            // 
            // quantiterDataGridViewTextBoxColumn
            // 
            this.quantiterDataGridViewTextBoxColumn.DataPropertyName = "quantiter";
            this.quantiterDataGridViewTextBoxColumn.HeaderText = "quantiter";
            this.quantiterDataGridViewTextBoxColumn.Name = "quantiterDataGridViewTextBoxColumn";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 16;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.DarkGoldenrod;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(270, 53);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton3.TabIndex = 19;
            this.guna2GradientButton3.Text = "Invoice Print";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
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
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(461, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 10;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(257, 45);
            this.guna2TextBox1.TabIndex = 16;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.slider.Location = new System.Drawing.Point(16, 35);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(106, 10);
            this.slider.TabIndex = 15;
            this.slider.TabStop = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.White;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::CustomsGestionHoteliere.Properties.Resources.delete_96px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(823, 7);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(36, 26);
            this.gunaImageButton1.TabIndex = 17;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // FrmGestionFactures
            // 
            this.AcceptButton = this.guna2GradientButton4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionFactures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factures";
            this.Load += new System.EventHandler(this.FrmGestionFactures_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.addUtilisateur.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFacturation;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomPlat;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantiter;
        private EasyGestDataSet10 easyGestDataSet10;
        private System.Windows.Forms.BindingSource fACTURESBindingSource;
        private EasyGestDataSet10TableAdapters.FACTURESTableAdapter fACTURESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFacturationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiterDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}