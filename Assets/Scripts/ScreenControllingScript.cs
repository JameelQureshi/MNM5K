using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenControllingScript : MonoBehaviour
{

    public GameObject introScreen1;
    public GameObject introScreen2;
    public GameObject introScreen3;


    // Start is called before the first frame update
    void Start()
    {
        introScreen2.SetActive(false);
        introScreen1.SetActive(true);
        introScreen3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ForIntroScreen2()
    {
        introScreen2.SetActive(true);
        introScreen1.SetActive(false);
        introScreen3.SetActive(false);
    }
    public void ForIntroScreen3()
    {
        introScreen2.SetActive(false);
        introScreen1.SetActive(false);
        introScreen3.SetActive(true);
    }
    public void ForARScene()
    {
        SceneManager.LoadScene(1);
    }


}
