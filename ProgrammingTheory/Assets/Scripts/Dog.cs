using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal  // inherited from animal base class
{
    public override void Jump()
    {
        base.Jump();
        OverridableText.text = "Jump power - " + JumpPower;  // polymorphism
    }
}
