Console.WriteLine("ingrese un numero para el tamaño del arreglo.");
int n = int.Parse(Console.ReadLine());
//Declaramos el arreglo y a su vez le asignamos memoria
int[] arreglo=new int[n];
Console.WriteLine("Ingrese los valores del arreglo");
//Pedimos el valor por cada elemento del arreglo
for (int j=0; j < arreglo.Length; j++)
{
    Console.Write("Valor del sub-indice ["+j+"]:");
    arreglo[j]=int.Parse(Console.ReadLine());
}
//Recorrer el arreglo para mostrar
for (int j = 0; j < arreglo.Length; j++)
{
    Console.WriteLine(arreglo[j]);
}