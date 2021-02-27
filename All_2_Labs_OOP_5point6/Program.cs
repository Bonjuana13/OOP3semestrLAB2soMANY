using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_2_Labs_OOP_5point6
{
    class Program
    {
        static void Main(string[] args)
        {
            //method_Array_RepeatingWordsNumbers(); //2.1
            //method_ArrayList_RepeatingWordsNumbers(); //2.2
            //metod_List_VowelConsonant(); //3.1
            //metod_ArrayList_VowelConsonant(); //3.2
            //metod_ArrayList_Diapozon(); //4.1
            //metod_List_Diapozon(); //4.2
            //metod_List_MaxMin(); //5.1
            //metod_ArrayList_MinMax(); //5.2
            //metod_Array_EngWords(); //6.1
        }

        private static void method_Array_RepeatingWordsNumbers() //вывести все повторяющиеся слова/цифры
        {
            Console.WriteLine("Введите текст: ");

            char[] arDelimiter = { ',', '.', '?', '!', ' ' };

            string[] UserText = Console.ReadLine().ToLower().Split(arDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string RepeatingUserText = "";

            int CurrentRepeatingSymbols = 0;

            foreach (string Words in UserText)
            {
                foreach (string Words2 in UserText)
                {
                    if (Words == Words2)
                    {
                        CurrentRepeatingSymbols++;
                    }
                }

                if (CurrentRepeatingSymbols >= 2)
                {
                    RepeatingUserText += Words + " ";
                }
                CurrentRepeatingSymbols = 0;
            }

            Console.WriteLine("Все повторяющиеся слова/цифры: ");
            Console.WriteLine(RepeatingUserText);
            Console.ReadKey();
        }

        private static void method_ArrayList_RepeatingWordsNumbers() //вывести все повторяющиеся слова/цифры
        {
            Console.WriteLine("Введите текст: ");

            char[] arDelimiter = { ',', '.', '?', '!', ' ' };

            ArrayList UserText = new ArrayList();

            string[] UserText2 = Console.ReadLine().ToLower().Split(arDelimiter, StringSplitOptions.RemoveEmptyEntries);

            int CurrentRepeatingSymbols = 0;

            foreach (string Words in UserText2)
            {
                foreach (string Words2 in UserText2)
                {
                    if (Words == Words2)
                    {
                        CurrentRepeatingSymbols++;
                    }
                }

                if (CurrentRepeatingSymbols >= 2)
                {
                    UserText.Add(Words);
                }
                CurrentRepeatingSymbols = 0;
            }

            Console.WriteLine("Все повторяющиеся слова/цифры: ");
            
            foreach (string Repeating in UserText)
            {
                Console.WriteLine(Repeating);
            }
            
            Console.ReadKey();
        }
        
        private static void metod_List_VowelConsonant() //посчитать общее кол-во согласных и гласных во введенной строчке
        {
            Console.WriteLine("Введите свой текст: ");
            List<string> UserTextToWords = new List<string> { };

            char[] arDelimiter = { ' ', '.', ',', '?', '!' };

            string[] UserText = Console.ReadLine().ToLower().Split(arDelimiter, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < UserText.Length; i++)
            {
                UserTextToWords.Add(UserText[i]);
            }    

            int Vowel = 0;
            int Consonant = 0;

            for (int j = 0; j < UserTextToWords.Count; j++)
            {
                string Word = UserTextToWords[j];

                for (int k = 0; k < Word.Length; k++)
                {
                    if (metod_Consonant(Word[k]) == true)
                    {
                        Consonant++;
                    }
                    if (metod_Vowel(Word[k]) == true)
                    {
                        Vowel++;
                    }
                }
            }

            Console.WriteLine($"Количество согласных: {Consonant}");
            Console.WriteLine($"Количество гласных: {Vowel}");
            Console.ReadKey();
        }

        private static void metod_ArrayList_VowelConsonant() //посчитать общее кол-во согласных и гласных во введенной строчке
        {
            Console.WriteLine("Введите свой текст: ");
            ArrayList UserTextToWords = new ArrayList();

            char[] arDelimiter = { ' ', '.', ',', '?', '!' };

            string[] UserText = Console.ReadLine().ToLower().Split(arDelimiter, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < UserText.Length; i++)
            {
                UserTextToWords.Add(UserText[i]);
            }

            int Vowel = 0;
            int Consonant = 0;

            for (int j = 0; j < UserTextToWords.Count; j++)
            {
                string Word = UserTextToWords[j].ToString();

                for (int k = 0; k < Word.Length; k++)
                {
                    if (metod_Consonant(Word[k]) == true)
                    {
                        Consonant++;
                    }
                    if (metod_Vowel(Word[k]) == true)
                    {
                        Vowel++;
                    }
                }
            }

            Console.WriteLine($"Количество согласных: {Consonant}");
            Console.WriteLine($"Количество гласных: {Vowel}");
            Console.ReadKey();
        }

        private static void metod_ArrayList_Diapozon() //поиск самого большого диапозона между числами
        {
            Console.WriteLine("Вводите числа. Когда захотите закончить, напишите (TheEnd).");

            ArrayList arNum = new ArrayList { };
            Int32 Numb;
            
            while (true)
            {
                var InputNum = Console.ReadLine();
                if (InputNum.Equals("TheEnd"))
                {
                    break;
                }
                if ((Int32.TryParse(InputNum, out Numb)) == true)
                {
                    arNum.Add(Numb);
                }
            }

            Int32 MaxVolume = 0;
            Int32 CurrentVolume;

            for (int i = 0; i < arNum.Count - 1; i++)
            {
                CurrentVolume = Math.Abs(Convert.ToInt32(arNum[i].ToString()) - Convert.ToInt32(arNum[i+1].ToString()));

                if (CurrentVolume > MaxVolume)
                {
                    MaxVolume = CurrentVolume;
                }
            }

            Console.WriteLine($"Самый большой диапозон между числами: {MaxVolume}");
            Console.ReadKey();
        }

        private static void metod_List_Diapozon() //поиск самого большого диапозона между числами
        {
            Console.WriteLine("Вводите числа. Когда захотите закончить, напишите (TheEnd).");

            List<Int32> arNum = new List<int>();
            Int32 Numb;

            while (true)
            {
                var InputNum = Console.ReadLine();
                if (InputNum.Equals("TheEnd"))
                {
                    break;
                }
                if ((Int32.TryParse(InputNum, out Numb)) == true)
                {
                    arNum.Add(Numb);
                }
            }

            Int32 MaxVolume = 0;
            Int32 CurrentVolume;

            for (int i = 0; i < arNum.Count - 1; i++)
            {
                CurrentVolume = Math.Abs(Convert.ToInt32(arNum[i].ToString()) - Convert.ToInt32(arNum[i + 1].ToString()));

                if (CurrentVolume > MaxVolume)
                {
                    MaxVolume = CurrentVolume;
                }
            }

            Console.WriteLine($"Самый большой диапозон между числами: {MaxVolume}");
            Console.ReadKey();
        }

        private static void metod_List_MaxMin() //найти максимальное и минимальное значение
        {
            Console.WriteLine("Вводите числа. Когда захотите закончить, напишите (TheEnd).");
            List<Int32> arNumbers = new List<Int32> { };
            Int32 CountNum = 0;

            while (true)
            {
                var InputNum = Console.ReadLine();
                if (InputNum.Equals("TheEnd"))
                {
                    break;
                }
                if ((Int32.TryParse(InputNum, out CountNum)) == true)
                {
                    arNumbers.Add(CountNum);
                }
            }

            Int32 Max = arNumbers[0];
            Int32 Min = arNumbers[0];

            for (int i = 0; i < arNumbers.Count; i++)
            {
                if (arNumbers[i] > Max)
                {
                    Max = arNumbers[i];
                }
                if (arNumbers[i] < Min)
                {
                    Min = arNumbers[i];
                }
            }

            Console.WriteLine($"Максимальное число: {Max}");
            Console.WriteLine($"Минимальное число: {Min}");
            Console.ReadKey();
        }

        private static void metod_ArrayList_MinMax() //найти максимальное и минимальное значение
        {
            Console.WriteLine("Вводите числа. Когда захотите закончить, напишите (TheEnd).");
            ArrayList arNumbers = new ArrayList { };
            Int32 CountNum = 0;

            while (true)
            {
                var InputNum = Console.ReadLine();
                if (InputNum.Equals("TheEnd"))
                {
                    break;
                }
                if ((Int32.TryParse(InputNum, out CountNum)) == true)
                {
                    arNumbers.Add(CountNum);
                }
            }

            Int32 Max = Convert.ToInt32(arNumbers[0].ToString());
            Int32 Min = Convert.ToInt32(arNumbers[0].ToString());

            for (int i = 0; i < arNumbers.Count; i++)
            {
                if (Convert.ToInt32(arNumbers[i].ToString()) > Max)
                {
                    Max = Convert.ToInt32(arNumbers[i].ToString());
                }
                if (Convert.ToInt32(arNumbers[i].ToString()) < Min)
                {
                    Min = Convert.ToInt32(arNumbers[i].ToString());
                }
            }

            Console.WriteLine($"Максимальное число: {Max}");
            Console.WriteLine($"Минимальное число: {Min}");
            Console.ReadKey();
        }

        private static void metod_Array_EngWords() //найти кол-во слов с англ буквами и без
        {
            Console.WriteLine("Введите текст: ");

            char[] arDelimiter = { ',', '.', '?', '!', ' ' };

            string[] UserText = Console.ReadLine().ToLower().Split(arDelimiter, StringSplitOptions.RemoveEmptyEntries);
            

            int CurrentWordsWithEngSymbols = 0;
            int EngWords = 0;

            foreach (string Word in UserText)
            {
                for (int j = 0; j < Word.Length; j++)
                {
                    if (metod_EngSymbols(Word[j]) == true)
                    {
                        CurrentWordsWithEngSymbols++;
                    }

                    if (CurrentWordsWithEngSymbols > 0)
                    {
                        EngWords++;
                        CurrentWordsWithEngSymbols = 0;
                        break;
                    }
                    
                }
                
            }

            Console.WriteLine("Слов с английскими буквами: ");
            Console.WriteLine(EngWords);
            Console.WriteLine("Слов без английских букв: ");
            Console.WriteLine(UserText.Length - EngWords);
            Console.ReadKey();
        }

        private static bool metod_EngSymbols(char word)
        {
            char[] arEng = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            foreach (char vv in arEng)
            {
                if (word == vv)
                {
                    return (true);
                }
            }
            return (false);
        }

        private static bool metod_Vowel(char SymbolVow) //проверка на гласную
        {
            char[] arVowels = { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё' };
            foreach (char Vowels in arVowels)
            {
                if (SymbolVow == Vowels)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool metod_Consonant(char SymbolCon) //проверка на согласную
        {
            char[] arConsonants = { 'й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б' };
            foreach (char Consonants in arConsonants)
            {
                if (SymbolCon == Consonants)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
