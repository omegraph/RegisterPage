using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBook.UnitTests
{
    [TestClass] //Test Class Annotation
    public class ContactTests
    {
        [TestMethod] // Test Method Annotation
        public void CallEmtyConstructor_Properties_ShouldBeDefaultValues()
        {
            //AAA Paradigm "we use this for every test method"

            //Arrange
            //Act
            //Assert
            Assert.AreEqual(default, ContactTests.FirstName);
        }
    }
}
