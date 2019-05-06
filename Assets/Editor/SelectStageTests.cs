using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class SelectStageTests
{
    [Test]
    public void nextStageUnlocked_Test()
    {
        var stage2Unlocked = new StageUnlocked();
        var s2Unlocked = false;
        var s1Completion = 100;
        var expectedResult = true;

        //Act
        var unlock = stage2Unlocked.unlocked(s2Unlocked, s1Completion);

        //Assert
        Assert.That(unlock, Is.EqualTo(expectedResult));
    }
}
