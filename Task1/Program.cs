using System;
using static System.Console;

namespace CSharp4._8Practice
{
    class Program
    {
        static void Main(string[] args)
        {   //Обьявление переменных
            byte linesNumber;
            byte columnsNumber;
            int sumElements = 0;
            Random randomNumber = new Random();

            // Получение входных данных
            Write("Введите количество строк в матрице : ");
            linesNumber = byte.Parse(ReadLine());
            Write("Введите количество столбцов в матрице : ");
            columnsNumber = byte.Parse(ReadLine());

            int[,] matrixFirst = new int[linesNumber, columnsNumber];           // Обявление первой матрицы на основе введенных данных
            int[,] matrixSecond = new int[linesNumber, columnsNumber];           // Обявление второй матрицы на основе введенных данных
            int[,] matrixResult = new int[linesNumber, columnsNumber];           // Обявление матрицы для расчета на основе введенных данных

            // Цикл для заполнения матриц, вывода в консоль и подсчёта суммы элементов первой матрицы
            for (int l = 0; l < linesNumber; l++)
            {
                for (int c = 0; c < columnsNumber; c++)
                {
                    matrixFirst[l, c] = randomNumber.Next(-20, 20);
                    matrixSecond[l, c] = randomNumber.Next(-20, 20);
                    Write($"{matrixFirst[l, c],5} ");
                    sumElements += matrixFirst[l, c];
                }
                WriteLine();
            }
            WriteLine($"Сумма всех элементов массива = {sumElements}");
            WriteLine("Для перехода ко второй задаче нажмите любую клавишу ");
            ReadLine();
            Clear();            // Очистка окна консоли

            // Отображение первой матрицы
            WriteLine("Первая матрица : ");
            for (int l = 0; l < linesNumber; l++)
            {
                for (int c = 0; c < columnsNumber; c++)
                {
                    Write($"{matrixFirst[l, c],5} ");
                }
                WriteLine();
            }
            WriteLine();

            // Отображение второй матрицы
            WriteLine("Вторая матрица : ");
            for (int l = 0; l < linesNumber; l++)
            {
                for (int c = 0; c < columnsNumber; c++)
                {
                    Write($"{matrixSecond[l, c],5} ");
                }
                WriteLine();
            }
            WriteLine();

            // Отображение суммы матриц
            WriteLine("Сумма матриц : ");
            for (int l = 0; l < linesNumber; l++)
            {
                for (int c = 0; c < columnsNumber; c++)
                {
                    // Если необходимо сохранить результат сложения матриц
                    //matrixResult[l,c] = matrixFirst[l, c] + matrixSecond[l, c];
                    //Write($"{matrixResult[l, c],5} ");

                    Write($"{matrixFirst[l, c]+matrixSecond[l,c],5} ");         // Вывод суммы без сохранения в 3 матрицу
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}
