using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Image soundOn,
        soundOff;

    public Image musicOn,
        musicOff;

    int indexSound = 0;
    int indexMusic = 0;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void soundON()
    {
        indexSound = 1;
        soundOff.gameObject.SetActive(true);
        soundOn.gameObject.SetActive(false);
    }

    public void soundOFF()
    {
        indexSound = 0;
        soundOff.gameObject.SetActive(false);
        soundOn.gameObject.SetActive(true);
    }

    public void musicON()
    {
        indexMusic = 1;
        musicOff.gameObject.SetActive(true);
        musicOn.gameObject.SetActive(false);
    }

    public void musicOFF()
    {
        indexMusic = 1;
        musicOff.gameObject.SetActive(false);
        musicOn.gameObject.SetActive(true);
    }

    public void RateClick()
    {
        Debug.Log("Clicked");
    }

    public void MoveToScene(int SceneID)
    {
        Debug.Log("SceneManager Called");
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneID);
    }
}
