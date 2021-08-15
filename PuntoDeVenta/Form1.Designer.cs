
namespace PuntoDeVenta
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lbtTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Controls.Add(this.btnInv);
            this.panelMenu.Controls.Add(this.btnProd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 640);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnVenta
            // 
            this.btnVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVenta.Image = global::PuntoDeVenta.Properties.Resources.outline_storefront_white_24dp;
            this.btnVenta.Location = new System.Drawing.Point(0, 65);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(180, 200);
            this.btnVenta.TabIndex = 7;
            this.btnVenta.Text = "  Venta Articulos";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnInv
            // 
            this.btnInv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInv.FlatAppearance.BorderSize = 0;
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInv.Image = global::PuntoDeVenta.Properties.Resources.outline_inventory_2_white_24dp;
            this.btnInv.Location = new System.Drawing.Point(0, 465);
            this.btnInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(180, 200);
            this.btnInv.TabIndex = 6;
            this.btnInv.Text = "Inventario";
            this.btnInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnProd
            // 
            this.btnProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProd.Image = global::PuntoDeVenta.Properties.Resources.outline_shopping_cart_white_24dp1;
            this.btnProd.Location = new System.Drawing.Point(-2, 261);
            this.btnProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(180, 200);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Productos";
            this.btnProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.button4);
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lbtTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1112, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(1081, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(1038, -7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "O";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(1059, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImage = global::PuntoDeVenta.Properties.Resources.outline_clear_white_18dp;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(18, 15);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lbtTitle
            // 
            this.lbtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtTitle.AutoSize = true;
            this.lbtTitle.Font = new System.Drawing.Font("Bahnschrift", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbtTitle.Location = new System.Drawing.Point(427, 14);
            this.lbtTitle.Name = "lbtTitle";
            this.lbtTitle.Size = new System.Drawing.Size(238, 34);
            this.lbtTitle.TabIndex = 1;
            this.lbtTitle.Text = "MENU PRINCIPAL";
            this.lbtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbtTitle.Click += new System.EventHandler(this.lbtTitle_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.White;
            this.panelDesktopPanel.Controls.Add(this.lblHour);
            this.panelDesktopPanel.Controls.Add(this.lblDate);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(180, 65);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1112, 575);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Historic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDate.Location = new System.Drawing.Point(145, 246);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(915, 89);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Jueves, 8 de Agosto del 2021";
            this.lblDate.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // lblHour
            // 
            this.lblHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHour.AutoSize = true;
            this.lblHour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHour.Font = new System.Drawing.Font("Sylfaen", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(349, 130);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(434, 99);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "3:05:35 a.m.";
            this.lblHour.Click += new System.EventHandler(this.lblHour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1292, 640);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDate;
    }
}

