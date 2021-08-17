using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickMarket : MonoBehaviour
{
    public static int totalClicks = 0;
    public KeyCode mouseClick;
    public Text scoreText;
    public Text noText;
    public Text timeText;
    public static float timeBonus;
    public static int totalScore = 0;
    public bool hasRestart;
    public string levelLoad;
    public string menuLevel;
    public GameObject MainCanvas;
    public GameObject GCanvas;

    public AudioSource music;
    void Start()
    {
        timeBonus = 90;
        noText.gameObject.SetActive(false);
        MainCanvas.SetActive(true);
        GCanvas.SetActive(false);
        //scoreText.text = "Score: " + totalScore;
    }

    // Update is called once per frame
    void Update()
    {
        timeBonus -= Time.deltaTime;
        if (timeBonus > 0)
        {
                DisplayTime(timeBonus);
                
        }
        else if(timeBonus <= 0)
        {
            MainCanvas.SetActive(false);
            GCanvas.SetActive(true);
            FindObjectOfType<PlayerMarket>().lostByTime = true;
            GameObject.FindWithTag("Object").SetActive(false);
            totalClicks = 0;
        }
            
        scoreText.text = "Score: " + HiddenObjMarket.totalScore;
        if (HiddenObjMarket.remainItems == 0)
        {
            HiddenObjMarket.totalScore += HiddenObjMarket.totalScore + Mathf.RoundToInt(timeBonus);
            HiddenObjMarket.remainItems = -1;
        }

        if (Input.GetKeyDown(mouseClick))
        {
            noText.gameObject.SetActive(false);
            totalClicks++;
        }
        if(totalClicks >= 5)
        {
            HiddenObjMarket.totalScore /= HiddenObjMarket.totalScore;
            noText.gameObject.SetActive(true);
            Debug.Log("Fail");
            totalClicks = 0;
            music.Play();
        }       

    }

    void DisplayTime(float timeDisplay)
    {
        timeDisplay += 1;
        float min = Mathf.FloorToInt(timeDisplay / 60);
        float sec = Mathf.FloorToInt(timeDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(levelLoad);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(menuLevel);
    }
}
