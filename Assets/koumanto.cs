using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koumanto : MonoBehaviour
{
    // Start is called before the first frame update

    int count = 0;
    string[] phrases = new string[]{ "The angry gorilla", "The white shnake", "The small duck","The brown rabbit","The tall giraffe","the dad lion","The big elephant"};
    bool gonext = false;
    public bool runele=false;
    public float speedele = 10;
    public GameObject player,elepgant,imagestatus,canvas2,canvas1;
    public Animator anim;
    public Text infotxt;
    public Sprite winsprite, loosesprite;
    public List<AudioSource> audioSource = new List<AudioSource>();
    public AudioSource bgsound, corrects, wrongs;
    void Start()
    {
        bgsound.Play();

        anim = elepgant.gameObject.GetComponent<Animator>();
        imagestatus.GetComponent<Image>().sprite = null;
        imagestatus.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        canvas2.SetActive(true);
        canvas1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (runele)
        {
            elepgant.transform.position = new Vector3(elepgant.transform.position.x, elepgant.transform.position.y,
                elepgant.transform.position.z + (speedele * Time.deltaTime));
        }
        if (gonext)
        {
            if (count <= 3)
            {
                player.transform.position = new Vector3(player.transform.position.x, 6.6f,
                player.transform.position.z - (2 * Time.deltaTime));
            }
            else
            {
                player.transform.position = new Vector3(player.transform.position.x - (2 * Time.deltaTime), 6.6f,
                player.transform.position.z );
            }
            if (player.transform.position.z < 25f && count == 1)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;
            }
            if (player.transform.position.z < 6.6f && count == 2)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;
            }
            if (player.transform.position.z < -25.4f && count==3)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;
            }
            if (player.transform.position.x < -39f && count == 4)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;
            }
            if (player.transform.position.x < -70f && count == 5)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;
            }
            if (player.transform.position.x < -100f && count == 6)
            {
                audioSource[count].Play();
                infotxt.text = phrases[count];
                gonext = false;

            }
            if (count == 7)
            {
                audioSource[count].Play();
                runele = true;
                gonext = false;
                anim.SetBool("isrunning", true);
                StartCoroutine("Fade3");
            }



        }
    }

    public void pressIt()
    {
        if (gonext) return;
        corrects.Play();
        imagestatus.GetComponent<Image>().sprite = winsprite;
        imagestatus.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        audioSource[count].Stop();
        
        infotxt.text = "";
        gonext = true;
        count++;
        StartCoroutine("Fade");
    }

    public void wronge()
    {
        if (gonext) return;
        wrongs.Play();
        imagestatus.GetComponent<Image>().sprite = loosesprite;
        imagestatus.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        
        StartCoroutine("Fade2");
    }

    IEnumerator Fade2()
    {


        yield return new WaitForSeconds(1f);
        audioSource[count].Play();
    }

    IEnumerator Fade()
    {

        
        yield return new WaitForSeconds(2f);
        imagestatus.GetComponent<Image>().sprite = null;
        imagestatus.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    IEnumerator Fade3()
    {


        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       // Application.LoadLevel(Application.loadedLevel);
    }

    public void playgame()
    {
        infotxt.text = phrases[count];
        audioSource[count].Play();
        canvas2.SetActive(false);
        canvas1.SetActive(true);
    }


}
