using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;  // CJ ADDED /////////////////////////////////////////////////////////////////////////////////////////

public class Flash3 : MonoBehaviour
{

    public Image image;
    public string colorFlashing;
    public float timer;
    public Text textToCopy;
    public Text FlashRText;

    public Slider mainSlider;
    public string stoppingValue;
    public string isPlaying;


    void Start()
    {
        //    timer = 0.5f;
        mainSlider.value = 0.5f;
        timer = mainSlider.value;

        // Default                  
        StartCoroutine(ChangeColorToRed());

        stoppingValue = "Play";
        isPlaying = "Yes";
    }

    public void startRed()
    {
        Debug.Log("startRed");
        StopAllCoroutines();
        StartCoroutine(ChangeColorToRed());
    }
    public void startBlue()
    {
        Debug.Log("startBlue");
        StopAllCoroutines();
        StartCoroutine(ChangeColorToBlue());
    }
    public void startGreen()
    {
        Debug.Log("startGreen");
        StopAllCoroutines();
        StartCoroutine(ChangeColorToGreen());
    }
    public void startYellow()
    {
        Debug.Log("startYellow");
        StopAllCoroutines();
        StartCoroutine(ChangeColorToYellow());
    }
    public void startMagenta()
    {
        Debug.Log("startMagenta");
        StopAllCoroutines();
        StartCoroutine(ChangeColorToMagenta());
    }

//    public static void CopyToClipboard(this string s)
//    {
//        TextEditor te = new TextEditor();
//        te.text = s;
//        te.SelectAll();
//        te.Copy();
//    }

    
    public void copyMe()
    {

        if (colorFlashing == "Red")
        {
            GUIUtility.systemCopyBuffer = "My FlashR = Red";
        }

        if (colorFlashing == "Blue")
        {
            GUIUtility.systemCopyBuffer = "My FlashR = Blue";
        }

        if (colorFlashing == "Green")
        {
            GUIUtility.systemCopyBuffer = "My FlashR = Green";
        }

        if (colorFlashing == "Yellow")
        {
            GUIUtility.systemCopyBuffer = "My FlashR = Yellow";
        }

        if (colorFlashing == "Magenta")
        {
            GUIUtility.systemCopyBuffer = "My FlashR = Purple";
        }

    }
    

    public void stopTimer()
    {
        Debug.Log("stopTimer()");
        StopAllCoroutines();
        isPlaying = "No";

        if (colorFlashing == "Red")
        {
            image.color = Color.red;
        }

        if (colorFlashing == "Blue")
        {
            image.color = Color.blue;
        }

        if (colorFlashing == "Green")
        {
            image.color = Color.green;
        }

        if (colorFlashing == "Yellow")
        {
            image.color = Color.yellow;
        }

        if (colorFlashing == "Magenta")
        {
            image.color = Color.magenta;
        }
    }

    public void fastTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        if (colorFlashing == "Blue")
        {
            StartCoroutine(ChangeColorToBlue());
        }

        if (colorFlashing == "Green")
        {
            StartCoroutine(ChangeColorToGreen());
        }

        if (colorFlashing == "Yellow")
        {
            StartCoroutine(ChangeColorToYellow());
        }

        if (colorFlashing == "Magenta")
        {
            StartCoroutine(ChangeColorToMagenta());
        }
      //  timer = 0.5f;
    }

    public void fasterTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        if (colorFlashing == "Blue")
        {
            StartCoroutine(ChangeColorToBlue());
        }

        if (colorFlashing == "Green")
        {
            StartCoroutine(ChangeColorToGreen());
        }

        if (colorFlashing == "Yellow")
        {
            StartCoroutine(ChangeColorToYellow());
        }

        if (colorFlashing == "Magenta")
        {
            StartCoroutine(ChangeColorToMagenta());
        }
      //  timer = 0.25f;
    }

    public void fastestTimer()
    {
        StopAllCoroutines();
        if (colorFlashing == "Red")
        {
            StartCoroutine(ChangeColorToRed());
        }

        if (colorFlashing == "Blue")
        {
            StartCoroutine(ChangeColorToBlue());
        }

        if (colorFlashing == "Green")
        {
            StartCoroutine(ChangeColorToGreen());
        }

        if (colorFlashing == "Yellow")
        {
            StartCoroutine(ChangeColorToYellow());
        }

        if (colorFlashing == "Magenta")
        {
            StartCoroutine(ChangeColorToMagenta());
        }
      //  timer = 0.10f;
    }

    ///////  RED /////////////
    public IEnumerator ChangeColorToRed()
    {
        isPlaying = "Yes";

        Debug.Log("ChangeColorToRed");
        colorFlashing = "Red";
        FlashRText.text = "FlashR";
        FlashRText.color = Color.black;
        image.color = Color.red;

        GameObject.Find("ButtonTextToCopy").GetComponentInChildren<Text>().text = "My FlashR = Red";

        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToRedBlack());
    }

    public IEnumerator ChangeColorToRedBlack()
    {
        Debug.Log("ChangeColorToRedBlack");
        image.color = Color.black;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.red;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToRed());
    }
    ///////  END RED /////////////

    ///////  BLUE /////////////
    public IEnumerator ChangeColorToBlue()
    {
        isPlaying = "Yes";

        colorFlashing = "Blue";
        FlashRText.text = "FlashR";
        FlashRText.color = Color.black;
        image.color = Color.blue;

        GameObject.Find("ButtonTextToCopy").GetComponentInChildren<Text>().text = "My FlashR = Blue";

        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToBlueBlack());
    }

    public IEnumerator ChangeColorToBlueBlack()
    {
        image.color = Color.black;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.blue;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToBlue());
    }
    ///////  END BLUE /////////////

    ///////  GREEN /////////////
    public IEnumerator ChangeColorToGreen()
    {
        isPlaying = "Yes";

        Debug.Log("ChangeColorToGreen");
        colorFlashing = "Green";
        image.color = Color.green;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.black;

        GameObject.Find("ButtonTextToCopy").GetComponentInChildren<Text>().text = "My FlashR = Green";

        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToGreenBlack());
    }

    public IEnumerator ChangeColorToGreenBlack()
    {
        Debug.Log("ChangeColorToGreenBlack");
        image.color = Color.black;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.green;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToGreen());
    }
    ///////  END GREEN /////////////

    ///////  YELLOW /////////////
    public IEnumerator ChangeColorToYellow()
    {
        isPlaying = "Yes";

        Debug.Log("ChangeColorToYellow");
        colorFlashing = "Yellow";
        image.color = Color.yellow;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.black;

        GameObject.Find("ButtonTextToCopy").GetComponentInChildren<Text>().text = "My FlashR = Yellow";

        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToYellowBlack());
    }

    public IEnumerator ChangeColorToYellowBlack()
    {
        Debug.Log("ChangeColorToRedBlack");
        image.color = Color.black;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.yellow;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToYellow());
    }
    ///////  END YELLOW /////////////

    ///////  MAGENTA /////////////
    public IEnumerator ChangeColorToMagenta()
    {
        isPlaying = "Yes";

        Debug.Log("ChangeColorToMagenta");
        colorFlashing = "Magenta";
        image.color = Color.magenta;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.black;

        GameObject.Find("ButtonTextToCopy").GetComponentInChildren<Text>().text = "My FlashR = Purple";

        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToMagentaBlack());
    }

    public IEnumerator ChangeColorToMagentaBlack()
    {
        Debug.Log("ChangeColorToMagentaBlack");
        image.color = Color.black;
        FlashRText.text = "FlashR";
        FlashRText.color = Color.magenta;
        yield return new WaitForSeconds(timer);
        StartCoroutine(ChangeColorToMagenta());
    }
    ///////  END MAGENTA /////////////

    // Update is called once per frame
    void Update()
    {

        if (mainSlider.value == 1)
        {
            stoppingValue = "Stop";
            stopTimer();

        }

        if (mainSlider.value < 1)
        {
            stoppingValue = "Play";

        }

        if (stoppingValue == "Play")
        {
            
            if (isPlaying == "Yes")
            {
                timer = mainSlider.value / 2;

            }
            else
            {
                // StopAllCoroutines();
                if (colorFlashing == "Red")
                {
                    StartCoroutine(ChangeColorToRed());
                }
                if (colorFlashing == "Blue")
                {
                    StartCoroutine(ChangeColorToBlue());
                }
                if (colorFlashing == "Yellow")
                {
                    StartCoroutine(ChangeColorToYellow());
                }
                if (colorFlashing == "Green")
                {
                    StartCoroutine(ChangeColorToGreen());
                }
                if (colorFlashing == "Magenta")
                {
                    StartCoroutine(ChangeColorToMagenta());
                }

            }


            timer = mainSlider.value / 2;
        }
    }


}
