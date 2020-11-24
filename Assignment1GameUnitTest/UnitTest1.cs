using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment_1_game;

namespace Assignment1GameUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        logic_ unitTesting_obj = new logic_();
        [TestMethod]
   
            public void Shoot_Test()
            {
                unitTesting_obj.load_data = 1;
                unitTesting_obj.spin_data = 1;
                int testResult = unitTesting_obj.shoot_method();
                Assert.AreEqual(1, testResult);
            }
            [TestMethod]
            public void Shoot_Test_Neg()
            {
                unitTesting_obj.load_data = 1;
                unitTesting_obj.spin_data = 5;
                int testResult = unitTesting_obj.shoot_method();
                Assert.AreNotEqual(1, testResult);
            }





                }
    }

