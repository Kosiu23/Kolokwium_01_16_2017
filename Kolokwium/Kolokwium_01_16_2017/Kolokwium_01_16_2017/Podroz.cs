using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_01_16_2017
{
    class Podroz:IStacja
    {
        protected Queue<Stacja> stacja;
        protected double koszt = 75;
        public Podroz() { }
        public virtual double KosztPoRabacie()
        {
            return koszt * 0.05; //0.05 75-15
        }
        public override string ToString()
        {
            string infor = "Podróż:";
            foreach(var element in stacja)
            {
                infor += Environment.NewLine + element.ToString();
                
            }
            infor += Environment.NewLine + "Koszt po rabacie: " + KosztPoRabacie();
            return infor; 
        }

        public void DodajStacje(string nazwa, bool oplata)
        {
            stacja.Enqueue(new Stacja(nazwa, oplata));
            if(oplata) //if(oplata==true) to samo
            {
               koszt += 22;
            } 
        }
        public void UsunStacje()
        {
            if (stacja.Count>0)
            {
                stacja.Dequeue();
            }       
        }
        public void Powrot()
        {

            if(stacja.Count>0)
            {
                Stacja powrotstacja = stacja.Peek();
                stacja.Enqueue(powrotstacja);
            }
            /*Stacja powrotstacja = stacja.Peek();*/
            /*Stacja nowastacja = stacja   */
            /*if (stacja.Count > 0) stacja.Peek();*/
            /*Stacja nowastajca = stacja;*/

          
        }
        public void ZapiszPodroz()
        {
            /*System.IO.StreamWriter file = new System.IO.StreamWriter("C:\Users\local\Desktop\Kolokwium\podroz.txt");
            file.WriteLine(lines);

            file.Close();*/
            /*using (Strean writer = new StreamWriter("Hi_My_Name_Is.txt"))
            {

            }*/
            using(System.IO.StreamWriter plik = new System.IO.StreamWriter("podroz.txt"))
            {
                stacja.ToString();
            }
        }
    }
}
