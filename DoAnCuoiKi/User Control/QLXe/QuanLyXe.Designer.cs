
namespace DoAnCuoiKi
{
    partial class QuanLyXe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDS = new System.Windows.Forms.Button();
            this.buttonGiu = new System.Windows.Forms.Button();
            this.buttonHopDong = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.panelView);
            this.panelMain.Controls.Add(this.flowLayoutPanelMenu);
            this.panelMain.Location = new System.Drawing.Point(20, 9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1137, 560);
            this.panelMain.TabIndex = 0;
            // 
            // panelView
            // 
            this.panelView.AutoSize = true;
            this.panelView.Location = new System.Drawing.Point(208, 14);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(779, 537);
            this.panelView.TabIndex = 1;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDS);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonGiu);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonHopDong);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(20, 13);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(182, 538);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonDS
            // 
            this.buttonDS.Location = new System.Drawing.Point(3, 3);
            this.buttonDS.Name = "buttonDS";
            this.buttonDS.Size = new System.Drawing.Size(179, 51);
            this.buttonDS.TabIndex = 0;
            this.buttonDS.Text = "Danh sách xe";
            this.buttonDS.UseVisualStyleBackColor = true;
            this.buttonDS.Click += new System.EventHandler(this.buttonDS_Click);
            // 
            // buttonGiu
            // 
            this.buttonGiu.Location = new System.Drawing.Point(3, 60);
            this.buttonGiu.Name = "buttonGiu";
            this.buttonGiu.Size = new System.Drawing.Size(179, 51);
            this.buttonGiu.TabIndex = 1;
            this.buttonGiu.Text = "Danh Sách Xe Đăng Kí Giữ";
            this.buttonGiu.UseVisualStyleBackColor = true;
            this.buttonGiu.Click += new System.EventHandler(this.buttonGiu_Click);
            // 
            // buttonHopDong
            // 
            this.buttonHopDong.Location = new System.Drawing.Point(3, 117);
            this.buttonHopDong.Name = "buttonHopDong";
            this.buttonHopDong.Size = new System.Drawing.Size(179, 51);
            this.buttonHopDong.TabIndex = 2;
            this.buttonHopDong.Text = "Danh Sách Xe Đăng Kí Hợp Đồng";
            this.buttonHopDong.UseVisualStyleBackColor = true;
            this.buttonHopDong.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // QuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Name = "QuanLyXe";
            this.Size = new System.Drawing.Size(1160, 582);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonDS;
        private System.Windows.Forms.Button buttonGiu;
        private System.Windows.Forms.Button buttonHopDong;
    }
}
