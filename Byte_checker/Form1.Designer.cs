namespace Bytw_checker
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_open = new System.Windows.Forms.TextBox();
            this.button_openfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(51, 217);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.ReadOnly = true;
            this.textBox_save.Size = new System.Drawing.Size(424, 22);
            this.textBox_save.TabIndex = 9;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.SandyBrown;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(503, 193);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 66);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_open
            // 
            this.textBox_open.Location = new System.Drawing.Point(51, 79);
            this.textBox_open.Name = "textBox_open";
            this.textBox_open.ReadOnly = true;
            this.textBox_open.Size = new System.Drawing.Size(424, 22);
            this.textBox_open.TabIndex = 7;
            // 
            // button_openfile
            // 
            this.button_openfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_openfile.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_openfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button_openfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openfile.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openfile.Location = new System.Drawing.Point(503, 55);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(141, 66);
            this.button_openfile.TabIndex = 6;
            this.button_openfile.Text = "Open";
            this.button_openfile.UseVisualStyleBackColor = false;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 124);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 124);
            this.label2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 298);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_open);
            this.Controls.Add(this.button_openfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Byte checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_open;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

