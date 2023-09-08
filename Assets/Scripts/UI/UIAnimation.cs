using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/**
 * UIAnimation - Animates the main menu
 */

public class UIAnimation : MonoBehaviour
{
    public GameObject menuText;
    private string s;
    private int i;

    void Start()
    {
        s = menuText.GetComponent<Text>().text;
        StartCoroutine(Wait());
    }


    // colors in the text on the main menu
    IEnumerator Wait()
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s.Substring(i, 1).Equals("\n"))
                continue;

            menuText.GetComponent<Text>().text = s.Substring(0, i + 1);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
