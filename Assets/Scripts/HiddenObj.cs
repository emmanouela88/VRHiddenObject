using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HiddenObj : MonoBehaviour
{
    public static string nameObj;
    public TMP_Text gameText;
    public TMP_Text hidObj;
    //public Transform success;
    public int randNum = 0;
    public GameObject objPart;

    public static int totalScore = 0;
    public static int remainItems = 21;

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
            randNum = Random.Range(0, 20);

            if ((gameObject.name=="Cat") && (randNum == 0)){
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "ipod") && (randNum == 1))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Car") && (randNum == 2))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Book") && (randNum == 3))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Laptop") && (randNum == 4))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Desk") && (randNum == 5))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "LaptopBag") && (randNum == 6))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Apple") && (randNum == 7))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "School") && (randNum == 8))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Pencil") && (randNum == 9))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Pencil_case") && (randNum == 10))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Pen") && (randNum == 11))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Notebook") && (randNum == 12))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Hi") && (randNum == 13))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Grey") && (randNum == 14))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Boy") && (randNum == 15))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Girl") && (randNum == 16))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Teacher") && (randNum == 17))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Orange") && (randNum == 18))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "House") && (randNum == 19))
            {
                Instantiate(objPart, transform.position, Quaternion.identity);
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Rat") && (randNum == 20))
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
        Click.totalClicks = 0;
        //Instantiate(success, hidObj.transform.position, Quaternion.identity);
    }
}
