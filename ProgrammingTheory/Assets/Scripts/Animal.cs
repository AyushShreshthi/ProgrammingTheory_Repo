using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private float jumpPower;

    public float JumpPower   // encapsulation
    {
        get
        {
            return jumpPower;
        }
        set
        {
            jumpPower = value;
        }
    }


    [SerializeField]
    private Text overridableText;
    public Text OverridableText    // encapsulation
    {
        get
        {
            return overridableText;
        }
        set
        {
            overridableText.text = value.ToString();
        }
    }

    public virtual void Jump() { }  //creation of virtual function which can be used by cat or dog differently = abstraction

    
}
