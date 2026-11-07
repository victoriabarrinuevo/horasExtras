Console.WriteLine("Cálculo de horas extras");

decimal salarioHoraBase = 0.0m;
double totalHorasTrabalhadas = 0;
double totalHorasExtras = 0;

const double acrescimoHE = 0.4;

Console.Write("Informe o seu salário base: ");
salarioHoraBase = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Informe o seu total de horas: ");
totalHorasTrabalhadas = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Informe o seu total de horas extras: ");
totalHorasExtras = Convert.ToDouble(Console.ReadLine()!);

decimal valorBase = Convert.ToDecimal(totalHorasTrabalhadas) 
                    * salarioHoraBase;

decimal valorHE = salarioHoraBase 
                    * Convert.ToDecimal(acrescimoHE + 1)
                    * Convert.ToDecimal(totalHorasExtras);

decimal valorTotal = valorBase + valorHE;

Console.WriteLine($"Seu salário é de {valorTotal:C2}, composto de {valorBase:C2} base e {valorHE:C2} de extras");
