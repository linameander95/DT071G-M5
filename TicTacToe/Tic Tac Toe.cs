using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1() /*startar windows forms komponenten*/
        {
            InitializeComponent();
        }
        //gör en string av spelbrädet och sätter currentTurn till 0
        String[] gameBoard = new string[9];
        int currentTurn = 0;
        //funktion som säger vems tur det är baserat på jämna och ojämna nummer
        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        //funktion som kollar efter en vinnare genom att kontrollera om någon av de vinnande kombinationerna bara har X eller O i sig
        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[3] + gameBoard[5] + gameBoard[8];
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("O har vunnit!", "Vi har en vinnare!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("X har vunnit!", "Vi har en vinnare!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //kör funktionen för att kolla om det är oavgjort
                checkDraw();
            }
        }
        //återställer spelbrädet
        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameBoard = new string[9];
            currentTurn = 0;
        }
        //kollar om det blivit oavgjort genom att spelbrädet är fyllt men ingen vinnare utsetts
        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i<gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; } //räknar ut om brädet är fullt genom att räkna hur många turer som gått
                if (counter == 9) //spelbrickan har 9 rutor, därav 9
                {
                    reset();
                    MessageBox.Show("Det är oavgjort", "Ingen vinner :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //skickar ut ett meddelande via en popup till användaren att det blivit oavgjort
                }
            }
        }
        //en funktion för varje ruta på spelbrickan som triggas när någon klickar på den
        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++; //justerar vems tur det är genom att lägga till 1 på currentTurn
            gameBoard[0] = returnSymbol(currentTurn); //variabel för symbolen som representerar vems tur det är 
            button1.Text = gameBoard[0]; //placerar variabeln i rutan som klickats på spelbrädet
            checkForWinner(); //kör funktionen för att kolla om någon vunnit
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            button2.Text = gameBoard[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            button3.Text = gameBoard[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            button4.Text = gameBoard[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            button5.Text = gameBoard[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            button6.Text = gameBoard[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            button7.Text = gameBoard[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            button8.Text = gameBoard[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            button9.Text = gameBoard[8];
            checkForWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
