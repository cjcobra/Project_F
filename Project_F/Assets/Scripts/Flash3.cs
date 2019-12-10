using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash3 : MonoBehaviour
{

    public Image image;
    public string colorFlashing;
    public float timer;

    

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("start()");
        timer = 0.5f;

        // Default                  
        StartCoroutine(ChangeColorToRed());
    }

    public void stopTimer()
    {
        Debug.Log("stopTimer()");
        StopAllCoroutines();

        if (colorFlashing == "Red")
        {
            image.color = Color.red;
        }
        if (colorFlashing == "Blue")
        {
            image.color = Color.blue;
        }

    }

    public void fastTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        timer = 0.5f;
    }

    public void fasterTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        timer = 0.25f;
    }

    public void fastestTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        timer = 0.10f;
    }

    ///////  RED /////////////
    public IEnumerator ChangeColorToRed()
    {
        Debug.Log("ChangeColorToRed");
        colorFlashing = "Red";
        image.color = Color.red;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToRedBlack());
    }

    public IEnumerator ChangeColorToRedBlack()
    {
        Debug.Log("ChangeColorToRedBlack");
        image.color = Color.black;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToRed());
    }
    ///////  END RED /////////////

    ///////  BLUE /////////////
    public IEnumerator ChangeColorToBlue()
    {
        colorFlashing = "Blue";
        image.color = Color.blue;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToBlueBlack());
    }

    public IEnumerator ChangeColorToBlueBlack()
    {
        image.color = Color.black;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToBlue());
    }
    ///////  END BLUE /////////////

    // Update is called once per frame
    void Update()
    {

    }





    
}
