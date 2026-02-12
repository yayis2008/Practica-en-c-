namespace ProgramacionEstructurada22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas, edadPersona;
            string nombrePersona;

            Console.Write("Ingresa la cantidad de personas a clasificar:");
            while (!int.TryParse(Console.ReadLine(), out cantidadPersonas) || cantidadPersonas <=0)
            {
                Console.Write("Porfavor ingrese un numero mayor a 0:");
            }


            if (cantidadPersonas == 1)
            {
                Console.Write("Ingresa el nombre de la persona: ");
                nombrePersona = Console.ReadLine();
                
                Console.Write("Ingresa el edad de la persona: ");
               while (!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
               {
                    Console.WriteLine("Edad invalida. Ingrese solo numeros:");
                }

                if (edadPersona >= 18)
                {
                    Console.WriteLine(nombrePersona + " Es mayor de edad");
                }
                else
                {
                    Console.WriteLine(nombrePersona + " Es menor de edad");
                }
            }
            else
            { 
                List<string> nombresPersonasMayores = new List<string>();
                List<int> edadesPersonasMayores = new List<int>();

                List<string> nombresPersonasMenores = new List<string>();
                List<int> edadesPersonasMenores = new List<int>();

                List<string> nombrestodas = new List<string>();
                List<int> edadestodas = new List<int>();

                for (int i = 1; i <= cantidadPersonas; i++)
                {
                    Console.Write("Ingresa el nombre de la persona " + i + ":");
                    nombrePersona = Console.ReadLine();
                    Console.Write("Ingresa el edad de la persona " + i + ":");
                    while(!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
                    {
                        Console.Write("Edad invalida. Ingrese solo numeros :");
                    }

                    if (edadPersona >= 18)
                    {

                        nombrestodas.Add(nombrePersona);
                        edadestodas.Add(edadPersona);

                        nombresPersonasMayores.Add(nombrePersona);
                        edadesPersonasMayores.Add(edadPersona);
                    }
                    else
                    {
                        nombresPersonasMenores.Add(nombrePersona);
                        edadesPersonasMenores.Add(edadPersona);
                    
                    }
                }

                Console.WriteLine("--Lista General");
                Console.WriteLine("");
                Console.WriteLine("");

                for  (int i = 0; i < nombrestodas.Count; i++)
                {
                    Console.WriteLine(nombrestodas[i] + "-" + edadestodas[i]);
                }

                Console.WriteLine("--Personas Mayores--");
                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < nombresPersonasMayores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMayores[i] + " - " + edadesPersonasMayores[i]);
                }

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("--Personas Menores--");
                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < nombresPersonasMenores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMenores[i] + " - " + edadesPersonasMenores[i]);
                }
            }
        }
    }
}

