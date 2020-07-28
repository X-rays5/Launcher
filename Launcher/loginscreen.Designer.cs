namespace Launcher
{
    partial class Launcherwindow
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
            System.Windows.Forms.LinkLabel githublink;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcherwindow));
            this.login = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            githublink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // githublink
            // 
            githublink.ActiveLinkColor = System.Drawing.Color.White;
            githublink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            githublink.BackColor = System.Drawing.Color.Black;
            githublink.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            githublink.ForeColor = System.Drawing.Color.White;
            githublink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            githublink.LinkColor = System.Drawing.Color.White;
            githublink.Location = new System.Drawing.Point(285, -1);
            githublink.Name = "githublink";
            githublink.Size = new System.Drawing.Size(308, 60);
            githublink.TabIndex = 1;
            githublink.TabStop = true;
            githublink.Text = "Github X-rayS5";
            githublink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            githublink.VisitedLinkColor = System.Drawing.Color.White;
            githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublink_LinkClicked);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Image = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.login.Location = new System.Drawing.Point(333, 381);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(204, 53);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Image = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.passwordlabel.Location = new System.Drawing.Point(181, 330);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(149, 32);
            this.passwordlabel.TabIndex = 3;
            this.passwordlabel.Text = "Password: ";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Image = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.usernamelabel.Location = new System.Drawing.Point(172, 269);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(149, 32);
            this.usernamelabel.TabIndex = 7;
            this.usernamelabel.Text = "Username: ";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernametextbox.Location = new System.Drawing.Point(333, 269);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(204, 32);
            this.usernametextbox.TabIndex = 8;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordtextbox.Location = new System.Drawing.Point(333, 330);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(204, 32);
            this.passwordtextbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.label1.Location = new System.Drawing.Point(840, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "V1.0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo_transparent.png");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.label3.Location = new System.Drawing.Point(333, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 52);
            this.label3.TabIndex = 12;
            this.label3.Text = "Logo here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Launcherwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Launcher.Properties.Resources.black_carbon_fiber_background_texture_material_design_d_illustration_75362476;
            this.ClientSize = new System.Drawing.Size(869, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(githublink);
            this.Controls.Add(this.login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(885, 526);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(885, 526);
            this.Name = "Launcherwindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
    }
}

