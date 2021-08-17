using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    public Animator anim;
    public AudioSource musicHover;
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animation>();
        
        musicHover.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void playAnim()
    {
        anim.SetBool("Music", true);
        musicHover.Play();
    }

    public void StopAnim()
    {
        anim.SetBool("Music", false);
        musicHover.Stop();
    }
}
