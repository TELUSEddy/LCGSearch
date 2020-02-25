namespace LCGSearch
{
    partial class LCGSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCGSearchForm));
            this.searchCLLI = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.npaLabel = new System.Windows.Forms.Label();
            this.nxxLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.rcLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.switchLabel = new System.Windows.Forms.Label();
            this.lataLabel = new System.Windows.Forms.Label();
            this.ocnLabel = new System.Windows.Forms.Label();
            this.npaData = new System.Windows.Forms.TextBox();
            this.nxxData = new System.Windows.Forms.TextBox();
            this.xData = new System.Windows.Forms.TextBox();
            this.rcData = new System.Windows.Forms.TextBox();
            this.regionData = new System.Windows.Forms.TextBox();
            this.switchData = new System.Windows.Forms.TextBox();
            this.lataData = new System.Windows.Forms.TextBox();
            this.ocnData = new System.Windows.Forms.TextBox();
            this.exchText = new System.Windows.Forms.Label();
            this.exchData = new System.Windows.Forms.TextBox();
            this.lirText = new System.Windows.Forms.Label();
            this.lirData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCLLI
            // 
            this.searchCLLI.Location = new System.Drawing.Point(860, 21);
            this.searchCLLI.Name = "searchCLLI";
            this.searchCLLI.Size = new System.Drawing.Size(75, 23);
            this.searchCLLI.TabIndex = 0;
            this.searchCLLI.Text = "Search";
            this.searchCLLI.UseVisualStyleBackColor = true;
            this.searchCLLI.Click += new System.EventHandler(this.SearchCLLI_Click);
            // 
            // resultView
            // 
            this.resultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Location = new System.Drawing.Point(12, 50);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(923, 388);
            this.resultView.TabIndex = 49;
            // 
            // npaLabel
            // 
            this.npaLabel.AutoSize = true;
            this.npaLabel.Location = new System.Drawing.Point(12, 7);
            this.npaLabel.Name = "npaLabel";
            this.npaLabel.Size = new System.Drawing.Size(29, 13);
            this.npaLabel.TabIndex = 50;
            this.npaLabel.Text = "NPA";
            this.npaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nxxLabel
            // 
            this.nxxLabel.AutoSize = true;
            this.nxxLabel.Location = new System.Drawing.Point(47, 7);
            this.nxxLabel.Name = "nxxLabel";
            this.nxxLabel.Size = new System.Drawing.Size(29, 13);
            this.nxxLabel.TabIndex = 51;
            this.nxxLabel.Text = "NXX";
            this.nxxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(82, 7);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(34, 13);
            this.xLabel.TabIndex = 52;
            this.xLabel.Text = "Block";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rcLabel
            // 
            this.rcLabel.AutoSize = true;
            this.rcLabel.Location = new System.Drawing.Point(140, 7);
            this.rcLabel.Name = "rcLabel";
            this.rcLabel.Size = new System.Drawing.Size(64, 13);
            this.rcLabel.TabIndex = 53;
            this.rcLabel.Text = "Rate Center";
            this.rcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(228, 7);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(41, 13);
            this.regionLabel.TabIndex = 54;
            this.regionLabel.Text = "Region";
            this.regionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchLabel
            // 
            this.switchLabel.AutoSize = true;
            this.switchLabel.Location = new System.Drawing.Point(306, 7);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(39, 13);
            this.switchLabel.TabIndex = 55;
            this.switchLabel.Text = "Switch";
            this.switchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lataLabel
            // 
            this.lataLabel.AutoSize = true;
            this.lataLabel.Location = new System.Drawing.Point(381, 7);
            this.lataLabel.Name = "lataLabel";
            this.lataLabel.Size = new System.Drawing.Size(62, 13);
            this.lataLabel.TabIndex = 56;
            this.lataLabel.Text = "LATA Code";
            this.lataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ocnLabel
            // 
            this.ocnLabel.AutoSize = true;
            this.ocnLabel.Location = new System.Drawing.Point(453, 7);
            this.ocnLabel.Name = "ocnLabel";
            this.ocnLabel.Size = new System.Drawing.Size(30, 13);
            this.ocnLabel.TabIndex = 57;
            this.ocnLabel.Text = "OCN";
            this.ocnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npaData
            // 
            this.npaData.Location = new System.Drawing.Point(12, 23);
            this.npaData.MaxLength = 3;
            this.npaData.Name = "npaData";
            this.npaData.Size = new System.Drawing.Size(29, 20);
            this.npaData.TabIndex = 58;
            this.npaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npaData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NpaData_KeyPress);
            this.npaData.Validating += new System.ComponentModel.CancelEventHandler(this.NpaData_Validating);
            // 
            // nxxData
            // 
            this.nxxData.Location = new System.Drawing.Point(47, 23);
            this.nxxData.MaxLength = 3;
            this.nxxData.Name = "nxxData";
            this.nxxData.Size = new System.Drawing.Size(29, 20);
            this.nxxData.TabIndex = 59;
            this.nxxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nxxData.Validating += new System.ComponentModel.CancelEventHandler(this.NxxData_Validating);
            // 
            // xData
            // 
            this.xData.Location = new System.Drawing.Point(82, 23);
            this.xData.MaxLength = 1;
            this.xData.Name = "xData";
            this.xData.Size = new System.Drawing.Size(34, 20);
            this.xData.TabIndex = 60;
            this.xData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XData_KeyPress);
            this.xData.Validating += new System.ComponentModel.CancelEventHandler(this.XData_Validating);
            // 
            // rcData
            // 
            this.rcData.Location = new System.Drawing.Point(122, 23);
            this.rcData.Name = "rcData";
            this.rcData.Size = new System.Drawing.Size(100, 20);
            this.rcData.TabIndex = 61;
            this.rcData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regionData
            // 
            this.regionData.Location = new System.Drawing.Point(228, 23);
            this.regionData.MaxLength = 2;
            this.regionData.Name = "regionData";
            this.regionData.Size = new System.Drawing.Size(41, 20);
            this.regionData.TabIndex = 62;
            this.regionData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegionData_KeyPress);
            this.regionData.Validating += new System.ComponentModel.CancelEventHandler(this.RegionData_Validating);
            // 
            // switchData
            // 
            this.switchData.Location = new System.Drawing.Point(275, 23);
            this.switchData.MaxLength = 11;
            this.switchData.Name = "switchData";
            this.switchData.Size = new System.Drawing.Size(100, 20);
            this.switchData.TabIndex = 63;
            this.switchData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.switchData.Validating += new System.ComponentModel.CancelEventHandler(this.SwitchData_Validating);
            // 
            // lataData
            // 
            this.lataData.Location = new System.Drawing.Point(381, 23);
            this.lataData.MaxLength = 5;
            this.lataData.Name = "lataData";
            this.lataData.Size = new System.Drawing.Size(62, 20);
            this.lataData.TabIndex = 64;
            this.lataData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lataData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LataData_KeyPress);
            this.lataData.Validating += new System.ComponentModel.CancelEventHandler(this.LataData_Validating);
            // 
            // ocnData
            // 
            this.ocnData.Location = new System.Drawing.Point(449, 23);
            this.ocnData.MaxLength = 4;
            this.ocnData.Name = "ocnData";
            this.ocnData.Size = new System.Drawing.Size(39, 20);
            this.ocnData.TabIndex = 65;
            this.ocnData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocnData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OcnData_KeyPress);
            // 
            // exchText
            // 
            this.exchText.AutoSize = true;
            this.exchText.Location = new System.Drawing.Point(495, 7);
            this.exchText.Name = "exchText";
            this.exchText.Size = new System.Drawing.Size(55, 13);
            this.exchText.TabIndex = 66;
            this.exchText.Text = "Exchange";
            this.exchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exchData
            // 
            this.exchData.Location = new System.Drawing.Point(495, 22);
            this.exchData.MaxLength = 6;
            this.exchData.Name = "exchData";
            this.exchData.Size = new System.Drawing.Size(55, 20);
            this.exchData.TabIndex = 67;
            this.exchData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exchData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExchData_KeyPress);
            this.exchData.Validating += new System.ComponentModel.CancelEventHandler(this.ExchData_Validating);
            // 
            // lirText
            // 
            this.lirText.AutoSize = true;
            this.lirText.Location = new System.Drawing.Point(572, 7);
            this.lirText.Name = "lirText";
            this.lirText.Size = new System.Drawing.Size(24, 13);
            this.lirText.TabIndex = 68;
            this.lirText.Text = "LIR";
            this.lirText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lirData
            // 
            this.lirData.Location = new System.Drawing.Point(557, 21);
            this.lirData.MaxLength = 6;
            this.lirData.Name = "lirData";
            this.lirData.Size = new System.Drawing.Size(55, 20);
            this.lirData.TabIndex = 69;
            this.lirData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lirData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LirData_KeyPress);
            this.lirData.Validating += new System.ComponentModel.CancelEventHandler(this.LirData_Validating);
            // 
            // LCGSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.lirData);
            this.Controls.Add(this.lirText);
            this.Controls.Add(this.exchData);
            this.Controls.Add(this.exchText);
            this.Controls.Add(this.ocnData);
            this.Controls.Add(this.lataData);
            this.Controls.Add(this.switchData);
            this.Controls.Add(this.regionData);
            this.Controls.Add(this.rcData);
            this.Controls.Add(this.xData);
            this.Controls.Add(this.nxxData);
            this.Controls.Add(this.npaData);
            this.Controls.Add(this.ocnLabel);
            this.Controls.Add(this.lataLabel);
            this.Controls.Add(this.switchLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.rcLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.nxxLabel);
            this.Controls.Add(this.npaLabel);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.searchCLLI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCGSearch";
            this.Text = "Local Calling Guide";
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCLLI;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.Label npaLabel;
        private System.Windows.Forms.Label nxxLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label rcLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label switchLabel;
        private System.Windows.Forms.Label lataLabel;
        private System.Windows.Forms.Label ocnLabel;
        private System.Windows.Forms.TextBox npaData;
        private System.Windows.Forms.TextBox nxxData;
        private System.Windows.Forms.TextBox xData;
        private System.Windows.Forms.TextBox rcData;
        private System.Windows.Forms.TextBox regionData;
        private System.Windows.Forms.TextBox switchData;
        private System.Windows.Forms.TextBox lataData;
        private System.Windows.Forms.TextBox ocnData;
        private System.Windows.Forms.Label exchText;
        private System.Windows.Forms.TextBox exchData;
        private System.Windows.Forms.Label lirText;
        private System.Windows.Forms.TextBox lirData;
    }
}

