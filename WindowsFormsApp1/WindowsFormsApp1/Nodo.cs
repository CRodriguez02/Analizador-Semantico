using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ClsNodo
{

    public static class Global
    {
        public static string ambitoglb;
        public static char Tipogbl;
        public static string Cadenapagbl;
    }
    public class Nodo
    {

        public string lexema;
        public string ambito;
        public char Tipodato;
        public string clase;
        public int estado;
        public string Cadenapa;
        public Nodo siguiente;

        public Nodo(String _ambito)
        {
            lexema = "";
            ambito = _ambito;
            //Tipodato = ;
            clase = "";
            siguiente = null;
            Cadenapa = "";
            estado = 0;

        }
        public Nodo()
        {
            lexema = "";
            ambito = "";
            //this.Tipodato = "";
            clase = "";
            siguiente = null;
            estado = 0;

        }

        public virtual void validatipos(List<object> tabsim, List<string> errores)
        {
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
        public virtual string validacadenaparametros(string cadenapa)
        {
            return "";
        }
        public char dimetipo(Nodo tipo)
        {
            if (tipo.lexema == "int")
                return 'i';
            else if (tipo.lexema == "float")
                return 'f';
            else if (tipo.lexema == "char")
                return 'c';
            else if (tipo.lexema == "void")
                return 'v';
            else return 'v';

        }
        public bool existefunc(List<object> tabsim, string id, string ambito, string cadenapa, List<string> errores)
        {
            bool existe = false;
            foreach (Elementotabla s in tabsim)
            {
                if (s.id == id)
                {
                    existe = true;
                    //Console.WriteLine("En la funcion " + id);
                    //s.stpara += "i";
                    //MessageBox.Show("estoy buscando la i extra");
                    //MessageBox.Show("En la funcion " + id+" stpara== " + s.stpara + " >>> cadenapa=" + cadenapa);
                    if (s.stpara == cadenapa)
                        return true;
                    else
                    {
                        errores.Add("Los parametros de la llamada a funcion " + id + " dentro de la funcion " + ambito+" son incorrectos");
                    }
                }
            }
            if (!existe)
            {
                errores.Add("La funcion " + id + " no existe");
                /*Console.WriteLine("YA GUARDO EL ERROR DE FUNCION NO EXISTE");*/
            }
                
            return false;
        }
        public bool existe(List<object> tabsim, string id, char Tipodato, string ambito)
        {
            foreach (Elementotabla s in tabsim)
            {
                if (s.id == id)
                {
                    if(s.tipo==Tipodato)
                    {
                        if(s.ambito==ambito)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        public char buscartipo(List<object> tabsim, string id)
        {
            string Constante = id;
            //MessageBox.Show("Entro a buscar tipo de dato el id: "+id);
            foreach (Elementotabla s in tabsim)
            {
                if (s.id == id)
                {
                    //MessageBox.Show("Se encontro un id igual en la tabla, ya solo es buscar el tipo");
                    if (s.tipo == 'i')
                        return 'i';
                    else if (s.tipo == 'f')
                        return 'f';
                    else if (s.tipo == 'c')
                        return 'c';
                    else if (s.tipo == 'v')
                        return 'v';
                }
            }
            if (Constante.All(Char.IsDigit))
            {
                //MessageBox.Show("Se encontro un id convertido en constante que es int");
                return 'i';
            }
            else
            {
                //MessageBox.Show("Se encontro un id convertido en constante que es float");
                return 'f';
            }
        }
        public char buscartipo2(List<object> tabsim, string id, string ambito)
        {
            string Constante = id;
            foreach (Elementotabla s in tabsim)
            {
                if (s.id == id && s.ambito == ambito)
                {
                    if (s.tipo == 'i')
                        return 'i';
                    else if (s.tipo == 'f')
                        return 'f';
                    else if (s.tipo == 'c')
                        return 'c';
                    else if (s.tipo == 'v')
                        return 'v';
                }

            }
            if (Constante.All(Char.IsDigit))
            {
                 return 'i';
            }
            else
            {
               return 'f';
            }
            
        }
        public string buscarAmbito(List<object> tabsim, string id, char Tipodato)
        {
            foreach (Elementotabla s in tabsim)
            {
                if (s.id == id && s.ambito != "" && s.tipo== Tipodato)
                {
                    return s.ambito;
                }
            }
            return "";
        }

        
    }

    public class Estado
    {
        public int numestado;
        public Estado(int _numestado)
        {
            numestado = _numestado;
        }
    }
    public class Elementotabla
    {
        public string id;
        public char tipo;
        public string ambito;
        public string stpara;
        public Elementotabla(string _id, char _tipo, string _ambito, string _stpara)
        {
            id = _id;
            tipo = _tipo;
            ambito = _ambito;
            stpara = _stpara;
        }
        public Elementotabla(string _id, char _tipo, string _ambito)
        {
            id = _id;
            tipo = _tipo;
            ambito = _ambito;
            stpara = "";
        }
    }
    public class Constante : Nodo
    {
        Nodo N;
        public Constante(Stack<Nodo> pila)
        {
            
            pila.Pop();
            N = pila.Pop();
            lexema = N.lexema;
            clase = "cons";
        }

        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            string Constante= N.lexema;
            ambito = Global.ambitoglb;

            if (Constante.All(Char.IsDigit))
            {
                //MessageBox.Show("Constante entera: "+N.lexema);
                if (!existe(tabsim, N.lexema, 'i', ambito))
                {
                    tabsim.Add(new Elementotabla(N.lexema, 'i', ambito));
                }
            }
            else
            {
                //MessageBox.Show("Constante flotante: " + N.lexema);
                if (!existe(tabsim, N.lexema, 'f', ambito))
                {
                    tabsim.Add(new Elementotabla(N.lexema, 'f', ambito));
                }
            }
                
        }
    }
    
    public class Id : Nodo
    {
        Nodo N;
        public Id(Stack<Nodo> pila)
        {
            pila.Pop();
            N = pila.Pop();
            lexema = N.lexema;
            clase = "id";
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            //MessageBox.Show("Lexema de Id: " + N.lexema+", Tipo dato: "+N.Tipodato);
        }
    }
    
    public class Tipo : Nodo
    {
        Nodo N;
        public Tipo(Stack<Nodo> pila)
        {
            
            pila.Pop();
            N = pila.Pop();
            lexema = N.lexema;
            clase = "tipo";
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            //MessageBox.Show("Lexema de Tipo: " + N.lexema+", Tipo dato: "+N.Tipodato);
        }
    }

    public class DefVar : Nodo //R5
    {
        Nodo tipo;
        Nodo id;
        Nodo lvar;
        public DefVar(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            pila.Pop();//;
            pila.Pop();//estado estado
            lvar = pila.Pop();//ListaVar
                              //pila.Pop();//estado
            id = new Id(pila);//id
                              //pila.Pop();//estado
            tipo = new Tipo(pila);//tipo
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
         {
            
            Tipodato = dimetipo(tipo);
            Global.Tipogbl = Tipodato;
            ambito = Global.ambitoglb;
            //MessageBox.Show("Se definio la variable con tipo de dato: " + Tipodato + " variable: " + id.lexema + " en el ambito: " + ambito);

            if (!existe(tabsim, id.lexema, Tipodato, ambito))
            {
                
                tabsim.Add(new Elementotabla(id.lexema, Tipodato, ambito));

            }
            else
               errores.Add("La variable " + id.lexema + " ya existe en el ambito "+ambito);
            Cadenapa = "";
            if (lvar != null)
                lvar.validatipos(tabsim, errores);
            ambito = "";
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
    }
    public class ListaVar : Nodo //ListaVar -> , id ListaVar
    {
        Nodo id, lvar;
        public ListaVar(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            lvar = pila.Pop();//ListaVar
                              //pila.Pop();//estado
            id = new Id(pila);//id
            pila.Pop();//estado
            pila.Pop();//,
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            ambito = Global.ambitoglb;
            Tipodato = Global.Tipogbl;
            //MessageBox.Show("Entro a Lista var la variable: " +id.lexema+" Con tipo de dato:  "+ Tipodato+ " Su ambito es: "+ambito);
            if (!existe(tabsim, id.lexema, Tipodato, ambito))
            {
                tabsim.Add(new Elementotabla(id.lexema, Tipodato, ambito));
            }
            else
                errores.Add("La variable " + id.lexema + " ya existe en el ambito "+ambito);
            if (lvar != null)
                lvar.validatipos(tabsim, errores);
            if(siguiente!=null)
                siguiente.validatipos(tabsim, errores);
        }
    }

    public class DefFunc : Nodo //R8 
    {
        Nodo id, tipo, bloqFunc, parametros;
        public DefFunc(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            bloqFunc = pila.Pop();//BloqFunc
            pila.Pop();//estado
            pila.Pop();//)
            pila.Pop();//estado
            parametros = pila.Pop();
            pila.Pop(); //estado
            pila.Pop();//(
            id = new Id(pila);//id
            tipo = new Tipo(pila);//tipo 
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            Tipodato = dimetipo(tipo);
            ambito = id.lexema;
            Global.ambitoglb = id.lexema;

            if (parametros != null)
                parametros.validatipos(tabsim, errores);
            
            //MessageBox.Show("Definiendo funcion de tipo de dato: " + Tipodato + " nombre de la funcion: " + id.lexema + " ambito: " + ambito + " Cadenapa: " + parametros.lexema);
            if (!existe(tabsim, id.lexema, Tipodato, ambito))
            {
                //MessageBox.Show("Definiendo funcion de tipo de dato: " + Tipodato + " nombre de la funcion: " + id.lexema + " ambito: " + ambito + " Cadenapa: " + parametros.lexema);
                tabsim.Add(new Elementotabla(id.lexema, Tipodato, ambito, Global.Cadenapagbl));

            }
            else
                errores.Add("La funcion " + id.lexema + " ya existe");
            Global.Cadenapagbl = "";
            if (bloqFunc != null)
                bloqFunc.validatipos(tabsim, errores);
            ambito = "";
            if (siguiente != null) 
                siguiente.validatipos(tabsim, errores);
        }

    }
    public class Parametros : Nodo //R10 
    {
        Nodo id, tipo, lparam;
        public Parametros(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            lparam = pila.Pop();//ListaParam
                                //pila.Pop();//estado
            id = new Id(pila);//id
                              //pila.Pop();//estado
            tipo = new Tipo(pila);//tipo
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            Tipodato = dimetipo(tipo);
            ambito = Global.ambitoglb;
            //MessageBox.Show("estamos en el parametros");
            //MessageBox.Show("Lo que se va a introducir es id: "+id.lexema+" Tipodato: "+ Tipodato + " ambito: "+ambito);
            if (!existe(tabsim, id.lexema, Tipodato, ambito))
            {
                tabsim.Add(new Elementotabla(id.lexema, Tipodato, ambito));

            }
            else
                errores.Add("La variable " + id.lexema + " ya fue declarada");
            //Cadenapa += tipo.lexema[0];
            Global.Cadenapagbl += tipo.lexema[0];
            if (lparam != null)
                lparam.validatipos(tabsim, errores);
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
    }
    public class ListaParam : Nodo //R12 Lista de Parametros | ListaParam -> , tipo id ListaParam
    {
        Nodo id, tipo, lparam;
        public ListaParam(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            lparam = pila.Pop();//ListaParam
                                //pila.Pop();//estado
            id = new Id(pila);//id
                              //pila.Pop();//estado
            tipo = new Tipo(pila);//tipo
            pila.Pop();//estado
            pila.Pop();//,
        }
        /*public override string validacadenaparametros(string cadenapa)
        {
            string cadenalispa = "";
            cadenapa += tipo.lexema[0];
            MessageBox.Show("Estamos en el validacadenaparametros, cadenapa es: "+ cadenapa);
            if (lparam != null)
            {
                cadenalispa = lparam.validacadenaparametros(cadenalispa);
                cadenapa += cadenalispa;
                MessageBox.Show("Estamos en el validacadenaparametros(if), cadenapa es: " + cadenapa);
                return cadenapa;
            }
            else
                return cadenapa;


        }*/
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            ambito = Global.ambitoglb;
            Tipodato = dimetipo(tipo);
            //MessageBox.Show("VALIDATIPOS LISTAPARAM");
            if (!existe(tabsim, id.lexema, Tipodato, ambito))
            {
                //MessageBox.Show("Vamos a meter al if id: "+id.lexema+" Tipodato "+Tipodato+" ambito "+ambito);
                tabsim.Add(new Elementotabla(id.lexema, Tipodato, ambito));/***/
            }
            else
                errores.Add("La variable " + id.lexema + " ya existe en el ambito"+ambito);
            Global.Cadenapagbl += tipo.lexema[0];
            //MessageBox.Show("Global.Cadenapagbl "+ Global.Cadenapagbl);
            if (lparam != null)
                lparam.validatipos(tabsim, errores);
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }

    }
    /**/public class Asignacion : Nodo //R20 
    {
        Nodo id, exp;
        public Asignacion(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            pila.Pop();//;
            pila.Pop();//estado
            exp = pila.Pop();//expresion
            pila.Pop();//estado
            pila.Pop();//=
                               //pila.Pop();//estado
            id = new Id(pila);//id
        }

        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            ambito = Global.ambitoglb;
            char Tipodato1, Tipodato2;

            Tipodato1 = buscartipo2(tabsim, id.lexema, ambito);
            //MessageBox.Show("el id es: " + id.lexema + " el tipo de dato es " + Tipodato1);

            Tipodato2 = buscartipo(tabsim, exp.lexema);
            //MessageBox.Show("la expresion es: " + exp.lexema + " el tipo de dato es " + Tipodato2);

            id.validatipos(tabsim, errores);
            exp.validatipos(tabsim, errores);
            
            if (Tipodato1 == 'c' && Tipodato2 == 'c')
            {
                Tipodato = 'c';
            }
            else
            {
                if (Tipodato1 == 'i' && Tipodato2 == 'i')
                {
                    Tipodato = 'i';
                }
                else
                {
                    if (Tipodato1 == 'f' && Tipodato2 == 'f')
                    {
                        Tipodato = 'f';
                    }
                    else
                    {
                        Tipodato = 'e';
                        errores.Add("El tipo de " + id.lexema +" en la funcion " + ambito + " es diferente al de la expresion");
                    }
                }
            }
            if (exp.siguiente != null)
                exp.siguiente.validatipos(tabsim, errores);
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
        
    }

    public class IF : Nodo //R21 Sentencia -> if ( Expresion ) SentenciaBloque Otro
    {
        Nodo _if, exp, sbloq, otro;
        public IF(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            otro = pila.Pop();//Otro
            pila.Pop();//estado
            sbloq = pila.Pop();//SentenciaBloque
            pila.Pop();//estado
            pila.Pop();//)
            pila.Pop();//estado
            exp = pila.Pop();//Expresion
            pila.Pop();//estado
            pila.Pop();//(
            pila.Pop();//estado
            _if = pila.Pop();//if
        }
        
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            if (exp != null)
                exp.validatipos(tabsim, errores);
            if (sbloq != null)
                sbloq.validatipos(tabsim, errores);
            if (otro != null)
                otro.validatipos(tabsim, errores);
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
    }
    public class WHILE : Nodo //R22
    {
        Nodo _while, exp, bloq;
        public WHILE(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            bloq = pila.Pop();//Bloque
            pila.Pop();//estado
            pila.Pop();//)
            pila.Pop();//estado
            exp = pila.Pop();//Expresion
            pila.Pop();//estado
            pila.Pop();//(
            pila.Pop();//estado
            _while = pila.Pop();//while
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            if (exp != null)
                exp.validatipos(tabsim, errores);
            if (bloq != null)
                bloq.validatipos(tabsim, errores);
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
    }

    public class RETURN : Nodo //R23
    {
        Nodo exp;
        public RETURN(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            pila.Pop();//;
            pila.Pop();//estado
            exp = pila.Pop();//Expresion
            pila.Pop();//estado
            pila.Pop();//return
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        { 
            
            ambito = Global.ambitoglb;
            Tipodato = buscartipo2(tabsim, exp.lexema, ambito);
            char tipoaux = buscartipo2(tabsim, ambito, ambito);
            //char tipoaux = buscartipo(tabsim, ambito);
            //MessageBox.Show("Entro al RETUNR y es: '" + exp.lexema + " 'su TipoDato es:" + Tipodato + " y el ambito es: " + ambito);
            //MessageBox.Show("El tipo de dato aux es: "+tipoaux);
            if (tipoaux!=Tipodato)
            {
                errores.Add("El tipo de dato que regresa " + exp.lexema + " no es el mismo que el de la funcion "+ ambito);
            }

           
        }
    }

    public class LlamadaFunc : Nodo //R35
    {
        Nodo Argu, id;
        public LlamadaFunc(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            pila.Pop();//)
            pila.Pop();//estado
            Argu = pila.Pop();//Argumentos
            pila.Pop();//estado
            pila.Pop();//(
                       //pila.Pop();//estado
            id = new Id(pila);//id
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            //Nodo aux = new Nodo(ambito);
            Nodo aux = new Nodo(Global.ambitoglb);
            //MessageBox.Show("LlamaFunc: "+ id.lexema);
            //MessageBox.Show("LlamaFunc ambito que tiene: " + Global.ambitoglb);
            Tipodato = buscartipo(tabsim, id.lexema);
            aux = Argu;
            string cadena = "";
            while (aux != null)
                {
                    char tipo2;
                if(aux.lexema!="")
                {
                    //MessageBox.Show("Entro al if porque lexema no esta vacio");
                    tipo2 = buscartipo2(tabsim, aux.lexema, Global.ambitoglb);
                    //MessageBox.Show("tipo 2: " + tipo2 + " aux.lexema: " + aux.lexema);
                    cadena += tipo2;
                }    
                    //MessageBox.Show("Cadena: " + cadena);
                    aux = aux.siguiente;
                }
            
            if (Argu != null)
                Argu.validatipos(tabsim, errores);
            if (id.lexema == "print")
                id.validatipos(tabsim, errores);
            else
            {
                //Console.WriteLine("Entra a ver si existe la funcion");
                if (!existefunc(tabsim, id.lexema, Global.ambitoglb, cadena, errores))
                {
                    id.validatipos(tabsim, errores);
                }
            }
            if (siguiente != null)
                siguiente.validatipos(tabsim, errores);
        }
    }
    public class Operacion : Nodo//R39.R40,R41,R42 
    {
        Nodo derecha, operador, izquierda;
        public Operacion(Stack<Nodo> pila)
        {
            pila.Pop();//estado
            derecha = pila.Pop(); //Expresion derecha
            pila.Pop();//estado
            operador = pila.Pop();//operador
            pila.Pop();//estado
            izquierda = pila.Pop();//Expresion izquierda
        }
        public override void validatipos(List<object> tabsim, List<string> errores)
        {
            char Tipodatoaux;
            //MessageBox.Show("OPERACION");
            Tipodato = buscartipo(tabsim, izquierda.lexema);
            Tipodatoaux = buscartipo(tabsim, derecha.lexema);
            //MessageBox.Show("El tipo de dado de: " + izquierda.lexema+" es: " + Tipodato);
            //MessageBox.Show("El tipo de dado de: " + derecha.lexema + " es: " + Tipodatoaux);
            //string Constante1 = izquierda.lexema;
            //string Constante2 = derecha.lexema;

            if (Tipodato != Tipodatoaux)
            {
                errores.Add("La operación entre " + izquierda.lexema + " " + operador.lexema + " " + derecha.lexema + " no se puede efectuar por incompatibilidad de tipos");
            }
            if (izquierda != null)
                izquierda.validatipos(tabsim, errores);
            if (derecha != null)
                derecha.validatipos(tabsim, errores);
            if (siguiente != null)
                    siguiente.validatipos(tabsim, errores);
        }

    }
}
