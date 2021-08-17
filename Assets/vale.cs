using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void valeStroke()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void vgaleStroke()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
