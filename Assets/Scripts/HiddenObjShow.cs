using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HiddenObjShow : MonoBehaviour
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
            randNum = Random.Range(0, 19);

            if ((gameObject.name=="Dress") && (randNum == 0)){
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "King") && (randNum == 1))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Tree") && (randNum == 2))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Bird") && (randNum == 3))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Jacket") && (randNum == 4))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Sing") && (randNum == 5))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Flower") && (randNum == 6))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Dog") && (randNum == 7))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Hat") && (randNum == 8))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Sky") && (randNum == 9))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Shine") && (randNum == 10))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Music") && (randNum == 11))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Boot") && (randNum == 12))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Cold") && (randNum == 13))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Street") && (randNum == 14))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Game") && (randNum == 15))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Shirt") && (randNum == 16))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Hot") && (randNum == 17))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Listen") && (randNum == 18))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0, 90, 0));
                HintObj.hintused = "n";
            }
            if ((gameObject.name == "Balloon") && (randNum == 19))
            {
                Instantiate(objPart, transform.position, Quaternion.Euler(0,90,0));
                HintObj.hintused = "n";
            }
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
        ClickShow.totalClicks = 0;
        //Instantiate(success, hidObj.transform.position, Quaternion.identity);
    }
}
