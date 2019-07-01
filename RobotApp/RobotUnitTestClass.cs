using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RobotApp
{
    [TestClass]
    public class RobotUnitTestClass
    {
        [TestMethod]
        public void returns_elevenMovements()
        {
            
             int result = RobotClass.robot_movement("N4", "E2", "S2", "W4");
            
            //should return 5 movements
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void returns_twentyTwoMovements()
        {

            int result = RobotClass.robot_movement("N4", "E3", "S6", "W9");

            //should return 5 movements
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void returns_seventeenMovements()
        {

            int result = RobotClass.robot_movement("N4", "E3", "S2", "W9");

            //should return 5 movements
            Assert.AreEqual(17, result);
        }
    }
    
}
