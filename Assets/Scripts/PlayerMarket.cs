using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMarket: MonoBehaviour
{

    
    bool isClicked;
    public bool lostByTime;
    public string nameLevel;
    public GameObject firework;
    public Light mainLight;
    void Start()
    {
        firework.SetActive(false);
        lostByTime = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindWithTag("Object") == null && !lostByTime)
        {
            FindObjectOfType<ClickMarket>().timeText.gameObject.SetActive(false);
            mainLight.intensity = 0.5f;
            StartCoroutine(Countdown());
        }
    }
    public void OnLetter()
    {
        isClicked = true;
    }

    public void OffLetter()
    {
        isClicked = false;
    }
   
    IEnumerator Countdown()
    {
        
        firework.SetActive(true);
        yield return new WaitForSeconds(8.5f);
        SceneManager.LoadScene(nameLevel);
    }
}
