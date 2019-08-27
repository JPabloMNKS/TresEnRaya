using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;
        //Aplicacion
        bool iniciado = false;
        int jugador = 0;
        bool jugable1 = true;
        bool jugable2 = true;
        bool jugable3 = true;
        bool jugable4 = true;
        bool jugable5 = true;
        bool jugable6 = true;
        bool jugable7 = true;
        bool jugable8 = true;
        bool jugable9 = true;

        bool pos1_1 = false;
        bool pos1_2 = false;
        bool pos1_3 = false;
        bool pos1_4 = false;
        bool pos1_5 = false;
        bool pos1_6 = false;
        bool pos1_7 = false;
        bool pos1_8 = false;
        bool pos1_9 = false;

        bool pos2_1 = false;
        bool pos2_2 = false;
        bool pos2_3 = false;
        bool pos2_4 = false;
        bool pos2_5 = false;
        bool pos2_6 = false;
        bool pos2_7 = false;
        bool pos2_8 = false;
        bool pos2_9 = false;


        public Form1()
        {
            InitializeComponent();
        }

        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Aplicacion
        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            iniciado = true;
            jugador = 1;
            txtEstado.Text = "Juego: Iniciado";
        }
        private void BtnReinciar_Click(object sender, EventArgs e)
        {
            iniciado = false;
            jugador = 1;

            jugable1 = true;
            jugable2 = true;
            jugable3 = true;
            jugable4 = true;
            jugable5 = true;
            jugable6 = true;
            jugable7 = true;
            jugable8 = true;
            jugable9 = true;
            btn1.BackColor = Color.Silver;
            btn2.BackColor = Color.Silver;
            btn3.BackColor = Color.Silver;
            btn4.BackColor = Color.Silver;
            btn5.BackColor = Color.Silver;
            btn6.BackColor = Color.Silver;
            btn7.BackColor = Color.Silver;
            btn8.BackColor = Color.Silver;
            btn9.BackColor = Color.Silver;
            txtEstado.Text = "Juego: No Iniciado";

            pos1_1 = false;
            pos1_2 = false;
            pos1_3 = false;
            pos1_4 = false;
            pos1_5 = false;
            pos1_6 = false;
            pos1_7 = false;
            pos1_8 = false;
            pos1_9 = false;

            pos2_1 = false;
            pos2_2 = false;
            pos2_3 = false;
            pos2_4 = false;
            pos2_5 = false;
            pos2_6 = false;
            pos2_7 = false;
            pos2_8 = false;
            pos2_9 = false;
            txtGanador.Text = "";
        }

        private void Turno(int jugador)
        {
            if (jugador == 1)
            {
                txtTurno.Text = "Turno: Jugador 1";
                pictureBox3.BackColor = pictureBox1.BackColor;
            }else if(jugador == 2)
            {
                txtTurno.Text = "Turno: Jugador 2";
                pictureBox3.BackColor = pictureBox2.BackColor;
            }
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            if(iniciado && jugador == 1 && jugable1)
            {
                btn1.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable1 = false;
                pos1_1 = true;
            }else if (iniciado && jugador == 2 && jugable1)
            {
                btn1.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable1 = false;
                pos2_1 = true;
            }
            Turno(jugador);
            Ganar();
        }


        private void Btn2_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable2)
            {
                btn2.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable2 = false;
                pos1_2 = true;
            }
            else if (iniciado && jugador == 2 && jugable2)
            {
                btn2.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable2 = false;
                pos2_2 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable3)
            {
                btn3.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable3 = false;
                pos1_3 = true;
            }
            else if (iniciado && jugador == 2 && jugable3)
            {
                btn3.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable3 = false;
                pos2_3 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable4)
            {
                btn4.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable4 = false;
                pos1_4 = true;
            }
            else if (iniciado && jugador == 2 && jugable4)
            {
                btn4.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable4 = false;
                pos2_4 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable5)
            {
                btn5.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable5 = false;
                pos1_5 = true;
            }
            else if (iniciado && jugador == 2 && jugable5)
            {
                btn5.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable5 = false;
                pos2_5 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable6)
            {
                btn6.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable6 = false;
                pos1_6 = true;
            }
            else if (iniciado && jugador == 2 && jugable6)
            {
                btn6.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable6 = false;
                pos2_6 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable7)
            {
                btn7.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable7 = false;
                pos1_7 = true;
            }
            else if (iniciado && jugador == 2 && jugable7)
            {
                btn7.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable7 = false;
                pos2_7 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable8)
            {
                btn8.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable8 = false;
                pos1_8 = true;
            }
            else if (iniciado && jugador == 2 && jugable8)
            {
                btn8.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable8 = false;
                pos2_8 = true;
            }
            Turno(jugador);
            Ganar();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (iniciado && jugador == 1 && jugable9)
            {
                btn9.BackColor = pictureBox1.BackColor;
                jugador = 2;
                jugable9 = false;
                pos1_9 = true;
            }
            else if (iniciado && jugador == 2 && jugable9)
            {
                btn9.BackColor = pictureBox2.BackColor;
                jugador = 1;
                jugable9 = false;
                pos2_9 = true;
            }
            Turno(jugador);
            Ganar();
        }


        private void Ganar()
        {
            if (pos1_1 && pos1_2 && pos1_3)
                Ganador(1);
            else if (pos1_4 && pos1_5 && pos1_6)
                Ganador(1);
            else if (pos1_7 && pos1_8 && pos1_9)
                Ganador(1);
            else if (pos1_1 && pos1_4 && pos1_7)
                Ganador(1);
            else if (pos1_2 && pos1_5 && pos1_8)
                Ganador(1);
            else if (pos1_3 && pos1_6 && pos1_9)
                Ganador(1);
            else if (pos1_1 && pos1_5 && pos1_9)
                Ganador(1);
            else if (pos1_3 && pos1_5 && pos1_7)
                Ganador(1);

            else if (pos2_1 && pos2_2 && pos2_3)
                Ganador(2);
            else if (pos2_4 && pos2_5 && pos2_6)
                Ganador(2);
            else if (pos2_7 && pos2_8 && pos2_9)
                Ganador(2);
            else if (pos2_1 && pos2_4 && pos2_7)
                Ganador(2);
            else if (pos2_2 && pos2_5 && pos2_8)
                Ganador(2);
            else if (pos2_3 && pos2_6 && pos2_9)
                Ganador(2);
            else if (pos2_1 && pos2_5 && pos2_9)
                Ganador(2);
            else if (pos2_3 && pos2_5 && pos2_7)
                Ganador(2);

        }

        private void Ganador(int jugador)
        {
            txtGanador.Text = "Jugador Ganador: "+jugador;
            MessageBox.Show("Jugador Ganador " + jugador,"Felicidades",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            iniciado = false;
            txtEstado.Text = "Juego: Termindado";
        }
    }
}
