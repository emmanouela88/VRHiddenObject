using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerShow: MonoBehaviour
{

    
    bool isClicked;
    public bool lostByTime;
    public string nameLevel;
    public GameObject videoFinal;
    void Start()
    {
        videoFinal.SetActive(false);
        lostByTime = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindWithTag("Object") == null && !lostByTime)
        {
            //_anim.SetBool("Finish", true);
            videoFinal.SetActive(true);
            FindObjectOfType<ClickShow>().timeText.gameObject.SetActive(false);
            StartCoroutine(CountDown());
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
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(10.5f);
        SceneManager.LoadScene(nameLevel);
    }
}
