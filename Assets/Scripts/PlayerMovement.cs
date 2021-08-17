using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    
    bool isClicked;
    public Animator _anim;
    public bool lostByTime;
    public string nameLevel;
    public AudioSource bell;
    public AudioSource crowd;
    void Start()
    {
        lostByTime = false;
        _anim.SetBool("Finish",false);
       
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindWithTag("Object") == null && !lostByTime)
        {
            crowd.Stop();
            bell.Play();
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
        _anim.SetBool("Finish", true);
        FindObjectOfType<Click>().timeText.gameObject.SetActive(false);
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(nameLevel);
    }
}
