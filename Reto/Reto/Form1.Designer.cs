
namespace Reto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bt_iniciar = new System.Windows.Forms.PictureBox();
            this.Bt_detener = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Con_Canela = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Con_Vainilla = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Con_Chocolate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_detener)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 385);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.Bt_iniciar);
            this.panel3.Controls.Add(this.Bt_detener);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(155, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 128);
            this.panel3.TabIndex = 1;
            // 
            // Bt_iniciar
            // 
            this.Bt_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_iniciar.Image = global::Reto.Properties.Resources.pngegg;
            this.Bt_iniciar.Location = new System.Drawing.Point(13, 34);
            this.Bt_iniciar.Name = "Bt_iniciar";
            this.Bt_iniciar.Size = new System.Drawing.Size(80, 80);
            this.Bt_iniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bt_iniciar.TabIndex = 3;
            this.Bt_iniciar.TabStop = false;
            this.Bt_iniciar.Click += new System.EventHandler(this.Bt_iniciar_Click);
            // 
            // Bt_detener
            // 
            this.Bt_detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_detener.Image = global::Reto.Properties.Resources.pngegg__1_;
            this.Bt_detener.Location = new System.Drawing.Point(125, 34);
            this.Bt_detener.Name = "Bt_detener";
            this.Bt_detener.Size = new System.Drawing.Size(80, 80);
            this.Bt_detener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bt_detener.TabIndex = 4;
            this.Bt_detener.TabStop = false;
            this.Bt_detener.Click += new System.EventHandler(this.Bt_detener_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(136, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DETENER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.Con_Canela);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Con_Vainilla);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Con_Chocolate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 221);
            this.panel2.TabIndex = 0;
            // 
            // Con_Canela
            // 
            this.Con_Canela.AutoSize = true;
            this.Con_Canela.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Con_Canela.Location = new System.Drawing.Point(470, 192);
            this.Con_Canela.Name = "Con_Canela";
            this.Con_Canela.Size = new System.Drawing.Size(15, 16);
            this.Con_Canela.TabIndex = 13;
            this.Con_Canela.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "CANTIDAD DE\r\nPRODUCCIÓN:";
            // 
            // Con_Vainilla
            // 
            this.Con_Vainilla.AutoSize = true;
            this.Con_Vainilla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Con_Vainilla.Location = new System.Drawing.Point(284, 194);
            this.Con_Vainilla.Name = "Con_Vainilla";
            this.Con_Vainilla.Size = new System.Drawing.Size(15, 16);
            this.Con_Vainilla.TabIndex = 11;
            this.Con_Vainilla.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 34);
            this.label9.TabIndex = 10;
            this.label9.Text = "CANTIDAD DE\r\nPRODUCCIÓN:";
            // 
            // Con_Chocolate
            // 
            this.Con_Chocolate.AutoSize = true;
            this.Con_Chocolate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Con_Chocolate.Location = new System.Drawing.Point(111, 194);
            this.Con_Chocolate.Name = "Con_Chocolate";
            this.Con_Chocolate.Size = new System.Drawing.Size(15, 16);
            this.Con_Chocolate.TabIndex = 9;
            this.Con_Chocolate.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "CANTIDAD DE\r\nPRODUCCIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "CANELA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "VAINILLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHOCOLATE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Reto.Properties.Resources.donacanela;
            this.pictureBox3.Location = new System.Drawing.Point(371, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reto.Properties.Resources.dona_vainilla;
            this.pictureBox2.Location = new System.Drawing.Point(186, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reto.Properties.Resources.dona_chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 385);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MAQUINA DE DONAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_detener)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Bt_iniciar;
        private System.Windows.Forms.PictureBox Bt_detener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Con_Canela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Con_Vainilla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Con_Chocolate;
        private System.Windows.Forms.Label label6;
    }
}

