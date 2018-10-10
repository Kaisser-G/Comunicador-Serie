namespace ComunicadorSerie
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCOM2 = new System.Windows.Forms.Label();
            this.lblCOM3 = new System.Windows.Forms.Label();
            this.lblCOM4 = new System.Windows.Forms.Label();
            this.lblCOM5 = new System.Windows.Forms.Label();
            this.lblCOM1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comunicador Serie";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(284, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_RecibirDatos);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(266, 79);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recibido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enviar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puerto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(24, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 13);
            this.textBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(215, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCOM2
            // 
            this.lblCOM2.AutoSize = true;
            this.lblCOM2.BackColor = System.Drawing.Color.Transparent;
            this.lblCOM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOM2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCOM2.Location = new System.Drawing.Point(77, 275);
            this.lblCOM2.Name = "lblCOM2";
            this.lblCOM2.Size = new System.Drawing.Size(50, 19);
            this.lblCOM2.TabIndex = 9;
            this.lblCOM2.Text = "COM2";
            this.lblCOM2.Click += new System.EventHandler(this.lblCOM2_Click);
            // 
            // lblCOM3
            // 
            this.lblCOM3.AutoSize = true;
            this.lblCOM3.BackColor = System.Drawing.Color.Transparent;
            this.lblCOM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOM3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCOM3.Location = new System.Drawing.Point(133, 275);
            this.lblCOM3.Name = "lblCOM3";
            this.lblCOM3.Size = new System.Drawing.Size(50, 19);
            this.lblCOM3.TabIndex = 10;
            this.lblCOM3.Text = "COM3";
            this.lblCOM3.Click += new System.EventHandler(this.lblCOM3_Click);
            // 
            // lblCOM4
            // 
            this.lblCOM4.AutoSize = true;
            this.lblCOM4.BackColor = System.Drawing.Color.Transparent;
            this.lblCOM4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOM4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCOM4.Location = new System.Drawing.Point(189, 275);
            this.lblCOM4.Name = "lblCOM4";
            this.lblCOM4.Size = new System.Drawing.Size(50, 19);
            this.lblCOM4.TabIndex = 11;
            this.lblCOM4.Text = "COM4";
            this.lblCOM4.Click += new System.EventHandler(this.lblCOM4_Click);
            // 
            // lblCOM5
            // 
            this.lblCOM5.AutoSize = true;
            this.lblCOM5.BackColor = System.Drawing.Color.Transparent;
            this.lblCOM5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOM5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCOM5.Location = new System.Drawing.Point(240, 275);
            this.lblCOM5.Name = "lblCOM5";
            this.lblCOM5.Size = new System.Drawing.Size(50, 19);
            this.lblCOM5.TabIndex = 12;
            this.lblCOM5.Text = "COM5";
            this.lblCOM5.Click += new System.EventHandler(this.lblCOM5_Click);
            // 
            // lblCOM1
            // 
            this.lblCOM1.AutoSize = true;
            this.lblCOM1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblCOM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCOM1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCOM1.Location = new System.Drawing.Point(21, 275);
            this.lblCOM1.Name = "lblCOM1";
            this.lblCOM1.Size = new System.Drawing.Size(50, 19);
            this.lblCOM1.TabIndex = 8;
            this.lblCOM1.Text = "COM1";
            this.lblCOM1.Click += new System.EventHandler(this.lblCOM1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Firebrick;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(92, 310);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(107, 21);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Desconectado";
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConexion.Location = new System.Drawing.Point(69, 340);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(170, 20);
            this.btnConexion.TabIndex = 15;
            this.btnConexion.Text = "Coectar/Desconectar";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(317, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCOM1);
            this.Controls.Add(this.lblCOM5);
            this.Controls.Add(this.lblCOM4);
            this.Controls.Add(this.lblCOM3);
            this.Controls.Add(this.lblCOM2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCOM2;
        private System.Windows.Forms.Label lblCOM3;
        private System.Windows.Forms.Label lblCOM4;
        private System.Windows.Forms.Label lblCOM5;
        private System.Windows.Forms.Label lblCOM1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnConexion;
    }
}

