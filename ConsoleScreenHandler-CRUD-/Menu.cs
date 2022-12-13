using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ConsoleeCRUDScreenHandler
namespace PackConsoleeCRUDScreenHandler
{
    public class Menu:Crud
    {
        string op_menu = "";
        public void iniciar()
        {
            do
            {
                cabecera();

            } while (op_menu!="0");
        }
        private void cabecera()
        {
            Console.WriteLine("-------------------Menu------------------");
            Console.WriteLine("|1 [Crear Registro]   | 3 [Eliminar]     |");
            Console.WriteLine("|2 [Listar Registro]  | 4 [Actualizar]   |");
            Console.WriteLine("|5 [Consultar]                           |");
            Console.WriteLine("|0 [Salir]                               |");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("\n");
            Console.WriteLine("Digite su opcion:");
            op_menu=Console.ReadLine();
            selecMenu(op_menu);
        }
        private void selecMenu(string op)
        {
            if (op =="")
                return;
                switch (op)
                {
                case "1":
                    Console.Clear();
                    CrearRegistro();
                    volver_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista();
                    volver_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar();
                    volver_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    actualizar();
                    volver_menu();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    buscar();
                    volver_menu();
                    Console.ReadKey();
                    break;
                case "q":
                    Console.Clear();
                    cabecera();
                    Console.ReadKey();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                        break;
                }
        }
        private void volver_menu()
        {
            string op;
            Console.WriteLine("Digite q para volver al menu");
            op = Console.ReadLine();
            selecMenu(op);
        }


    }
}
