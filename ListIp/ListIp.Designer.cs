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
            this._buttonStartListing = new System.Windows.Forms.Button();
            this._textBoxIpBase = new System.Windows.Forms.TextBox();
            this._labelIpBase = new System.Windows.Forms.Label();
            this._textBoxIpMin = new System.Windows.Forms.TextBox();
            this._textBoxIpMax = new System.Windows.Forms.TextBox();
            this._labelIpMin = new System.Windows.Forms.Label();
            this._labelIpMax = new System.Windows.Forms.Label();
            this._textBoxNumberOfIp = new System.Windows.Forms.TextBox();
            this._labelNumberOfIp = new System.Windows.Forms.Label();
            this._labelDot = new System.Windows.Forms.Label();
            this._buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonStartListing
            // 
            this._buttonStartListing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonStartListing.Location = new System.Drawing.Point(145, 102);
            this._buttonStartListing.Margin = new System.Windows.Forms.Padding(5);
            this._buttonStartListing.Name = "_buttonStartListing";
            this._buttonStartListing.Size = new System.Drawing.Size(65, 25);
            this._buttonStartListing.TabIndex = 0;
            this._buttonStartListing.Text = "Start";
            this._buttonStartListing.UseVisualStyleBackColor = true;
            this._buttonStartListing.Click += new System.EventHandler(this.OnButtonStartListingClick);
            // 
            // _textBoxIpBase
            // 
            this._textBoxIpBase.Location = new System.Drawing.Point(12, 38);
            this._textBoxIpBase.Margin = new System.Windows.Forms.Padding(5);
            this._textBoxIpBase.Name = "_textBoxIpBase";
            this._textBoxIpBase.Size = new System.Drawing.Size(76, 23);
            this._textBoxIpBase.TabIndex = 1;
            this._textBoxIpBase.Text = "192.168.1";
            this._textBoxIpBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpBaseKeyDown);
            // 
            // _labelIpBase
            // 
            this._labelIpBase.AutoSize = true;
            this._labelIpBase.Location = new System.Drawing.Point(26, 13);
            this._labelIpBase.Margin = new System.Windows.Forms.Padding(5);
            this._labelIpBase.Name = "_labelIpBase";
            this._labelIpBase.Size = new System.Drawing.Size(44, 15);
            this._labelIpBase.TabIndex = 2;
            this._labelIpBase.Text = "Base IP";
            // 
            // _textBoxIpMin
            // 
            this._textBoxIpMin.Location = new System.Drawing.Point(99, 38);
            this._textBoxIpMin.Margin = new System.Windows.Forms.Padding(5);
            this._textBoxIpMin.Name = "_textBoxIpMin";
            this._textBoxIpMin.Size = new System.Drawing.Size(30, 23);
            this._textBoxIpMin.TabIndex = 3;
            this._textBoxIpMin.Text = "0";
            this._textBoxIpMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._textBoxIpMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpMinKeyDown);
            // 
            // _textBoxIpMax
            // 
            this._textBoxIpMax.Location = new System.Drawing.Point(136, 38);
            this._textBoxIpMax.Margin = new System.Windows.Forms.Padding(5);
            this._textBoxIpMax.Name = "_textBoxIpMax";
            this._textBoxIpMax.Size = new System.Drawing.Size(30, 23);
            this._textBoxIpMax.TabIndex = 4;
            this._textBoxIpMax.Text = "255";
            this._textBoxIpMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._textBoxIpMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxIpMaxKeyDown);
            // 
            // _labelIpMin
            // 
            this._labelIpMin.AutoSize = true;
            this._labelIpMin.Location = new System.Drawing.Point(100, 13);
            this._labelIpMin.Margin = new System.Windows.Forms.Padding(5);
            this._labelIpMin.Name = "_labelIpMin";
            this._labelIpMin.Size = new System.Drawing.Size(28, 15);
            this._labelIpMin.TabIndex = 5;
            this._labelIpMin.Text = "Min";
            // 
            // _labelIpMax
            // 
            this._labelIpMax.AutoSize = true;
            this._labelIpMax.Location = new System.Drawing.Point(136, 13);
            this._labelIpMax.Margin = new System.Windows.Forms.Padding(5);
            this._labelIpMax.Name = "_labelIpMax";
            this._labelIpMax.Size = new System.Drawing.Size(30, 15);
            this._labelIpMax.TabIndex = 6;
            this._labelIpMax.Text = "Max";
            // 
            // _textBoxNumberOfIp
            // 
            this._textBoxNumberOfIp.Location = new System.Drawing.Point(99, 68);
            this._textBoxNumberOfIp.Margin = new System.Windows.Forms.Padding(5);
            this._textBoxNumberOfIp.Name = "_textBoxNumberOfIp";
            this._textBoxNumberOfIp.Size = new System.Drawing.Size(30, 23);
            this._textBoxNumberOfIp.TabIndex = 7;
            this._textBoxNumberOfIp.Text = "0";
            this._textBoxNumberOfIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._textBoxNumberOfIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxNbIpKeyDown);
            // 
            // _labelNumberOfIp
            // 
            this._labelNumberOfIp.AutoSize = true;
            this._labelNumberOfIp.Location = new System.Drawing.Point(14, 72);
            this._labelNumberOfIp.Margin = new System.Windows.Forms.Padding(5);
            this._labelNumberOfIp.Name = "_labelNumberOfIp";
            this._labelNumberOfIp.Size = new System.Drawing.Size(74, 15);
            this._labelNumberOfIp.TabIndex = 8;
            this._labelNumberOfIp.Text = "Nombre d\'IP";
            // 
            // _labelDot
            // 
            this._labelDot.AutoSize = true;
            this._labelDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelDot.Location = new System.Drawing.Point(89, 42);
            this._labelDot.Margin = new System.Windows.Forms.Padding(0);
            this._labelDot.Name = "_labelDot";
            this._labelDot.Size = new System.Drawing.Size(10, 13);
            this._labelDot.TabIndex = 9;
            this._labelDot.Text = ".";
            // 
            // _buttonHelp
            // 
            this._buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonHelp.Location = new System.Drawing.Point(14, 102);
            this._buttonHelp.Margin = new System.Windows.Forms.Padding(5);
            this._buttonHelp.Name = "_buttonHelp";
            this._buttonHelp.Size = new System.Drawing.Size(25, 25);
            this._buttonHelp.TabIndex = 10;
            this._buttonHelp.Text = "?";
            this._buttonHelp.UseVisualStyleBackColor = true;
            this._buttonHelp.Click += new System.EventHandler(this.OnButtonHelpClick);
            // 
            // ListIp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 141);
            this.Controls.Add(this._buttonHelp);
            this.Controls.Add(this._labelDot);
            this.Controls.Add(this._labelNumberOfIp);
            this.Controls.Add(this._textBoxNumberOfIp);
            this.Controls.Add(this._labelIpMax);
            this.Controls.Add(this._labelIpMin);
            this.Controls.Add(this._textBoxIpMax);
            this.Controls.Add(this._textBoxIpMin);
            this.Controls.Add(this._labelIpBase);
            this.Controls.Add(this._textBoxIpBase);
            this.Controls.Add(this._buttonStartListing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(240, 180);
            this.Name = "ListIp";
            this.Text = "ListIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonStartListing;
        private System.Windows.Forms.TextBox _textBoxIpBase;
        private System.Windows.Forms.Label _labelIpBase;
        private System.Windows.Forms.TextBox _textBoxIpMin;
        private System.Windows.Forms.TextBox _textBoxIpMax;
        private System.Windows.Forms.Label _labelIpMin;
        private System.Windows.Forms.Label _labelIpMax;
        private System.Windows.Forms.TextBox _textBoxNumberOfIp;
        private System.Windows.Forms.Label _labelNumberOfIp;
        private System.Windows.Forms.Label _labelDot;
        private System.Windows.Forms.Button _buttonHelp;
    }
}

