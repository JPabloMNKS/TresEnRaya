namespace TresEnRaya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReinciar = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtGanador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugador 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(146, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(146, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 42);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnReinciar
            // 
            this.btnReinciar.BackColor = System.Drawing.Color.Red;
            this.btnReinciar.FlatAppearance.BorderSize = 0;
            this.btnReinciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinciar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinciar.ForeColor = System.Drawing.Color.White;
            this.btnReinciar.Location = new System.Drawing.Point(32, 300);
            this.btnReinciar.Name = "btnReinciar";
            this.btnReinciar.Size = new System.Drawing.Size(152, 50);
            this.btnReinciar.TabIndex = 4;
            this.btnReinciar.Text = "Reiniciar";
            this.btnReinciar.UseVisualStyleBackColor = false;
            this.btnReinciar.Click += new System.EventHandler(this.BtnReinciar_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 59);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(650, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 59);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(725, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 59);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGanador);
            this.panel1.Controls.Add(this.btnEmpezar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReinciar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(577, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 391);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.txtTurno);
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 88);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 303);
            this.panel3.TabIndex = 9;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 97);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmpezar.FlatAppearance.BorderSize = 0;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.White;
            this.btnEmpezar.Location = new System.Drawing.Point(32, 252);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(152, 50);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btn3);
            this.panel4.Controls.Add(this.btn9);
            this.panel4.Controls.Add(this.btn6);
            this.panel4.Controls.Add(this.btn8);
            this.panel4.Controls.Add(this.btn5);
            this.panel4.Controls.Add(this.btn2);
            this.panel4.Controls.Add(this.btn7);
            this.panel4.Controls.Add(this.btn4);
            this.panel4.Controls.Add(this.btn1);
            this.panel4.Location = new System.Drawing.Point(150, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 293);
            this.panel4.TabIndex = 1;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(0, 98);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(97, 97);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(0, 196);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(97, 97);
            this.btn7.TabIndex = 2;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(98, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 97);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(98, 98);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(97, 97);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(98, 196);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(97, 97);
            this.btn8.TabIndex = 5;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(196, 196);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(97, 97);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(196, 98);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(97, 97);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(196, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 97);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(23, 29);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(170, 21);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Text = "Juego: No Iniciado";
            // 
            // txtTurno
            // 
            this.txtTurno.AutoSize = true;
            this.txtTurno.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(333, 29);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(159, 21);
            this.txtTurno.TabIndex = 7;
            this.txtTurno.Text = "Turno: Jugador 1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(498, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 42);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txtGanador
            // 
            this.txtGanador.AutoSize = true;
            this.txtGanador.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanador.Location = new System.Drawing.Point(19, 180);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.Size = new System.Drawing.Size(0, 21);
            this.txtGanador.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReinciar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txtTurno;
        private System.Windows.Forms.Label txtGanador;
    }
}

