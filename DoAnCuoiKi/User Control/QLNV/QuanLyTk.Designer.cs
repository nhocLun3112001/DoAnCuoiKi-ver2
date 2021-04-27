
namespace DoAnCuoiKi
{
    partial class QuanLyTk
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
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonTaoTk = new System.Windows.Forms.Button();
            this.buttonSuaTk = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.buttonTaoTk);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonSuaTk);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(8, 4);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(265, 471);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Location = new System.Drawing.Point(279, 7);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(637, 468);
            this.panelMain.TabIndex = 1;
            // 
            // buttonTaoTk
            // 
            this.buttonTaoTk.Location = new System.Drawing.Point(3, 3);
            this.buttonTaoTk.Name = "buttonTaoTk";
            this.buttonTaoTk.Size = new System.Drawing.Size(262, 55);
            this.buttonTaoTk.TabIndex = 0;
            this.buttonTaoTk.Text = "Tạo tài khoản";
            this.buttonTaoTk.UseVisualStyleBackColor = true;
            this.buttonTaoTk.Click += new System.EventHandler(this.buttonTaoTk_Click);
            // 
            // buttonSuaTk
            // 
            this.buttonSuaTk.Location = new System.Drawing.Point(3, 64);
            this.buttonSuaTk.Name = "buttonSuaTk";
            this.buttonSuaTk.Size = new System.Drawing.Size(262, 55);
            this.buttonSuaTk.TabIndex = 1;
            this.buttonSuaTk.Text = "Sửa tài khoản";
            this.buttonSuaTk.UseVisualStyleBackColor = true;
            this.buttonSuaTk.Click += new System.EventHandler(this.buttonSuaTk_Click);
            // 
            // QuanLyTk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Name = "QuanLyTk";
            this.Size = new System.Drawing.Size(948, 504);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTaoTk;
        private System.Windows.Forms.Button buttonSuaTk;
    }
}
