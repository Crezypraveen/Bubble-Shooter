using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Progress : MonoBehaviour

{
    // Start is called before the first frame update

public GameObject bar;
public int time;

    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimateBar(){
        LeanTween.scaleX(bar, 2.050f, time).setOnComplete(LoadNextScene);
    }
    void LoadNextScene()
    {
        // Replace "NextSceneName" with the actual name of your next scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
