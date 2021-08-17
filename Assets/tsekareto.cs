using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tsekareto : MonoBehaviour
{
    string[] words = new string[] { "Table", "Window", "Prize","Mouse", "Door", "Bed", "Closet", "Ghost", "Shelf", "Box" };
    int count = 0;
    public AudioSource  corrects, wrongs;
    public List<AudioSource> audioSource = new List<AudioSource>();

    public Text infotxt,counttxt;

    // Start is called before the first frame update
    void Start()
    {
        infotxt.text = words[count];
        counttxt.text = count + "/10";
        audioSource[count].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickit(string s)
    {
        if (s.Equals(words[count]))
        {
            count++;
            if (count>9)
            {
                counttxt.text = "Win";
                StartCoroutine("Fade3");
                return;
            }
            counttxt.text = count + "/10";
            
            corrects.Play();
            StartCoroutine("Fade2");
        }
        else
        {
            wrongs.Play();
        }
    }



    IEnumerator Fade2()
    {


        yield return new WaitForSeconds(1f);

        audioSource[count].Play();
        infotxt.text = words[count];

    }

    IEnumerator Fade3()
    {


        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
