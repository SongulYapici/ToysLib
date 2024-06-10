using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToysLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib.Tests
{
    [TestClass()]
    public class ToyTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange: oprette et objekt af klassen Toy
            Toy toy = new Toy();

            toy.Id = 1;
            toy.Brand = "Lego";
            toy.Model = "Star Wars";
            toy.Price = 100;

            //Act: kalder metoden ToString
            string result = toy.ToString();

            //Assert: sammenligner forventet resultat med det faktiske resultat
            Assert.AreEqual("Id: 1, Brand: Lego, Model: Star Wars, Price: 100", result);
        }

        [TestMethod()]
        public void ValidateBrandTest()
        {
            //Arrange: opretter en ny toy og tildeler en værdi til Brand. hvis brand er null eller tom, så kaster den en exception under testen.
            Toy toy = new Toy();
            toy.Brand = "Lego";

            //Act: den henviser til metoden ValidateBrand
            toy.ValidateBrand();

            //Assert: skal overholde betingelserne i metoden ValidateBrand
            Assert.IsTrue(true);
        }

        [TestMethod()]
        // vi laver en exception test, for at se om den kaster en exception, hvis Brand er null eller tom
        public void ValidateBrandTestException()
        {
            //Arrange: opretter en ny toy og tildeler en værdi til Brand. hvis brand er null eller tom, så kaster den en exception under testen.
            Toy toy = new Toy();
            //her er den tom så Assert skal kaste en exception
            toy.Brand = "";

            //Act er tom , da vi forventer en exception
            //Assert: skal overholde betingelserne i metoden ValidateBrand
            Assert.ThrowsException<ArgumentException>(() => toy.ValidateBrand());
        }

        //Her gør vi præcis det samme som i ValidateBrand bare med Model i stedet.

        [TestMethod()]
        public void ValidateModelTest()
        {
            //Arrange
            Toy toy = new Toy();
            toy.Model = "Star Wars";

            //Act
            toy.ValidateModel();

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ValidateModelTestException()
        {
            Toy toy = new Toy();
            toy.Model = "";

            Assert.ThrowsException<ArgumentException>(() => toy.ValidateModel());
        }
    }
}

//Code Coverage under Test Explorer viser, hvor meget af koden, der er blevet testet.