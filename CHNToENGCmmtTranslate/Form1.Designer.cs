namespace CHNToENGCmmtTranslate
{
    partial class TranslateToEng
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
            this.btntnslate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnselectfolderpath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntnslate
            // 
            this.btntnslate.BackColor = System.Drawing.Color.RosyBrown;
            this.btntnslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntnslate.Location = new System.Drawing.Point(186, 143);
            this.btntnslate.Name = "btntnslate";
            this.btntnslate.Size = new System.Drawing.Size(109, 23);
            this.btntnslate.TabIndex = 0;
            this.btntnslate.Text = "Tanslate";
            this.btntnslate.UseVisualStyleBackColor = false;
            this.btntnslate.Click += new System.EventHandler(this.btntnslate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From any Language To English ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Application Folder Path:";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(186, 97);
            this.txtpath.Multiline = true;
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(470, 21);
            this.txtpath.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Location = new System.Drawing.Point(314, 143);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(109, 23);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnselectfolderpath
            // 
            this.btnselectfolderpath.BackColor = System.Drawing.Color.RosyBrown;
            this.btnselectfolderpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectfolderpath.Location = new System.Drawing.Point(662, 97);
            this.btnselectfolderpath.Name = "btnselectfolderpath";
            this.btnselectfolderpath.Size = new System.Drawing.Size(81, 23);
            this.btnselectfolderpath.TabIndex = 0;
            this.btnselectfolderpath.Text = "Select Path";
            this.btnselectfolderpath.UseVisualStyleBackColor = false;
            this.btnselectfolderpath.Click += new System.EventHandler(this.btnselectfolderpath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(668, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "*This convert from any langugae commments (e.g. // 添加控件到表单中 ) to English Comments" +
    " in your select folder files.";
            // 
            // TranslateToEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnselectfolderpath);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btntnslate);
            this.Name = "TranslateToEng";
            this.Text = "Translate To English";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntnslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnselectfolderpath;
        private System.Windows.Forms.Label label3;
    }
}

