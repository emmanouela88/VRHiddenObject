using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickShow : MonoBehaviour
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
        music.GetComponent<AudioSource>();
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
            FindObjectOfType<PlayerShow>().lostByTime = true;
            GameObject.FindWithTag("Object").SetActive(false);
            totalClicks = 0;            
        }
            
        scoreText.text = "Score: " + HiddenObjShow.totalScore;
        if (HiddenObjShow.remainItems == 0)
        {
            HiddenObjShow.totalScore += HiddenObjShow.totalScore + Mathf.RoundToInt(timeBonus);
            HiddenObjShow.remainItems = -1;
        }

        if (Input.GetKeyDown(mouseClick))
        {
            noText.gameObject.SetActive(false);
            totalClicks++;
        }
        if(totalClicks >= 5)
        {
            HiddenObjShow.totalScore /= HiddenObjShow.totalScore;
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
