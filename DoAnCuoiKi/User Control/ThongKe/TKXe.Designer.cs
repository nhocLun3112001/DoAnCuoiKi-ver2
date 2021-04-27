
namespace DoAnCuoiKi
{
    partial class TKXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDS = new System.Windows.Forms.Button();
            this.buttonGiu = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelView);
            this.panelMain.Controls.Add(this.flowLayoutPanelMenu);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(752, 473);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ XE";
            // 
            // panelView
            // 
            this.panelView.AutoSize = true;
            this.panelView.Location = new System.Drawing.Point(208, 68);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(533, 394);
            this.panelView.TabIndex = 1;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDS);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonGiu);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(20, 65);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(182, 397);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonDS
            // 
            this.buttonDS.Location = new System.Drawing.Point(3, 3);
            this.buttonDS.Name = "buttonDS";
            this.buttonDS.Size = new System.Drawing.Size(179, 51);
            this.buttonDS.TabIndex = 0;
            this.buttonDS.Text = "Thống kê xe đã vào bến";
            this.buttonDS.UseVisualStyleBackColor = true;
            this.buttonDS.Click += new System.EventHandler(this.buttonDS_Click);
            // 
            // buttonGiu
            // 
            this.buttonGiu.Location = new System.Drawing.Point(3, 60);
            this.buttonGiu.Name = "buttonGiu";
            this.buttonGiu.Size = new System.Drawing.Size(179, 51);
            this.buttonGiu.TabIndex = 1;
            this.buttonGiu.Text = "Thống kê xe ở bến hiện tại";
            this.buttonGiu.UseVisualStyleBackColor = true;
            this.buttonGiu.Click += new System.EventHandler(this.buttonGiu_Click);
            // 
            // TKXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Name = "TKXe";
            this.Size = new System.Drawing.Size(780, 476);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonDS;
        private System.Windows.Forms.Button buttonGiu;
    }
}
