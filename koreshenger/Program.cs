using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using KörHenger;


namespace KöHenger_UnitTest
{
    
    public class Henger_Teszt
    {
       
        public void TestMethod1()
        {
        }
    }
}


namespace KöHenger_UnitTest
{
    
    public class Kör_Teszt
    {
        
        public void Kerület_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör(sugár);
            double vártEredm = 31.42;

            // Act - Végrehajtás
            kör.SetKerület();
            double kapottEredm = kör.GetKerület();

           
        }

      
        public void Terület_Teszt()
        {
        }
    }
}


namespace KörHenger
{
    public class Kör
    {
        protected double sugar,
            terület,
            kerület;

        public Kör() { }

        public Kör(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("A kör sugara nem lehet 0 és annál kisebb!");
            }
            else this.sugar = r;
        }

        public void SetSugar(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("A kör sugara nem lehet 0 és annál kisebb!");
            }
            else this.sugar = r;
        }

        public void SetTerület()
        {
            this.terület = Math.Round(Math.Pow(this.sugar, 2) * Math.PI, 2);
        }

        public void SetKerület()
        {
            this.kerület = Math.Round(2 * this.sugar * Math.PI, 2);
        }

        public double GetTerület()
        {
            return this.terület;
        }

        public double GetKerület()
        {
            return this.kerület;
        }

        public double GetSugár()
        {
            return this.sugar;
        }
    }

    class Henger : Kör
    {
        // Osztályváltozók
        private double térfogat,
            magasság;

        // Konstruktor
        public Henger(double s, double m)
        {
            // Változók beállítása
            if (s <= 0 || m <= 0)
            {
                throw new ArgumentException("A henger sugara és magassága nem lehet 0 és annál kisebb!");
            }
            else
            {
                this.sugar = s;
                this.magasság = m;

                // Számítások elvégzése
                SetKerület();
                SetTerület();
                this.térfogat = this.terület * this.magasság;
            }
        }

        public double GetTérfogat()
        {
            return this.térfogat;
        }
        using Microsoft.VisualStudio.TestTools.UnitTesting;


using System;


using KörHenger;
 
namespace KorHenger_UnitTest


    {


        [TestClass]


        public class Kör_Teszt


        {


            [TestMethod]


            public void Kerület_Teszt()


            {


                // Arrange - Feltételek beállítása


                double sugár = 5;


                Kör kör = new Kör(sugár);


                double vártEredm = 31.42;

                // Act - Végrehajtás


                kör.SetKerület();


                double kapottEredm = kör.GetKerület();


                // Assert - Kiértékelés


                Assert.AreEqual(vártEredm, kapottEredm);


            }


            [TestMethod]


            public void Terület_teszt()


            {


                // Arrange - Feltételek beállítása


                double sugár = 5;


                Kör kör = new Kör(sugár);


                double vártEredm = 78.54;

                // Act - Végrehajtás


                kör.SetTerület();


                double kapottEredm = kör.GetTerület();

                // Assert - Kiértékelés


                Assert.AreEqual(vártEredm, kapottEredm);


            }


        }


    }



}
}
