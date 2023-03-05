using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double peso, altura, imc;
        char sexo;

        double Peso()
        {
            double peso = 0.0;

            do
            {
                Console.WriteLine("Digite o peso");
                peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (peso <= 0.0);

            return peso;
        }

        double Altura()
        {
            double altura = 0.0;

            do
            {
                Console.WriteLine("Digite a altura");
                altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (altura <= 0.0);

            return altura;
        }

        char Sexo()
        {
            char sexo;

            do
            {
                Console.WriteLine("Digite o sexo");
                sexo = char.Parse(Console.ReadLine());

            } while (sexo != 'f' && sexo != 'F' && sexo != 'm' && sexo != 'M');

            return sexo;
        }

        double CalculoIMC()
        {
            imc = peso / Math.Pow(altura, 2.0);

            return imc;
        }

        void IMCMasculino()
        {
            if (imc < 20.7)
            {
                Console.WriteLine("ABAIXO DO PESO");
            }
            else
            {
                if (imc <= 26.4)
                {
                    Console.WriteLine("PESO IDEAL");
                }
                else
                {
                    if (imc <= 27.8)
                    {
                        Console.WriteLine("POUCO ACIMA DO PESO");
                    }
                    else
                    {
                        if (imc <= 31.1)
                        {
                            Console.WriteLine("ACIMA DO PESO");
                        }
                        else
                        {
                            Console.WriteLine("OBESIDADE");
                        }
                    }
                }
            }
        }

        void IMCFeminino()
        {
            if (imc < 19.1)
            {
                Console.WriteLine("ABAIXO DO PESO");
            }
            else
            {
                if (imc <= 25.8)
                {
                    Console.WriteLine("PESO IDEAL");
                }
                else
                {
                    if (imc <= 27.3)
                    {
                        Console.WriteLine("POUCO ACIMA DO PESO");
                    }
                    else
                    {
                        if (imc <= 32.3)
                        {
                            Console.WriteLine("ACIMA DO PESO");
                        }
                        else
                        {
                            Console.WriteLine("OBESIDADE");
                        }
                    }
                }
            }

        }

        peso = Peso();
        altura = Altura();
        sexo = Sexo();

        imc = CalculoIMC();

        if (sexo == 'm' || sexo == 'M')
        {
            IMCMasculino();
        }
        else
        {
            IMCFeminino();
        }

    }

}
