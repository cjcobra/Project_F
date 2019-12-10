using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash2 : MonoBehaviour
{

    public Image image;
    public static string colorFlashing;
    public float timer;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start()");
        timer = 0.5f;

        // Default                  
        Invoke("ChangeColorToRed", timer);
    }

    public void stopTimer()
    {
        timer = 50000f;
    }

    public void fastTimer()
    {
       
        timer = 0.5f;
    }

    public void fasterTimer()
    {
        timer = 0.25f;
    }

    public void fastestTimer()
    {
        timer = 0.10f;
    }

    ///////  RED /////////////
    public void ChangeColorToRed()
    {
        if (timer > 1)
        {
            image.color = Color.red;

        }
        else
        {
            image.color = Color.red;
            Invoke("ChangeColorToRedBlack", timer);
        }
    }

    public void ChangeColorToRedBlack()
    {
        image.color = Color.black;
        Invoke("ChangeColorToRed", timer);
    }
    ///////  END RED /////////////

    ///////  BLUE /////////////
    public void ChangeColorToBlue()
    {
        image.color = Color.blue;
        Invoke("ChangeColorToBlueBlack", timer);
    }

    public void ChangeColorToBlueBlack()
    {
        image.color = Color.black;
        Invoke("ChangeColorToBlue", timer);
    }
    ///////  END BLUE /////////////

    // Update is called once per frame
    void Update()
    {

    }





    
}
