using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    
    public GameObject pasueMenuUI;
    public GameObject pauseButton;
    public GameObject BGM;
        
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
           if (isPaused) {
            
             Resume();
           } else if (!isPaused && !Timer.isEnd) {
            
            Pause();
           }
        }       
    }

    public void Resume(){
        AudioSource audioSrc = BGM.GetComponent<AudioSource>();
        audioSrc.Play();



        pauseButton.SetActive(true);
        pasueMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause(){
        AudioSource audioSrc = BGM.GetComponent<AudioSource>();
        audioSrc.Pause();

        pauseButton.SetActive(false);
        pasueMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }



}
