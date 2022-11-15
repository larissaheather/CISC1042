using System.Collections;
using System.Collections.Generic;
using System.Drawing;
//using NUnit.Framework;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.TestTools;

public class happinesstest
{
    // Test the default constructor
    // [Test]
    public void HappinessDefaultConstructorTest()
    {
        // Setup and Act
        happiness defaultHappiness = new happiness();

        // Assert
        Assert.AreEqual(0, defaultHappiness.GetCar());
        Assert.AreEqual(0, defaultHappiness.GetDoor());
        Assert.AreEqual(0, defaultHappiness.GetFood());
        Assert.AreEqual(0, defaultHappiness.GetHappiness());
    }

    // Test a 2 x 2 x 2 Happiness
    // [Test]
    public void HappinessTwoByFourTest()
    {
        // Setup and Act
        happiness twoByFour = new happiness(2f, 2f, 2f);

        // Assert
        Assert.AreEqual(4, twoByFour.GetCar());
        Assert.AreEqual(4, twoByFour.GetDoor());
        Assert.AreEqual(4, twoByFour.GetFood());
        Assert.AreEqual(8, twoByFour.GetHappiness());
    }

    // Test a 10 x 10 happiness
    // [Test]
    public void HappinessTenByTenTest()
    {
        // Setup and Act
        happiness tenByTen = new happiness(10f, 10f, 10f);

        // Assert
        Assert.AreEqual(10, tenByTen.GetCar());
        Assert.AreEqual(10, tenByTen.GetDoor());
        Assert.AreEqual(10, tenByTen.GetFood());
        Assert.AreEqual(100, tenByTen.GetHappiness());
    }

    // Test the SetCar method
    // [Test]
    public void HappinessSetCarTest()
    {
        // Setup
        happiness someHappiness = new happiness(1f, 1f, 1f);

        // Act
        someHappiness.SetCar(100);

        // Assert
        Assert.AreNotEqual(1, someHappiness.GetCar());  // This assertion is redundant, but an example
        Assert.AreEqual(100, someHappiness.GetCar());

        Assert.AreEqual(5, someHappiness.GetDoor());
        Assert.AreEqual(5, someHappiness.GetFood());
        Assert.AreEqual(500, someHappiness.GetHappiness());
    }
}


