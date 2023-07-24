using System.Collections;

int[] array = new int[5];

ArrayList list = new ArrayList();
list.Add(10);
list.Add("hola");

foreach (var item in list)
{
    Console.WriteLine(item);
}
