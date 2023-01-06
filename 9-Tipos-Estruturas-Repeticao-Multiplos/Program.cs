// Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
// Para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0).

int multiplo3 = 0;

for (int i = 1; i <= 21; i++)
{
    if (i % 3 == 0)
    {
        multiplo3 = multiplo3 + 1;
    }
 }

Console.WriteLine("Os números multiplos por 3 são: " + multiplo3);