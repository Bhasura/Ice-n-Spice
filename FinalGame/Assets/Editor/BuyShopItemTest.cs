using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class BuyShopItemTest 
{
    [Test]
    public void BuyItemShop_Test()
    {
        var shopBuy = new shopTests();
        //test 1
        var itemPrice = 900;
        var name = "Ice Cream";
        var expectedResult = 100;


        //Act
        var balance = shopBuy.buyItem(itemPrice, name);

        //Assert
        Assert.That(balance, Is.EqualTo(expectedResult));
    }

    [Test]
    public void returnItem_Test()
    {
        var shopBuy = new shopTests();
        var itemPrice = 1000;
        var name = "Ice Cream";
       
        var itemNumber = 0;
        var expectedResult = "Ice Cream";

        //Act
        var balance = shopBuy.buyItem(itemPrice, name);
        var item = shopBuy.inventoryName(itemNumber);

        //Assert
        Assert.That(item, Is.EqualTo(expectedResult));
    }
}
