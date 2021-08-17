using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    public string level;
    private string currentText = "";
    public Image imgDot;
    public Image imgArrowDot;
    public Image imgArrowGlass;
    void Start()
    {
        StartCoroutine(ShowText());
        imgDot.fillAmount = 0;
        imgArrowDot.fillAmount = 0;
        imgArrowGlass.fillAmount = 0;
    }

    // Update is called once per frame
    IEnumerator ShowText()
    {
        for (int i=0; i< fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<TMP_Text>().text = currentText;
            if (i >= 127)
            {
                imgDot.fillAmount += delay;
                imgArrowDot.fillAmount += delay;
            }

            if (i >= 220)
            {
                imgArrowGlass.fillAmount += delay;
                imgDot.fillAmount = 0;
                imgArrowDot.fillAmount = 0;
            }
            yield return new WaitForSeconds(delay);
        }

        SceneManager.LoadScene(level);
    }
}
