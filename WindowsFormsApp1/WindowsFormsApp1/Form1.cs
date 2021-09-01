using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Analizador : Form
    {
        public Analizador()
        {
            InitializeComponent();
        }

        int tokenllevado = 0;     //llevo Token SIMBOLOS


        private void textBox1_TextChanged(object sender, EventArgs e)//Textbox derecha
        {

        }

        private void buttom_Click(object sender, EventArgs e)
        {
             string cadenatokens = txtEntrada.Text;
             cadenatokens += "$";
             Analizador_Lexico(cadenatokens);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)//Textbox izquierda
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Analizador_Lexico(string cadena)
        {
            dataGridView1.Rows.Clear();
            int inicioestado = 0;            //Estado 0    
            int estadoactaual = 0;        //Estado en el que me encuentro
            char cadenaconcatenar;         //Cadena que compara los token's
            string token = "";            //Concatena lo analizado
            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                switch (estadoactaual)
                {
                    case 0:
                        switch (cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoactaual = 0; //si es espacio o salto de linea o tab sigue en el estado 0
                                break;
                        //comparar letras minusculas
                            case 'a':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'b':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'c':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'd':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'e':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'f':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'g':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'h':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'i':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'j':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'k':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'l':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'm':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'n':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'o':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'p':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'q':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'r':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 's':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 't':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'u':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'v':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'w':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'x':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'y':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'z':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            //COMPARAR LETRAS MAYUSCULAS
                            case 'A':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'B':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'C':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'D':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'E':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'F':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'G':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'H':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'I':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'J':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'K':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'L':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'M':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'N':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'O':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'P':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'Q':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'R':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'S':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'T':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'U':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'V':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'W':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'X':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'Y':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            case 'Z':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 1;        //pasa al estado 1
                                break;
                            //numeros
                            case '0':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '1':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '2':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '3':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '4':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '5':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '6':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '7':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '8':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            case '9':
                                token += cadenaconcatenar;   //Concatena
                                estadoactaual = 2;        //pasa al estado 2
                                break;
                            //Todo lo demas
                            case ';':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case ',':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '(':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case ')':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '{':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '}':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '+':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '-':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '*':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '/':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '!':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '=':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '<':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '>':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '|':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '&':
                                token += cadenaconcatenar;
                                estadoactaual = 3;
                                break;
                            case '$':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            case '_':
                                token += cadenaconcatenar;
                                estadoactaual = 20;
                                inicioestado = inicioestado - 1;
                                break;
                            default:
                                token += cadenaconcatenar;
                                break;
                        }
                        break;

                    case 1:
                            if (cadenaconcatenar == 'a' || cadenaconcatenar == 'A' ||
                                cadenaconcatenar == 'b' || cadenaconcatenar == 'B' ||
                                cadenaconcatenar == 'c' || cadenaconcatenar == 'C' ||
                                cadenaconcatenar == 'd' || cadenaconcatenar == 'D' ||
                                cadenaconcatenar == 'e' || cadenaconcatenar == 'E' ||
                                cadenaconcatenar == 'f' || cadenaconcatenar == 'F' ||
                                cadenaconcatenar == 'g' || cadenaconcatenar == 'G' ||
                                cadenaconcatenar == 'h' || cadenaconcatenar == 'H' ||
                                cadenaconcatenar == 'i' || cadenaconcatenar == 'I' ||
                                cadenaconcatenar == 'j' || cadenaconcatenar == 'J' ||
                                cadenaconcatenar == 'k' || cadenaconcatenar == 'K' ||
                                cadenaconcatenar == 'l' || cadenaconcatenar == 'L' ||
                                cadenaconcatenar == 'm' || cadenaconcatenar == 'M' ||
                                cadenaconcatenar == 'n' || cadenaconcatenar == 'N' ||
                                cadenaconcatenar == 'o' || cadenaconcatenar == 'O' ||
                                cadenaconcatenar == 'p' || cadenaconcatenar == 'P' ||
                                cadenaconcatenar == 'q' || cadenaconcatenar == 'Q' ||
                                cadenaconcatenar == 'r' || cadenaconcatenar == 'R' ||
                                cadenaconcatenar == 's' || cadenaconcatenar == 'S' ||
                                cadenaconcatenar == 't' || cadenaconcatenar == 'T' ||
                                cadenaconcatenar == 'u' || cadenaconcatenar == 'U' ||
                                cadenaconcatenar == 'v' || cadenaconcatenar == 'V' ||
                                cadenaconcatenar == 'w' || cadenaconcatenar == 'W' ||
                                cadenaconcatenar == 'x' || cadenaconcatenar == 'X' ||
                                cadenaconcatenar == 'y' || cadenaconcatenar == 'Y' ||
                                cadenaconcatenar == 'z' || cadenaconcatenar == 'Z' ||
                                cadenaconcatenar == '1' || cadenaconcatenar == '2' ||
                                cadenaconcatenar == '3' || cadenaconcatenar == '4' ||
                                cadenaconcatenar == '5' || cadenaconcatenar == '6' ||
                                cadenaconcatenar == '7' || cadenaconcatenar == '8' ||
                                cadenaconcatenar == '9' || cadenaconcatenar == '0' ||
                                cadenaconcatenar == '_')
                            {
                                token += cadenaconcatenar;
                                estadoactaual = 1;
                            }
                            else
                            {
                                estadoactaual = 20;       //Estado de aceptacion
                                inicioestado = inicioestado - 2; //****************** antes tenia 1 en lugar de 2*******//
                        }
                        break;
                    case 2:
                        if (cadenaconcatenar == '1' || cadenaconcatenar == '2' ||
                            cadenaconcatenar == '3' || cadenaconcatenar == '4' ||
                            cadenaconcatenar == '5' || cadenaconcatenar == '6' ||
                            cadenaconcatenar == '7' || cadenaconcatenar == '8' ||
                            cadenaconcatenar == '9' || cadenaconcatenar == '0' ||
                            cadenaconcatenar == '.')
                        {
                            token += cadenaconcatenar;
                            estadoactaual = 2;
                        }
                        else
                        {
                            estadoactaual = 20;       //Estado de aceptacion
                            inicioestado = inicioestado - 2; //****************** antes tenia 1 en lugar de 2*******//
                        }
                        break;
                    case 3:
                        if (cadenaconcatenar == '=' || cadenaconcatenar == '|' || cadenaconcatenar == '&')
                        {
                            token += cadenaconcatenar;
                            estadoactaual = 3;
                        }
                        else
                        {
                            estadoactaual = 20;       //Estado de aceptacion
                            inicioestado = inicioestado - 2; //****************** antes tenia 1 en lugar de 2*******//
                        }
                        break;
                    case 20:                                     //Estado de aceptacion
                        estadoactaual = 0;                 //regresa al estado 0
                        TokenValidos(token);                   //Token validos en el data
                        token = "";                           //Vacia la cadena 
                        break;


                }
            }
        }

        //*******************************************//    
        //-----------METODO TOKEN VALIDOS------------//
        //*******************************************// 
        private void TokenValidos(string lexema)
        {
            tokenllevado = dataGridView1.Rows.Add();
            Decimal i = 0;
            bool result = Decimal.TryParse(lexema, out i);
            bool result2 = false;
            //Palabaras reservadas
            if (lexema != "int" || lexema != "float" || lexema != "char" ||
                lexema != "void" || lexema != "if" || lexema != "else" ||
                lexema != "while" || lexema != "return" )
            {
                result2 = lexema.All(c => Char.IsLetterOrDigit(c) || c == '_');
            }

            if (lexema=="int") 
            { 
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
            }
            else if(lexema=="float")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
            }
            else if (lexema == "char")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
            }
            else if (lexema == "void")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
            }
            else if (lexema == ";")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "PuntoComa";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 2;
            }
            else if (lexema == ",")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Coma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 3;
            }
            else if (lexema == "(")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Parantesis";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 4;
            }
            else if (lexema == ")")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Parentesis";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 5;
            }
            else if (lexema == "{")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Corchete";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 6;
            }
            else if (lexema == "}")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Corchete";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 7;
            }
            else if (lexema == "=")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Igual";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 8;
            }
            else if (lexema == "if")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Si condicional";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 9;
            }
            else if (lexema == "while")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Ciclo While";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 10;
            }
            else if (lexema == "return")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Retornar";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 11;
            }
            else if (lexema == "else")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Si no condicional";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 12;
            }
            else if (result == true)
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Constante";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 13;
            }
            else if (result2 == true)
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "id";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 1;
            }
            else if (lexema == "+")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opSuma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 14;
            }
            else if (lexema == "-")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opSuma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 14;
            }
            else if (lexema == "||")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opLogico";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 15;
            }
            else if (lexema == "&&")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opLogico";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 15;
            }
            else if (lexema == "*")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opMultiplicacion";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 16;
            }
            else if (lexema == "/")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opMultiplicacion";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 16;
            }
            else if (lexema == "==")
            {
                 dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                 dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                 dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == "<")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == "<=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == ">")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == ">=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == "!=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
            }
            else if (lexema == "$")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "SigPesos";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 18;
            }
            else 
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Error";
            }

            
        }


    }//Fin Clase
}//Fin Proyecto

