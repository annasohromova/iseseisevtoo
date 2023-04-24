using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class Program
{
    public static void Main()
    {
        
        int[,] array = new int[5, 5];
        Random random = new ();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(1, 100);
            }
        }

        
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int h = j + 1; h < 5; h++)
                    {
                        if (array[i, j] < array[i, h])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, h];
                            array[i, h] = temp; //Получает путь, указывающий каталог Temp.//
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int h = j + 1; h < 5; h++)
                    {
                        if (array[i, j] > array[i, h])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, h];
                            array[i, h] = temp;
                        }
                    }
                }
            }
        }

        
        int k = 2;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(array[i, k]);
        }

        Console.ReadKey();
    }
}*/



class Program2
{
    static void Main(string[] args)
    {
        
        string[,] students = new string[,]
        {
            {"Ivanov", "Ivan", "Grupp 1", "2", "4", "3", "4", "2", "2"},
            {"Kulakovski", "Matvei", "Grupp 1", "2", "3", "4", "5", "3", "4"},
            {"Miljukova", "Darja", "Grupp 2", "5", "2", "3", "2", "2", "3"},
            {"Sohromova", "Anna", "Grupp 2", "4", "4", "4", "4", "4", "4"},
            {"Zverev", "Ilja", "Группа 3", "3", "3", "3", "3", "2", "2"}
        };

        
        for (int i = 0; i < students.GetLength(0); i++)
        {
            int count = 0; 
            
            for (int j = 3; j < students.GetLength(1); j++)
            {
                if (students[i, j] == "2") 
                {
                    count++; 
                }
            }
            if (count >= 3) 
            {
                Console.WriteLine(students[i, 0] + " " + students[i, 1]); 
            }
        }
    }
}
