using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Multiplayertest 
{
   [Test]
   public void amountofplayers_Test()
    {
        var getplayernumber = new Multiplayer();
        var inroomt = false;
        var connectedtomastert = false;
        var roomidt = 1;
        var expected = 0;

        var count = getplayernumber.getplayers(inroomt, connectedtomastert, roomidt);

        Assert.That(count, Is.EqualTo(expected));
        

    }

    [Test]
    public void getplayername_Test()
    {
        var getplayername = new Multiplayer();
        var inroomt = true;
        var playeridt = 2;
        var connectedtomastert = true;
        var roomidt = 2;
        var expected = "no player with that id";

        var get = getplayername.getname(inroomt, connectedtomastert, roomidt, playeridt);

        Assert.That(get, Is.EqualTo(expected));
    }

    

    //public void 

}

