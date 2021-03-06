﻿using System.Windows.Forms;

namespace AutoOrderSystem.UI
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblCapation = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOrder = new CCWin.SkinControl.SkinDataGridView();
            this.ColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrderRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrderDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuDgvOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCancelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOrderItem = new CCWin.SkinControl.SkinDataGridView();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddOrder = new System.Windows.Forms.ToolStripButton();
            this.btnDelOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnERPOrder = new System.Windows.Forms.ToolStripButton();
            this.btnExcelOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrderPreview = new System.Windows.Forms.ToolStripButton();
            this.btnSubmitOrder = new System.Windows.Forms.ToolStripButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_ServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_LoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Flicker = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_TimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerUIupdate = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.menuDgvOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlTop.Controls.Add(this.pnlLogo);
            this.pnlTop.Controls.Add(this.lblCapation);
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.btnMax);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1284, 60);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlCaption_MouseDoubleClick);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCaption_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCaption_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCaption_MouseUp);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::AutoOrderSystem.UI.Properties.Resources.ArtismanLogo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Location = new System.Drawing.Point(4, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 54);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblCapation
            // 
            this.lblCapation.AutoSize = true;
            this.lblCapation.Font = new System.Drawing.Font("新宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCapation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCapation.Location = new System.Drawing.Point(245, 13);
            this.lblCapation.Name = "lblCapation";
            this.lblCapation.Size = new System.Drawing.Size(198, 33);
            this.lblCapation.TabIndex = 3;
            this.lblCapation.Text = "订 单 系 统";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::AutoOrderSystem.UI.Properties.Resources.Min;
            this.btnMin.Location = new System.Drawing.Point(1167, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 33);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::AutoOrderSystem.UI.Properties.Resources.Max;
            this.btnMax.Location = new System.Drawing.Point(1205, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(38, 33);
            this.btnMax.TabIndex = 0;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AutoOrderSystem.UI.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1243, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Controls.Add(this.toolStrip1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1284, 535);
            this.pnlMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrderItem);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 496);
            this.splitContainer1.SplitterDistance = 751;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrder.ColumnFont = null;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelected,
            this.ColOrderNo,
            this.ColCustomerName,
            this.ColCustomerPhone,
            this.ColCustomerAddress,
            this.ColOrderDate,
            this.ColDeliveryDate,
            this.ColOrderRemarks,
            this.ColOrderDetail});
            this.dgvOrder.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrder.ContextMenuStrip = this.menuDgvOrder;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvOrder.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvOrder.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(751, 496);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.TitleBack = null;
            this.dgvOrder.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvOrder.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // ColSelected
            // 
            this.ColSelected.HeaderText = "选中";
            this.ColSelected.Name = "ColSelected";
            this.ColSelected.ReadOnly = true;
            // 
            // ColOrderNo
            // 
            this.ColOrderNo.HeaderText = "订单编号";
            this.ColOrderNo.Name = "ColOrderNo";
            this.ColOrderNo.ReadOnly = true;
            // 
            // ColCustomerName
            // 
            this.ColCustomerName.HeaderText = "客户名称";
            this.ColCustomerName.Name = "ColCustomerName";
            this.ColCustomerName.ReadOnly = true;
            // 
            // ColCustomerPhone
            // 
            this.ColCustomerPhone.HeaderText = "客户电话";
            this.ColCustomerPhone.Name = "ColCustomerPhone";
            this.ColCustomerPhone.ReadOnly = true;
            // 
            // ColCustomerAddress
            // 
            this.ColCustomerAddress.HeaderText = "客户地址";
            this.ColCustomerAddress.Name = "ColCustomerAddress";
            this.ColCustomerAddress.ReadOnly = true;
            // 
            // ColOrderDate
            // 
            this.ColOrderDate.HeaderText = "下单日期";
            this.ColOrderDate.Name = "ColOrderDate";
            this.ColOrderDate.ReadOnly = true;
            // 
            // ColDeliveryDate
            // 
            this.ColDeliveryDate.HeaderText = "交付日期";
            this.ColDeliveryDate.Name = "ColDeliveryDate";
            this.ColDeliveryDate.ReadOnly = true;
            // 
            // ColOrderRemarks
            // 
            this.ColOrderRemarks.HeaderText = "备注信息";
            this.ColOrderRemarks.Name = "ColOrderRemarks";
            this.ColOrderRemarks.ReadOnly = true;
            // 
            // ColOrderDetail
            // 
            this.ColOrderDetail.HeaderText = "操作";
            this.ColOrderDetail.Name = "ColOrderDetail";
            this.ColOrderDetail.ReadOnly = true;
            // 
            // menuDgvOrder
            // 
            this.menuDgvOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectAll,
            this.menuItemCancelAll});
            this.menuDgvOrder.Name = "menuDgvOrder";
            this.menuDgvOrder.Size = new System.Drawing.Size(99, 48);
            // 
            // menuItemSelectAll
            // 
            this.menuItemSelectAll.Name = "menuItemSelectAll";
            this.menuItemSelectAll.Size = new System.Drawing.Size(98, 22);
            this.menuItemSelectAll.Text = "全选";
            this.menuItemSelectAll.Click += new System.EventHandler(this.menuItemSelectAll_Click);
            // 
            // menuItemCancelAll
            // 
            this.menuItemCancelAll.Name = "menuItemCancelAll";
            this.menuItemCancelAll.Size = new System.Drawing.Size(98, 22);
            this.menuItemCancelAll.Text = "取消";
            this.menuItemCancelAll.Click += new System.EventHandler(this.menuItemCancelAll_Click);
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvOrderItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderItem.ColumnFont = null;
            this.dgvOrderItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductName,
            this.ColProductType,
            this.ColProductCode,
            this.ColModel,
            this.ColModelSource,
            this.ColProductSize,
            this.ColProductCount,
            this.ColRemarks});
            this.dgvOrderItem.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.EnableHeadersVisualStyles = false;
            this.dgvOrderItem.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvOrderItem.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvOrderItem.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrderItem.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrderItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItem.Size = new System.Drawing.Size(529, 496);
            this.dgvOrderItem.TabIndex = 0;
            this.dgvOrderItem.TitleBack = null;
            this.dgvOrderItem.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvOrderItem.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // ColProductName
            // 
            this.ColProductName.HeaderText = "产品名称";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColProductType
            // 
            this.ColProductType.HeaderText = "产品类型";
            this.ColProductType.Name = "ColProductType";
            this.ColProductType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColProductCode
            // 
            this.ColProductCode.HeaderText = "产品编号";
            this.ColProductCode.Name = "ColProductCode";
            // 
            // ColModel
            // 
            this.ColModel.HeaderText = "模型路径";
            this.ColModel.Name = "ColModel";
            // 
            // ColModelSource
            // 
            this.ColModelSource.HeaderText = "模型来源";
            this.ColModelSource.Name = "ColModelSource";
            // 
            // ColProductSize
            // 
            this.ColProductSize.HeaderText = "产品尺寸";
            this.ColProductSize.Name = "ColProductSize";
            // 
            // ColProductCount
            // 
            this.ColProductCount.HeaderText = "产品数量";
            this.ColProductCount.Name = "ColProductCount";
            // 
            // ColRemarks
            // 
            this.ColRemarks.HeaderText = "备注信息";
            this.ColRemarks.Name = "ColRemarks";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddOrder,
            this.btnDelOrder,
            this.toolStripSeparator2,
            this.btnERPOrder,
            this.btnExcelOrder,
            this.toolStripSeparator3,
            this.btnOrderPreview,
            this.btnSubmitOrder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1284, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.Image")));
            this.btnAddOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(91, 36);
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnDelOrder.Image")));
            this.btnDelOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(91, 36);
            this.btnDelOrder.Text = "删除订单";
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnERPOrder
            // 
            this.btnERPOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnERPOrder.Image")));
            this.btnERPOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnERPOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnERPOrder.Name = "btnERPOrder";
            this.btnERPOrder.Size = new System.Drawing.Size(90, 36);
            this.btnERPOrder.Text = " ERP订单";
            this.btnERPOrder.Click += new System.EventHandler(this.btnERPOrder_Click);
            // 
            // btnExcelOrder
            // 
            this.btnExcelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelOrder.Image")));
            this.btnExcelOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcelOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcelOrder.Name = "btnExcelOrder";
            this.btnExcelOrder.Size = new System.Drawing.Size(93, 36);
            this.btnExcelOrder.Text = "Excel订单";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnOrderPreview
            // 
            this.btnOrderPreview.Image = global::AutoOrderSystem.UI.Properties.Resources.orderpreview_32px;
            this.btnOrderPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOrderPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderPreview.Name = "btnOrderPreview";
            this.btnOrderPreview.Size = new System.Drawing.Size(91, 36);
            this.btnOrderPreview.Text = "浏览订单";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitOrder.Image")));
            this.btnSubmitOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSubmitOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(91, 36);
            this.btnSubmitOrder.Text = "提交订单";
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pnlBottom.Controls.Add(this.statusStrip1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 595);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(1);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1284, 40);
            this.pnlBottom.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_ServerIP,
            this.lbl_LoginUser,
            this.lbl_Status,
            this.lbl_Flicker,
            this.toolStripStatusLabel1,
            this.lbl_TimeNow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 40);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_ServerIP
            // 
            this.lbl_ServerIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_ServerIP.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lbl_ServerIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerIP.Name = "lbl_ServerIP";
            this.lbl_ServerIP.Size = new System.Drawing.Size(162, 35);
            this.lbl_ServerIP.Text = "服务器：192.168.5.3";
            // 
            // lbl_LoginUser
            // 
            this.lbl_LoginUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_LoginUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lbl_LoginUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginUser.Name = "lbl_LoginUser";
            this.lbl_LoginUser.Size = new System.Drawing.Size(142, 35);
            this.lbl_LoginUser.Text = "登录用户：admin";
            // 
            // lbl_Status
            // 
            this.lbl_Status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbl_Status.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lbl_Status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(94, 35);
            this.lbl_Status.Text = "状态：就绪";
            // 
            // lbl_Flicker
            // 
            this.lbl_Flicker.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Flicker.Name = "lbl_Flicker";
            this.lbl_Flicker.Size = new System.Drawing.Size(26, 35);
            this.lbl_Flicker.Text = "♥";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(778, 35);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lbl_TimeNow
            // 
            this.lbl_TimeNow.Name = "lbl_TimeNow";
            this.lbl_TimeNow.Size = new System.Drawing.Size(67, 35);
            this.lbl_TimeNow.Text = "当前时间：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 635);
            this.panel1.TabIndex = 4;
            // 
            // timerUIupdate
            // 
            this.timerUIupdate.Interval = 500;
            this.timerUIupdate.Tick += new System.EventHandler(this.timerUIupdate_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1288, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单系统";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.menuDgvOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        public System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogo;
        protected System.Windows.Forms.Label lblCapation;
        protected System.Windows.Forms.Panel pnlMain;
        protected System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddOrder;
        private System.Windows.Forms.ToolStripButton btnDelOrder;
        private System.Windows.Forms.ToolStripButton btnSubmitOrder;
        private System.Windows.Forms.ToolStripButton btnERPOrder;
        private System.Windows.Forms.ToolStripButton btnExcelOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CCWin.SkinControl.SkinDataGridView dgvOrderItem;
        private ContextMenuStrip menuDgvOrder;
        private ToolStripMenuItem menuItemSelectAll;
        private ToolStripMenuItem menuItemCancelAll;
        private DataGridViewTextBoxColumn ColProductName;
        private DataGridViewTextBoxColumn ColProductType;
        private DataGridViewTextBoxColumn ColProductCode;
        private DataGridViewTextBoxColumn ColModel;
        private DataGridViewTextBoxColumn ColModelSource;
        private DataGridViewTextBoxColumn ColProductSize;
        private DataGridViewTextBoxColumn ColProductCount;
        private DataGridViewTextBoxColumn ColRemarks;
        private CCWin.SkinControl.SkinDataGridView dgvOrder;
        private DataGridViewCheckBoxColumn ColSelected;
        private DataGridViewTextBoxColumn ColOrderNo;
        private DataGridViewTextBoxColumn ColCustomerName;
        private DataGridViewTextBoxColumn ColCustomerPhone;
        private DataGridViewTextBoxColumn ColCustomerAddress;
        private DataGridViewTextBoxColumn ColOrderDate;
        private DataGridViewTextBoxColumn ColDeliveryDate;
        private DataGridViewTextBoxColumn ColOrderRemarks;
        private DataGridViewLinkColumn ColOrderDetail;
        private ToolStripButton btnOrderPreview;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Timer timerUIupdate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_ServerIP;
        private ToolStripStatusLabel lbl_LoginUser;
        private ToolStripStatusLabel lbl_Status;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbl_TimeNow;
        private ToolStripStatusLabel lbl_Flicker;
    }
}