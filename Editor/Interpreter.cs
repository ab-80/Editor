using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Editor
{

    class Interpreter
    {
        public Interpreter()
        {

        }


        public void Interpret(string code)
        {

            char token;
            for(int i = 0; i < code.Length; i++)
            {
                token = code[i];
                string tokenString = token.ToString();
                
                int number;


                if(Int32.TryParse(tokenString, out number))
                {
                    int t = 9;//testing
                }

            }
            
        }

        public ArrayList Run(string code)
        {
            
            ArrayList alist = new ArrayList();
            StreamReader t = new StreamReader(code);
            while (!t.EndOfStream)
            {
                alist.Add(t.ReadLine());
            }

            return alist;
        }
    }



}
