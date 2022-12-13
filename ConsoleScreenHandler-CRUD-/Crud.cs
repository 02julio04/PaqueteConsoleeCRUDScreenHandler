using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackConsoleeCRUDScreenHandler
{
    public class Crud
    {
        List<Persona> dataset = new List<Persona>();
        string id, nombre, apellido;
        int edad;

        public void CrearRegistro()
        {
            Console.WriteLine("Registro");
            Console.WriteLine("\n");
            Console.WriteLine("Digite su id: ");
            id = Console.ReadLine();

            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());

            dataset.Add(new Persona(id, nombre, apellido, edad));
            Console.WriteLine("Informacion guardada");
        }
        private bool lista_vacia()
        {
            if (dataset.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void lista()
        {
            if (lista_vacia()==true)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("Total de registros : " +dataset.Count);
                Console.WriteLine("----Lista----");
                foreach (Persona item in dataset)
                {
                    imprimir(item);
                }
            }
            Console.WriteLine("\n");
        }
        private void imprimir(Persona dato)
        {
            Console.WriteLine("------------");
            Console.WriteLine("| Id : {0} | nombre : {1} | apellido : {2} | edad : {3}", dato.Id,dato.nombre,dato.apellido,dato.edad);
            
        }
        public void Eliminar()
        {
            string buscar;
            if (lista_vacia()==true)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.Write("Digite su Id para eliminar:");
                buscar = Console.ReadLine();
                foreach (var item in dataset)
                {
                    if (buscar==item.Id)
                    {
                        Console.WriteLine("| Id : {0} | nombre : {1} | apellido : {2} | edad : {3}", item.Id, item.nombre, item.apellido, item.edad);
                       dataset.Remove(item);
                        Console.WriteLine("Dato eliminado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
        public void actualizar()
        {
            if (lista_vacia()==true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }else
            {
                Persona per = new Persona();
                string buscar;
                Console.WriteLine("Digite su id para actualizar: ");
                buscar= Console.ReadLine();

                foreach (Persona item in dataset)
                {
                    if (buscar==item.Id)
                    {
                        Console.WriteLine("| Id : {0} | nombre : {1} | apellido : {2} | edad : {3}", item.Id, item.nombre, item.apellido, item.edad);
                        
                        Console.WriteLine("------------");
                        Console.WriteLine("Digite su id:");
                        per.Id = Console.ReadLine();
                        item.Id = per.Id;
                        Console.WriteLine("Ingrese su nombre: ");
                        per.nombre = Console.ReadLine();
                        item.nombre = per.nombre;
                        Console.WriteLine("Ingrese su apellido: ");
                        per.apellido = Console.ReadLine();
                        item.apellido = per.apellido;
                        Console.WriteLine("Ingrese su edad: ");
                        per.edad= int.Parse(Console.ReadLine());
                        item.edad = per.edad;
                        Console.WriteLine("\n");
                        Console.WriteLine("Datos actualizados");
                    }
                }
            }

        }
        public void buscar()
        {
            if (lista_vacia()==true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                string buscar;
                Console.WriteLine("Ingrese su id para buscar: ");
                buscar = Console.ReadLine();
                foreach (Persona item in dataset)
                {
                    if (buscar==item.Id)
                    {
                        Console.WriteLine("| Id : {0} | nombre : {1} | apellido : {2} | edad : {3}", item.Id, item.nombre, item.apellido, item.edad);
                       

                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
