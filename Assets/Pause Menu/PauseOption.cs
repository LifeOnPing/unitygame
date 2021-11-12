using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOption : MonoBehaviour
{
    public AudioClip song;
    private AudioSource audioSource;
    
    public GameObject menu;
    private bool isShowing = true;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = song;
    }


    void Update() {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);

            if(isShowing)
            {
                audioSource.Pause();
            } else{
                audioSource.Play();
            }
            
            Time.timeScale = 1f;
        }
    }
    


    public void gameResume()
    {
        audioSource.Play();
        Time.timeScale = 1f;
        isShowing = !isShowing;
        menu.SetActive(isShowing);
    }
    
    
    public void gameRestart()
    {
        audioSource.Play();
        audioSource.Play();
        Time.timeScale = 1f;
        isShowing = !isShowing;
        menu.SetActive(isShowing);
    }


    public void gameExit()
    {
        Application.Quit();
    }
}
