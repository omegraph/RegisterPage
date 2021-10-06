﻿using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //1-Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";

            //Declare new variable
            //2-Act
            string expected = "Toy Story";
            string actual = content.Title;

            //3-Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
