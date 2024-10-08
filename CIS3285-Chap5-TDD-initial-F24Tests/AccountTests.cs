using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS3285_Chap5_TDD_initial_F24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3285_Chap5_TDD_initial_F24.Tests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            // Arrange
            var account = new Account();

            // Act
            account.AddTransaction(200m);

            // Assert
            Assert.AreEqual(200m, account.Balance);
        }
    }


}