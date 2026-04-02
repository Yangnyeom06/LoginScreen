namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 35F);
            lblAppName.ImageAlign = ContentAlignment.TopRight;
            lblAppName.Location = new Point(121, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(291, 86);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "Login";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 15F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(121, 134);
            txtID.Name = "txtID";
            txtID.Size = new Size(291, 41);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 15F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(121, 216);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(291, 41);
            txtPW.TabIndex = 2;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.Font = new Font("맑은 고딕", 15F);
            btnLogin.Location = new Point(189, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 51);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 409);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
