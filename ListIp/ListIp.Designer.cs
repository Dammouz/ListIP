namespace ListIp
{
    partial class ListIp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListIp));
            this.btn_startListing = new System.Windows.Forms.Button();
            this.tb_IPBase = new System.Windows.Forms.TextBox();
            this.l_IPBase = new System.Windows.Forms.Label();
            this.tb_IPmin = new System.Windows.Forms.TextBox();
            this.tb_IPmax = new System.Windows.Forms.TextBox();
            this.l_IPmin = new System.Windows.Forms.Label();
            this.l_IPmax = new System.Windows.Forms.Label();
            this.tb_NbIP = new System.Windows.Forms.TextBox();
            this.l_NbIP = new System.Windows.Forms.Label();
            this.l_dot = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startListing
            // 
            this.btn_startListing.Location = new System.Drawing.Point(118, 119);
            this.btn_startListing.Margin = new System.Windows.Forms.Padding(5);
            this.btn_startListing.Name = "btn_startListing";
            this.btn_startListing.Size = new System.Drawing.Size(75, 25);
            this.btn_startListing.TabIndex = 0;
            this.btn_startListing.Text = "Start";
            this.btn_startListing.UseVisualStyleBackColor = true;
            this.btn_startListing.Click += new System.EventHandler(this.OnButtonStartListingClick);
            // 
            // tb_IPBase
            // 
            this.tb_IPBase.Location = new System.Drawing.Point(14, 41);
            this.tb_IPBase.Margin = new System.Windows.Forms.Padding(5);
            this.tb_IPBase.Name = "tb_IPBase";
            this.tb_IPBase.Size = new System.Drawing.Size(87, 22);
            this.tb_IPBase.TabIndex = 1;
            this.tb_IPBase.Text = "192.168.1";
            this.tb_IPBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpBaseKeyDown);
            // 
            // l_IPBase
            // 
            this.l_IPBase.AutoSize = true;
            this.l_IPBase.Location = new System.Drawing.Point(30, 14);
            this.l_IPBase.Margin = new System.Windows.Forms.Padding(5);
            this.l_IPBase.Name = "l_IPBase";
            this.l_IPBase.Size = new System.Drawing.Size(56, 17);
            this.l_IPBase.TabIndex = 2;
            this.l_IPBase.Text = "Base IP";
            // 
            // tb_IPmin
            // 
            this.tb_IPmin.Location = new System.Drawing.Point(113, 41);
            this.tb_IPmin.Margin = new System.Windows.Forms.Padding(5);
            this.tb_IPmin.Name = "tb_IPmin";
            this.tb_IPmin.Size = new System.Drawing.Size(33, 22);
            this.tb_IPmin.TabIndex = 3;
            this.tb_IPmin.Text = "0";
            this.tb_IPmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_IPmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpMinKeyDown);
            // 
            // tb_IPmax
            // 
            this.tb_IPmax.Location = new System.Drawing.Point(156, 41);
            this.tb_IPmax.Margin = new System.Windows.Forms.Padding(5);
            this.tb_IPmax.Name = "tb_IPmax";
            this.tb_IPmax.Size = new System.Drawing.Size(33, 22);
            this.tb_IPmax.TabIndex = 4;
            this.tb_IPmax.Text = "255";
            this.tb_IPmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_IPmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpMaxKeyDown);
            // 
            // l_IPmin
            // 
            this.l_IPmin.AutoSize = true;
            this.l_IPmin.Location = new System.Drawing.Point(115, 14);
            this.l_IPmin.Margin = new System.Windows.Forms.Padding(5);
            this.l_IPmin.Name = "l_IPmin";
            this.l_IPmin.Size = new System.Drawing.Size(30, 17);
            this.l_IPmin.TabIndex = 5;
            this.l_IPmin.Text = "Min";
            // 
            // l_IPmax
            // 
            this.l_IPmax.AutoSize = true;
            this.l_IPmax.Location = new System.Drawing.Point(156, 14);
            this.l_IPmax.Margin = new System.Windows.Forms.Padding(5);
            this.l_IPmax.Name = "l_IPmax";
            this.l_IPmax.Size = new System.Drawing.Size(33, 17);
            this.l_IPmax.TabIndex = 6;
            this.l_IPmax.Text = "Max";
            // 
            // tb_NbIP
            // 
            this.tb_NbIP.Location = new System.Drawing.Point(113, 73);
            this.tb_NbIP.Margin = new System.Windows.Forms.Padding(5);
            this.tb_NbIP.Name = "tb_NbIP";
            this.tb_NbIP.Size = new System.Drawing.Size(33, 22);
            this.tb_NbIP.TabIndex = 7;
            this.tb_NbIP.Text = "0";
            this.tb_NbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_NbIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxNbIpKeyDown);
            // 
            // l_NbIP
            // 
            this.l_NbIP.AutoSize = true;
            this.l_NbIP.Location = new System.Drawing.Point(16, 76);
            this.l_NbIP.Margin = new System.Windows.Forms.Padding(5);
            this.l_NbIP.Name = "l_NbIP";
            this.l_NbIP.Size = new System.Drawing.Size(85, 17);
            this.l_NbIP.TabIndex = 8;
            this.l_NbIP.Text = "Nombre d\'IP";
            // 
            // l_dot
            // 
            this.l_dot.AutoSize = true;
            this.l_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dot.Location = new System.Drawing.Point(102, 44);
            this.l_dot.Margin = new System.Windows.Forms.Padding(0);
            this.l_dot.Name = "l_dot";
            this.l_dot.Size = new System.Drawing.Size(10, 15);
            this.l_dot.TabIndex = 9;
            this.l_dot.Text = ".";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(14, 119);
            this.btn_help.Margin = new System.Windows.Forms.Padding(5);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(25, 25);
            this.btn_help.TabIndex = 10;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.OnButtonHelpClick);
            // 
            // ListIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 158);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.l_dot);
            this.Controls.Add(this.l_NbIP);
            this.Controls.Add(this.tb_NbIP);
            this.Controls.Add(this.l_IPmax);
            this.Controls.Add(this.l_IPmin);
            this.Controls.Add(this.tb_IPmax);
            this.Controls.Add(this.tb_IPmin);
            this.Controls.Add(this.l_IPBase);
            this.Controls.Add(this.tb_IPBase);
            this.Controls.Add(this.btn_startListing);
            this.Location = new System.Drawing.Point(500, 500);
            this.MinimumSize = new System.Drawing.Size(225, 150);
            this.Name = "ListIP";
            this.Text = "List IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startListing;
        private System.Windows.Forms.TextBox tb_IPBase;
        private System.Windows.Forms.Label l_IPBase;
        private System.Windows.Forms.TextBox tb_IPmin;
        private System.Windows.Forms.TextBox tb_IPmax;
        private System.Windows.Forms.Label l_IPmin;
        private System.Windows.Forms.Label l_IPmax;
        private System.Windows.Forms.TextBox tb_NbIP;
        private System.Windows.Forms.Label l_NbIP;
        private System.Windows.Forms.Label l_dot;
        private System.Windows.Forms.Button btn_help;
    }
}

