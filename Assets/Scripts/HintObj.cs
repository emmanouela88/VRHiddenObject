using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintObj : MonoBehaviour
{
    public float rb = 1f;
    public float colortimer = 0;
    public static string hintready = "n";
    public static string hintused = "n";
    public Image secondImage;
    public GameObject hintShow;
    // Start is called before the first frame update
    void Start()
    {
        secondImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        colortimer += Time.deltaTime;

        if((colortimer >= .5)&& (rb > 0))
        {
            rb -= .05f;
            colortimer = 0;
            secondImage.gameObject.SetActive(false);
        }
        //GetComponent<Image>().fillAmount = 1;
        if (rb <= 0)
        {
            hintready = "y";
            secondImage.gameObject.SetActive(true);
            
            //Instantiate(hintShow, transform.position, Quaternion.identity);
        }
        
    }

    public void OnMouseDown()
    {
        if(hintready=="y")
        {
            hintused = "y";
            rb = 1f;
            Click.timeBonus -= 2f;
            secondImage.gameObject.SetActive(false);
        }
    }
}
