using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Para el uso de archivos de texto
using System.Collections; //Para el uso de TADS pila, cola, etc.
using WindowsFormsApp1.ClsNodo; //clase Nodo


namespace WindowsFormsApp1
{

public partial class Analizador : Form
    {
        
        public Analizador()
        {
            InitializeComponent();
        }

        int tokenllevado = 0;     //llevo Token SIMBOLOS
        int no_error = 0;
        int[,] tabla = new int[84, 39];//Tabla para analizador sintactico
        int[,] reglas = new int[43, 2];//Tabla de reglas
        List<object> tabsim = new List<object>();
        List<string> errores = new List<string>();

        Stack<Nodo> pila = new Stack<Nodo>(); // Creación de la pila.
        List<Nodo> tokens_elements = new List<Nodo>();


        private void textBox1_TextChanged(object sender, EventArgs e)//Textbox derecha
        {

        }

        private void buttom_Click(object sender, EventArgs e)
        {

            llenar_tabla();
            llenar_reglas();
            pila.Push(new Nodo() { estado = 0 }); //pila.Push(0);

            string cadenatokens = txtEntrada.Text;
            cadenatokens += "$";
            Analizador_Lexico(cadenatokens);
            Analizador_Sintactico();
            Mostrar_Errores();
            pila.Clear();
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
                tokens_elements.Add(new Nodo() { estado = 0 , lexema = "int"});
            }
            else if(lexema=="float")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
                tokens_elements.Add(new Nodo() { estado = 0, lexema = "float" });
            }
            else if (lexema == "char")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
                tokens_elements.Add(new Nodo() { estado = 0, lexema = "char" });
            }
            else if (lexema == "void")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Tipo de dato";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 0;
                tokens_elements.Add(new Nodo() { estado = 0, lexema = "void" });
            }
            else if (lexema == ";")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "PuntoComa";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 2;
                tokens_elements.Add(new Nodo() { estado = 2, lexema = ";" });
            }
            else if (lexema == ",")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Coma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 3;
                tokens_elements.Add(new Nodo() { estado = 3, lexema = "," });
            }
            else if (lexema == "(")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Parantesis";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 4;
                tokens_elements.Add(new Nodo() { estado = 4, lexema = "(" });
            }
            else if (lexema == ")")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Parentesis";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 5;
                tokens_elements.Add(new Nodo() { estado = 5, lexema = ")" });
            }
            else if (lexema == "{")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Corchete";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 6;
                tokens_elements.Add(new Nodo() { estado = 6, lexema = "{" });
            }
            else if (lexema == "}")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Corchete";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 7;
                tokens_elements.Add(new Nodo() { estado = 7, lexema = "}" });
            }
            else if (lexema == "=")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Igual";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 8;
                tokens_elements.Add(new Nodo() { estado = 8, lexema = "=" });
            }
            else if (lexema == "if")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Si condicional";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 9;
                tokens_elements.Add(new Nodo() { estado = 9, lexema = "if" });
            }
            else if (lexema == "while")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Ciclo While";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 10;
                tokens_elements.Add(new Nodo() { estado = 10, lexema = "while" });
            }
            else if (lexema == "return")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Retornar";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 11;
                tokens_elements.Add(new Nodo() { estado = 11, lexema = "return" });
            }
            else if (lexema == "else")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Si no condicional";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 12;
                tokens_elements.Add(new Nodo() { estado = 12, lexema = "else" });
            }
            else if (result == true)
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Constante";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 13;
                tokens_elements.Add(new Nodo() { estado = 13, lexema = lexema });
            }
            else if (result2 == true)
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "id";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 1;
                tokens_elements.Add(new Nodo() { estado = 1, lexema = lexema });
            }
            else if (lexema == "+")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opSuma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 14;
                tokens_elements.Add(new Nodo() { estado = 14, lexema = "+" });
            }
            else if (lexema == "-")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opSuma";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 14;
                tokens_elements.Add(new Nodo() { estado = 14, lexema = "-" });
            }
            else if (lexema == "||")
            {
                dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opLogico";
                dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 15;
                tokens_elements.Add(new Nodo() { estado = 15, lexema = "||" });
            }
            else if (lexema == "&&")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opLogico";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 15;
                tokens_elements.Add(new Nodo() { estado = 15, lexema = "&&" });
            }
            else if (lexema == "*")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opMultiplicacion";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 16;
                tokens_elements.Add(new Nodo() { estado = 16, lexema = "*" });
            }
            else if (lexema == "/")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opMultiplicacion";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 16;
                tokens_elements.Add(new Nodo() { estado = 16, lexema = "/" });
            }
            else if (lexema == "==")
            {
                 dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                 dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                 dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = "==" });
            }
            else if (lexema == "<")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = "<" });
            }
            else if (lexema == "<=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = "<=" });
            }
            else if (lexema == ">")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = ">" });
            }
            else if (lexema == ">=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = ">=" });
            }
            else if (lexema == "!=")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "opRelacional";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 17;
                tokens_elements.Add(new Nodo() { estado = 17, lexema = "!=" });
            }
            else if (lexema == "$")
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "SigPesos";
                    dataGridView1.Rows[tokenllevado].Cells["Numero"].Value = 18;
                tokens_elements.Add(new Nodo() { estado = 18, lexema = "$" });
            }
            else 
            {
                    dataGridView1.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataGridView1.Rows[tokenllevado].Cells["Token"].Value = "Error";
            }

            
        }

        private void llenar_tabla()
        {
            int f = 0;
            try
            {
                StreamReader sr = new StreamReader("GR2slrTable.txt");
                string linea ;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] arreglo = linea.Split("\t".ToCharArray());
                    

                        for (int c=1; c<40;c++)
                        {
                            tabla[f, c-1] = Convert.ToInt32(arreglo[c]);
                        }

                    f++;
                }

                sr.Close(); //cerramos archivo
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
            }


        
            Console.ReadLine();

        }

        private void llenar_reglas()
        {
            int f = 0;
            try
            {
                StreamReader sr = new StreamReader("GR2slrRulesId.txt");
                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] arreglo = linea.Split("\t".ToCharArray());



                    for (int c = 0; c < 2; c++)
                    {
                        // MessageBox.Show(arreglo[c]);
                        reglas[f, c] = Convert.ToInt32(arreglo[c]);
                    }
                    f++;
                }

                sr.Close(); //cerramos archivo
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
            }



            Console.ReadLine();

        }

        private void Analizador_Sintactico()
        {
            int Fila,Columna,Accion;
            Nodo N, Listlex, nodo, aux, raiz;
            N = pila.Peek();
            Fila = N.estado;
            Listlex = tokens_elements.ElementAt(0);
            Columna = Listlex.estado;
            Accion = tabla[Fila, Columna];
            while (tokens_elements.Count != 0)
            {

                if (Accion > 0)
                {
                    pila.Push(new Nodo() { estado = Columna, lexema = Listlex.lexema});//pila.Push(Columna);
                    pila.Push(new Nodo() { estado = Accion });//pila.Push(Accion);
                    tokens_elements.RemoveAt(0);
                   N = pila.Peek();
                    Fila = N.estado;
                    Listlex = tokens_elements.ElementAt(0);
                    Columna = Listlex.estado;
                    Accion = tabla[Fila, Columna];
                }
                else
                {
                    if (Accion < -1)
                    {
                        Accion = Math.Abs(Accion);
                        //Column = reglas[Accion - 1, 0];
                        //toPop = reglas[Accion - 1, 1];
                        Accion = Accion -1;
                        nodo = new Nodo();


                        //else
                        //{
                            
                            if (Accion == 2)//Definiciones -> Definicion Definiciones
                            {
                                pila.Pop();
                                aux = pila.Pop();
                                pila.Pop();
                                nodo = pila.Pop();
                                nodo.siguiente = aux;

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 3)//Definicion -> DefVar
                            {
                                pila.Pop();
                                nodo = pila.Pop();

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 4) //Definicion->DefFunc
                            {
                                pila.Pop();
                                nodo = pila.Pop();

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 5)//DefVar -> tipo id ListaVar ;
                            {
                                nodo = new DefVar(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 7)//ListaVar -> , id ListaVar /***************Tal vez error aqui***************/
                            { 
                                nodo = new ListaVar(pila);


                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 8)//DefFunc -> tipo id ( Parametros ) BloqFunc
                            {
                                nodo = new DefFunc(pila);
                            

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 10)//Parametros -> tipo id ListaParam
                            {
                                nodo = new Parametros(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 12)//ListaParam -> , tipo id ListaParam/***************Tal vez error aqui***************/
                            {
                                nodo = new ListaParam(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 13) //BloqFunc-> { DefLocales }
                            {
                                pila.Pop();//estado
                                pila.Pop();//}
                                pila.Pop();//estado
                                nodo = pila.Pop();//DefLocales
                                pila.Pop();//estado
                                pila.Pop();//}

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 15)//DefLocales -> DefLocal DefLocales
                            {
                                pila.Pop();//estado
                                aux = pila.Pop(); //primer elemento (el más a la derecha)
                                pila.Pop();//estado
                                nodo = pila.Pop();//segundo elemento
                                nodo.siguiente = aux;//asignar el siguiente elemento

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 16)//DefLocal -> DefVar
                            {
                                pila.Pop();//estado
                                nodo = pila.Pop();//DefVar

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 17)//DefLocal -> Sentencia
                            {
                                pila.Pop();//estado
                                nodo = pila.Pop();//Sentencia

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 19)//Sentencias ->Sentencia Sentencias
                            {
                                pila.Pop();//estado
                                aux = pila.Pop(); //primer elemento (el más a la derecha)
                                pila.Pop();//estado
                                nodo = pila.Pop();//segundo elemento
                                nodo.siguiente = aux;//asignar el siguiente elemento

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 20)//Sentencia -> id = Expresion ;
                            {
                                nodo = new Asignacion(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 21)//Sentencia -> if ( Expresion ) SentenciaBloque Otro
                            {
                                nodo = new IF(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 22)//Sentencia ->while ( Expresion ) Bloque
                            {
                                nodo = new WHILE(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 23)//Sentencia -> return Expresion ;
                            {
                                nodo = new RETURN(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 24)//Sentencia -> LlamadaFunc ;
                            {
                                pila.Pop();//estado
                                pila.Pop();//;
                                pila.Pop();//estado
                                nodo = pila.Pop();//LlamadaFunc
                                                  //nodo = new R24(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 26)//Otro -> else SentenciaBloque
                            {
                                pila.Pop();//estado
                                nodo = pila.Pop();//SentenciaBloque
                                pila.Pop();//estado
                                pila.Pop();//else
                                           //nodo = new R26(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 27)//Bloque -> { Sentencias }
                            {
                                pila.Pop();
                                pila.Pop();
                                pila.Pop();
                                nodo = pila.Pop();
                                pila.Pop();
                                pila.Pop();

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 29)//Argumentos -> Expresion ListaArgumentos
                            {
                                pila.Pop();//estado
                                aux = pila.Pop(); //primer elemento (el más a la derecha)
                                pila.Pop();//estado
                                nodo = pila.Pop();//segundo elemento
                                nodo.siguiente = aux;//asignar el siguiente elemento

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 31) //ListaArgumentos->, Expresion ListaArgumentos
                            {
                                pila.Pop();//estado
                                aux = pila.Pop(); //primer elemento (el más a la derecha)
                                pila.Pop();//estado
                                nodo = pila.Pop();//segundo elemento
                                nodo.siguiente = aux;//asignar el siguiente elemento
                                pila.Pop();//estado
                                pila.Pop();//,

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 32)//Expresion -> LlamadaFunc
                            {
                                pila.Pop();//estado
                                nodo = pila.Pop();//LlamadaFunc

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                            else if (Accion == 33)//Expresion -> id
                            {
                                //pila.Pop();
                                nodo = new Id(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                       else if (Accion == 34)//Expresion -> constante
                       {
                            //pila.Pop();
                            nodo = new Constante(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción

                        }
                            else if (Accion == 35)//LlamadaFunc -> id ( Argumentos )
                            {
                                nodo = new LlamadaFunc(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                        else if (Accion == 36)//SentenciaBloque -> Sentencia
                        {
                            pila.Pop();//estado
                            nodo = pila.Pop();//Sentencia

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                        else if (Accion == 37)//SentenciaBloque -> Bloque
                        {
                            pila.Pop();//estado
                            nodo = pila.Pop();//Bloque

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                        else if (Accion == 38)//Expresion -> ( Expresion )
                        {
                                pila.Pop();//estado
                                pila.Pop();//)
                                pila.Pop();//estado
                                nodo = pila.Pop();//Expresion
                                pila.Pop();//estado
                                pila.Pop();//(

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                        else if (Accion >= 39 && Accion <= 42)//Expresion -> Expresion op(x) Expresion
                        {
                            nodo = new Operacion(pila);

                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                        }
                        else
                        {
                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna= reglas[Accion, 0];
                            nodo.estado = Columna;
                            pila.Push(nodo);
                            pila.Push(new Nodo() { estado = tabla[Fila, Columna] });
                        }
                            /*N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Columna = reglas[Accion, 0];//obtenemos la columna de las reglas en la posición accion, 0
                            nodo.estado = Columna;//al  nodo le ponemos su estado el cual es la columna que acabamos de definir
                            pila.Push(nodo);//metemos el nodo con el estado
                            Accion = tabla[Fila, Columna];//Nuestra nueva acción es igual a lo que saquemos de la tabla en la posición fila,columna
                            pila.Push(new Nodo() { estado = Accion });//metemos a la pila el nuevo estado que es la acción
                            /***********************************************/
                            N = pila.Peek();//sacamos un nodo.estado de la pila
                            Fila = N.estado;//convertimos el nodo.estdo en entero y lo convertimos en fila
                            Listlex = tokens_elements.ElementAt(0);//asigamos el siguiente lexema que vamos a usar
                            Columna = Listlex.estado;//al lexema le sacamos el estado que tiene y lo convertimos en columna
                            Accion = tabla[Fila, Columna];//obtenemos el numero de accion 
                        //}
                    }
                    else
                    {
                        if (Accion == 0)
                        {
                            MessageBox.Show("Syntax error. No entro al estado de aceptación");
                            errores.Add("Syntax Error");
                            tokens_elements.Clear();
                        }
                        else if (Accion == (-1))
                            {
                                raiz = new Nodo();
                                pila.Pop();//estado
                                raiz = pila.Pop();//raiz
                                raiz.validatipos(tabsim, errores);
                                tokens_elements.Clear();
                            }
                    }
                }
            }


        }

        private void Mostrar_Errores()
        {
            int tamlis = errores.Count;
            if (tamlis != 0)
            {
                for (int i = 0; i < tamlis; i++)
                {
                    no_error = dataGridView2.Rows.Add();
                    dataGridView2.Rows[no_error].Cells["Error"].Value = errores[i];
                }
                
                    
            }
            else
            {
                MessageBox.Show("¡Código sin errores!");
            }
        }
        private void limpiar_errores()
        {
            int tamlis = errores.Count;
            for (int i = 0; i < tamlis; i++)
            {
               dataGridView2.Rows.Clear();
            }
        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar_errores();
            errores.Clear();
            tabsim.Clear();
            
        }
    }//Fin Clase
}//Fin Proyecto

