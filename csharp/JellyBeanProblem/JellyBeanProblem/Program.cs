using System;
using System.Collections;
namespace JellyBeanProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 10000;
            int isPoison = 0, isNotPoison = 0;
            for(int i = 1; i <= T; i++)
            {
                
                if (JellyBeanProblem())
                {
                    isPoison++;
                }
                else
                {
                    isNotPoison++;
                }
            }
            double p = (isPoison / (double)T)*100;
            double n = (isNotPoison / (double)T) * 100;
            Console.WriteLine("Poison: " + isPoison+" is a poison "+(p)+"% of the time");
            Console.WriteLine("Not Poison " + isNotPoison + " is not a poison " + (n) + "% of the time");
        }

        public static bool JellyBeanProblem()
        {
            bool[] isPoison = new bool[3];
            int poisonSum = 0;
            while (poisonSum != 2)
            {
                int p = RandomNumber(0,3);
                if (!isPoison[p])
                {
                    isPoison[p] = true;
                    poisonSum++;
                }
            }
            Hashtable poisonMap = new Hashtable();
            for (int i = 0; i < isPoison.Length; i++)
            {
                poisonMap.Add(i, isPoison[i]);
            }

            int pick= RandomNumber(0, 3);
            poisonMap.Remove(pick);

            foreach (DictionaryEntry element in poisonMap)
            {
                
                bool getP =(bool) element.Value;
                if (getP)
                {
                    int remove =(int) element.Key;
                    poisonMap.Remove(remove);
                    break;
                }
               
            }
            bool result=true;
            foreach (DictionaryEntry element in poisonMap)
            {
                result = (bool)element.Value;
                
            }

                
            return result;
        }
        public static int RandomNumber(int min,int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
