using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HiddenObjMarket : MonoBehaviour
{
    public static string nameObj;
    public TMP_Text gameText;
    public TMP_Text hidObj;
    public int randNum = 0;
    public GameObject objPart;

    public static int totalScore = 0;
    public static int remainItems = 23;

    public Transform pairedObj;
    
    // Start is called before the first frame update
    void Start()
    {
        if (pairedObj != null)
        {
            pairedObj.GetComponent<Collider>().enabled = false;
        }        
    }

    // Update is called once per frame
    void Update()
    {
            if (HintObj.hintused == "y")
        {
            randNum = Random.Range(0, 23);

            if ((gameObject.name=="Watermelon") && (randNum == 0)){
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Sandwich") && (randNum == 1))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Grandpa") && (randNum == 2))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Yuk!") && (randNum == 3))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Eye") && (randNum == 4))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Melon") && (randNum == 5))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Tomato") && (randNum == 6))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Grandma") && (randNum == 7))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Bed") && (randNum == 8))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Ear") && (randNum == 9))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Banana") && (randNum == 10))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Cheese") && (randNum == 11))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Sweets") && (randNum == 12))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Biscuit") && (randNum == 13))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Nose") && (randNum == 14))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Pear") && (randNum == 15))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Salad") && (randNum == 16))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Chocolate") && (randNum == 17))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Bread") && (randNum == 18))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Leg") && (randNum == 19))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Juice") && (randNum == 20))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Presents") && (randNum == 21))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Hand") && (randNum == 22))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Head") && (randNum == 23))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            //Debug.Log(randNum);
        }
    }

    public void ButtonToDestroy()
    {

        nameObj = gameObject.name;
        if (gameObject.name != pairedObj.name)
        {
            pairedObj.GetComponent<Collider>().enabled = true;
            hidObj.GetComponent<TMP_Text>().text = pairedObj.name;
            totalScore += 10;
            Destroy(gameObject);            
            Destroy(gameText.gameObject);
            remainItems -= 1;
        }
        else
        {
            totalScore += 10;
            remainItems -= 1;
            Destroy(gameObject);
            hidObj.fontStyle = FontStyles.Strikethrough;
            Destroy(hidObj.gameObject, 0.5f);
            
        }
        //remainItems = -1;
        ClickMarket.totalClicks = 0;
        //Instantiate(success, hidObj.transform.position, Quaternion.identity);
    }
}
