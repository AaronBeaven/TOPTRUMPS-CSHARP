using System;
using System.Collections.Generic;

namespace Csharp_Lists
{
    public class cardClass{
        //declaring the stats 
        public string name;
        public int age;

    }
    class Program
    {
        static void Main(string[] args)
        {
            // start of the arrays 
            string[] myNewStringArray;
            //declaring whats going in the arrays
            myNewStringArray = new string[]{
                "Aaron","Heaven With A B", "Sofology"
            };
            Console.WriteLine(myNewStringArray[1]);
            for(int i = 0; i<myNewStringArray.Length; i++){
                Console.WriteLine(myNewStringArray[i]);
            }
            int [] myNewIntArray = new int []{
                1,2,3,4,5,6
            };
            // statement so our program logs all of the values 
            for(int i =0; i<myNewIntArray.Length; i++){
                Console.WriteLine(myNewIntArray[i]);
            }
            // end of the arrays 
            List<cardClass> cards = new List<cardClass>();
            List<cardClass> SecondPlayerCards = new List<cardClass>();
            cards.Add(new cardClass{name = "David", age = 48});
            cards.Add(new cardClass{name = "Phil", age = 78});
            cards.Add(new cardClass{name = "Callum", age = 55});
            cards.Add(new cardClass{name = "HeavenWithAB", age = 20});
            cards.Add(new cardClass{name = "jason", age = 67});
            for(int i =0; i<cards.Count; i++){
            Console.WriteLine(cards[i].name);
            // secopnd player cards
            SecondPlayerCards.Add(new cardClass{name = "Michael", age = 48});
            SecondPlayerCards.Add(new cardClass{name = "Sam", age = 12});
            SecondPlayerCards.Add(new cardClass{name = "Cameron", age = 34});
            SecondPlayerCards.Add(new cardClass{name = "Dan", age = 65});
            SecondPlayerCards.Add(new cardClass{name = "Stevo", age = 34});
             for(int p =0; p<SecondPlayerCards.Count; p++){
            Console.WriteLine(SecondPlayerCards[p].name);
            }
            // function to decide which player won and which looses the card 
            if(cards[0].age < SecondPlayerCards[0].age){

                SecondPlayerCards.Add(cards[0]);
                cards.RemoveAt(0);
            }
        }
        }
    }
}
        
        
    


