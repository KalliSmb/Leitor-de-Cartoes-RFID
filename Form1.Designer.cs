namespace Conversor_Cartão
{
    partial class Form1
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
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDEC = new System.Windows.Forms.Label();
            this.PortaCom_comboBox = new System.Windows.Forms.ComboBox();
            this.BaudRate_comboBox = new System.Windows.Forms.ComboBox();
            this.btnAbrirCOM = new System.Windows.Forms.Button();
            this.btnFecharCOM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOpenClosed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHEX
            // 
            this.txtHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEX.Location = new System.Drawing.Point(94, 175);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.ReadOnly = true;
            this.txtHEX.Size = new System.Drawing.Size(264, 22);
            this.txtHEX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hexadecimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decimal";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(274, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDEC
            // 
            this.lblDEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEC.Location = new System.Drawing.Point(94, 260);
            this.lblDEC.Name = "lblDEC";
            this.lblDEC.Size = new System.Drawing.Size(264, 23);
            this.lblDEC.TabIndex = 6;
            // 
            // PortaCom_comboBox
            // 
            this.PortaCom_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortaCom_comboBox.FormattingEnabled = true;
            this.PortaCom_comboBox.Location = new System.Drawing.Point(92, 31);
            this.PortaCom_comboBox.Name = "PortaCom_comboBox";
            this.PortaCom_comboBox.Size = new System.Drawing.Size(160, 24);
            this.PortaCom_comboBox.TabIndex = 8;
            // 
            // BaudRate_comboBox
            // 
            this.BaudRate_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate_comboBox.FormattingEnabled = true;
            this.BaudRate_comboBox.Items.AddRange(new object[] {
            "9600"});
            this.BaudRate_comboBox.Location = new System.Drawing.Point(92, 61);
            this.BaudRate_comboBox.Name = "BaudRate_comboBox";
            this.BaudRate_comboBox.Size = new System.Drawing.Size(117, 24);
            this.BaudRate_comboBox.TabIndex = 9;
            // 
            // btnAbrirCOM
            // 
            this.btnAbrirCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCOM.Location = new System.Drawing.Point(270, 28);
            this.btnAbrirCOM.Name = "btnAbrirCOM";
            this.btnAbrirCOM.Size = new System.Drawing.Size(84, 31);
            this.btnAbrirCOM.TabIndex = 10;
            this.btnAbrirCOM.Text = "Abrir COM";
            this.btnAbrirCOM.UseVisualStyleBackColor = true;
            this.btnAbrirCOM.Click += new System.EventHandler(this.btnAbrirCOM_Click);
            // 
            // btnFecharCOM
            // 
            this.btnFecharCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCOM.Location = new System.Drawing.Point(360, 28);
            this.btnFecharCOM.Name = "btnFecharCOM";
            this.btnFecharCOM.Size = new System.Drawing.Size(84, 32);
            this.btnFecharCOM.TabIndex = 11;
            this.btnFecharCOM.Text = "Fechar COM";
            this.btnFecharCOM.UseVisualStyleBackColor = true;
            this.btnFecharCOM.Click += new System.EventHandler(this.btnFecharCOM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Porta COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Baud Rate";
            // 
            // lblOpenClosed
            // 
            this.lblOpenClosed.AutoSize = true;
            this.lblOpenClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenClosed.ForeColor = System.Drawing.Color.Red;
            this.lblOpenClosed.Location = new System.Drawing.Point(327, 69);
            this.lblOpenClosed.Name = "lblOpenClosed";
            this.lblOpenClosed.Size = new System.Drawing.Size(61, 16);
            this.lblOpenClosed.TabIndex = 14;
            this.lblOpenClosed.Text = "Fechada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 357);
            this.Controls.Add(this.lblOpenClosed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFecharCOM);
            this.Controls.Add(this.btnAbrirCOM);
            this.Controls.Add(this.BaudRate_comboBox);
            this.Controls.Add(this.PortaCom_comboBox);
            this.Controls.Add(this.lblDEC);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHEX);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor e Conversor RFID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDEC;
        private System.Windows.Forms.ComboBox PortaCom_comboBox;
        private System.Windows.Forms.ComboBox BaudRate_comboBox;
        private System.Windows.Forms.Button btnAbrirCOM;
        private System.Windows.Forms.Button btnFecharCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOpenClosed;
    }
}

