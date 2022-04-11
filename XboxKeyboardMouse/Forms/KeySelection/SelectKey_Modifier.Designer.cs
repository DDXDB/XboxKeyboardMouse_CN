namespace XboxKeyboardMouse.Forms {
    partial class SelectKey_Modifier {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkMod = new System.Windows.Forms.LinkLabel();
            this.lnkKey = new System.Windows.Forms.LinkLabel();
            this.lnkModRemove = new System.Windows.Forms.LinkLabel();
            this.lnkKeyRemove = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "完成后按确定或清除";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "组合键1: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "组合键2: ";
            // 
            // lnkMod
            // 
            this.lnkMod.AutoSize = true;
            this.lnkMod.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.lnkMod.Location = new System.Drawing.Point(103, 34);
            this.lnkMod.Name = "lnkMod";
            this.lnkMod.Size = new System.Drawing.Size(19, 15);
            this.lnkMod.TabIndex = 8;
            this.lnkMod.TabStop = true;
            this.lnkMod.Text = "无";
            this.lnkMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMod_LinkClicked);
            // 
            // lnkKey
            // 
            this.lnkKey.AutoSize = true;
            this.lnkKey.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.lnkKey.Location = new System.Drawing.Point(103, 69);
            this.lnkKey.Name = "lnkKey";
            this.lnkKey.Size = new System.Drawing.Size(19, 15);
            this.lnkKey.TabIndex = 9;
            this.lnkKey.TabStop = true;
            this.lnkKey.Text = "无";
            this.lnkKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKey_LinkClicked);
            // 
            // lnkModRemove
            // 
            this.lnkModRemove.AutoSize = true;
            this.lnkModRemove.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.lnkModRemove.Location = new System.Drawing.Point(22, 48);
            this.lnkModRemove.Name = "lnkModRemove";
            this.lnkModRemove.Size = new System.Drawing.Size(31, 15);
            this.lnkModRemove.TabIndex = 11;
            this.lnkModRemove.TabStop = true;
            this.lnkModRemove.Text = "重置";
            this.lnkModRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModRemove_LinkClicked);
            // 
            // lnkKeyRemove
            // 
            this.lnkKeyRemove.AutoSize = true;
            this.lnkKeyRemove.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.lnkKeyRemove.Location = new System.Drawing.Point(22, 84);
            this.lnkKeyRemove.Name = "lnkKeyRemove";
            this.lnkKeyRemove.Size = new System.Drawing.Size(31, 15);
            this.lnkKeyRemove.TabIndex = 12;
            this.lnkKeyRemove.TabStop = true;
            this.lnkKeyRemove.Text = "重置";
            this.lnkKeyRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKeyRemove_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "设置组合键";
            // 
            // SelectKey_Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkKeyRemove);
            this.Controls.Add(this.lnkModRemove);
            this.Controls.Add(this.lnkKey);
            this.Controls.Add(this.lnkMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectKey_Modifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置快捷键";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectKey_Modifier_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkMod;
        private System.Windows.Forms.LinkLabel lnkKey;
        private System.Windows.Forms.LinkLabel lnkModRemove;
        private System.Windows.Forms.LinkLabel lnkKeyRemove;
        private System.Windows.Forms.Label label3;
    }
}