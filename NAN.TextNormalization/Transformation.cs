using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Принцип работы класса: На вход приходит строка, после чего разбивается на слова и заносятся в массив.
 *После чего, каждое слово из массива проверяется на русское или английское, по принципу, каких символов 
 *в слове больше. Дальше, как определился тип слова, с помощью байтового представления заменяются букву. 
 *На выводе получается отформатированная строка.
 *
 *Ограничения: 
 *1) Алгоритм работает корректно, только для слов, в котором исходных символов больше чем замененных.
 */

namespace NAN.TextNormalization
{
    public class Transformation
    {
        public string Transform(string line)
        {
            string str = "";
            int ru = 0;
            int eng = 0;
            if (line == "")
            {
                MessageBox.Show("Строка пустая!");
            }
            string[] words = line.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {

                for (int j = 0; j < words[i].Length; j++)
                {
                    if ((byte)words[i][j] < 97)
                    {
                        ru++;
                    }
                    else
                    {
                        eng++;
                    }
                }
                if (ru > eng)
                {
                    string str1 = words[i];
                    char[] chars = str1.ToCharArray();
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if ((byte)chars[j] == 101)
                        {
                            chars[j] = 'е';
                        }
                        if ((byte)chars[j] == 107)
                        {
                            chars[j] = 'к';
                        }
                        if ((byte)chars[j] == 111)
                        {
                            chars[j] = 'о';
                        }
                        if ((byte)chars[j] == 116)
                        {
                            chars[j] = 'т';
                        }
                        if ((byte)chars[j] == 97)
                        {
                            chars[j] = 'а';
                        }
                        if ((byte)chars[j] == 121)
                        {
                            chars[j] = 'у';
                        }
                        if ((byte)chars[j] == 120)
                        {
                            chars[j] = 'х';
                        }
                        if ((byte)chars[j] == 98)
                        {
                            chars[j] = 'ь';
                        }
                        if ((byte)chars[j] == 109)
                        {
                            chars[j] = 'м';
                        }
                        if (chars[j] == '4')
                        {
                            chars[j] = 'ч';
                        }
                        if (chars[j] == '7')
                        {
                            chars[j] = 'т';
                        }
                        if (chars[j] == '0')
                        {
                            chars[j] = 'о';
                        }
                        if (chars[j] == '8')
                        {
                            chars[j] = 'в';
                        }
                        if (chars[j] == 99)
                        {
                            chars[j] = 'с';
                        }
                    }
                    str += new string(chars) + " ";
                }
                else
                {
                    string str1 = words[i];
                    char[] chars = str1.ToCharArray();
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if ((byte)chars[j] == 53)
                        {
                            chars[j] = 'e';
                        }
                        if ((byte)chars[j] == 58)
                        {
                            chars[j] = 'k';
                        }
                        if ((byte)chars[j] == 62)
                        {
                            chars[j] = 'o';
                        }
                        if ((byte)chars[j] == 66)
                        {
                            chars[j] = 't';
                        }
                        if ((byte)chars[j] == 48)
                        {
                            chars[j] = 'a';
                        }
                        if ((byte)chars[j] == 67)
                        {
                            chars[j] = 'y';
                        }
                        if ((byte)chars[j] == 69)
                        {
                            chars[j] = 'x';
                        }
                        if ((byte)chars[j] == 76)
                        {
                            chars[j] = 'b';
                        }
                        if ((byte)chars[j] == 60)
                        {
                            chars[j] = 'm';
                        }
                        if (chars[j] == '8')
                        {
                            chars[j] = 'b';
                        }
                        if (chars[j] == '1')
                        {
                            chars[j] = 'l';
                        }
                        if (chars[j] == '0')
                        {
                            chars[j] = 'o';
                        }
                        if (chars[j] == '7')
                        {
                            chars[j] = 't';
                        }
                        if (chars[j] == 65)
                        {
                            chars[j] = 'c';
                        }
                    }
                    str += new string(chars) + " ";
                }
                ru = 0;
                eng = 0;
            }
            return str.TrimEnd();

        }
    }
}
