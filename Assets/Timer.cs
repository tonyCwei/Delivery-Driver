using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static bool isEnd = false;

    [SerializeField] float totalTimeInMin = 3;
    [SerializeField] float noTimePitch = 1.05f;
    [SerializeField] TMP_Text timerText;
    [SerializeField] GameObject GameEndMenu;
    [SerializeField] GameObject pauseButton;
    public GameObject BGM;



    // MenuManager menuNeeded;
    
    private float currTime;
    
    // Start is called before the first frame update
    void Start()
    {   
        // menuNeeded = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
        isEnd = false;
        Time.timeScale = 1f;
        currTime = totalTimeInMin*60;
    }

    // Update is called once per frame
    void Update()
    {    
        currTime -= Time.deltaTime;
        if (currTime > 0) {
           if (currTime <= 10) {
              AudioSource audioSrc = BGM.GetComponent<AudioSource>();
              audioSrc.pitch = noTimePitch;
           }         
        int minute = Mathf.FloorToInt(currTime / 60);
        int second = Mathf.FloorToInt(currTime % 60); 
        timerText.text = "Time Left\n" + minute.ToString("00") + " : " + second.ToString("00");
        } else {
             AudioSource audioSrc = BGM.GetComponent<AudioSource>();
            audioSrc.Stop();
        Time.timeScale = 0f;
        isEnd = true;    
        // menuNeeded.End();
        GameEndMenu.SetActive(true);
        pauseButton.SetActive(false);
        }
        
    }
}
