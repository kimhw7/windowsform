namespace FormsStudy
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Id_label = new System.Windows.Forms.Label();
            this.Pwd_label = new System.Windows.Forms.Label();
            this.Id_textbox = new System.Windows.Forms.TextBox();
            this.Pwd_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_showPwd = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Location = new System.Drawing.Point(75, 106);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(16, 12);
            this.Id_label.TabIndex = 0;
            this.Id_label.Text = "ID";
            // 
            // Pwd_label
            // 
            this.Pwd_label.AutoSize = true;
            this.Pwd_label.Location = new System.Drawing.Point(72, 138);
            this.Pwd_label.Name = "Pwd_label";
            this.Pwd_label.Size = new System.Drawing.Size(62, 12);
            this.Pwd_label.TabIndex = 1;
            this.Pwd_label.Text = "Password";
            // 
            // Id_textbox
            // 
            this.Id_textbox.Location = new System.Drawing.Point(215, 106);
            this.Id_textbox.Name = "Id_textbox";
            this.Id_textbox.Size = new System.Drawing.Size(299, 21);
            this.Id_textbox.TabIndex = 2;
            // 
            // Pwd_textbox
            // 
            this.Pwd_textbox.Location = new System.Drawing.Point(213, 141);
            this.Pwd_textbox.Name = "Pwd_textbox";
            this.Pwd_textbox.Size = new System.Drawing.Size(300, 21);
            this.Pwd_textbox.TabIndex = 3;
            this.Pwd_textbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "비밀번호 보이기";
            // 
            // checkBox_showPwd
            // 
            this.checkBox_showPwd.AutoSize = true;
            this.checkBox_showPwd.Location = new System.Drawing.Point(449, 197);
            this.checkBox_showPwd.Name = "checkBox_showPwd";
            this.checkBox_showPwd.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPwd.TabIndex = 5;
            this.checkBox_showPwd.UseVisualStyleBackColor = true;
            this.checkBox_showPwd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(441, 275);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "전송";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_showPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pwd_textbox);
            this.Controls.Add(this.Id_textbox);
            this.Controls.Add(this.Pwd_label);
            this.Controls.Add(this.Id_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.Label Pwd_label;
        private System.Windows.Forms.TextBox Id_textbox;
        private System.Windows.Forms.TextBox Pwd_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_showPwd;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

