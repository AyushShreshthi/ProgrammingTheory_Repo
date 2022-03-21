using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScript : MonoBehaviour
{
    public static TitleScript ts;
    private void Awake()
    {
        ts = this;
    }


    private bool cat;
    public bool Cat
    {
        get
        {
            return cat;
        }
        set
        {
            cat = value;
        }
    }

    private bool dog;
    public bool Dog
    {
        get
        {
            return dog;
        }
        set
        {
            dog = value;
        }
    }

    public void catBtn()
    {
        cat = true;
        SceneManager.LoadScene(1);
    }
    public void dogBtn()
    {
        dog = true;
        SceneManager.LoadScene(1);
    }
}
