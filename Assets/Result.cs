using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{

    [SerializeField] TMP_Text resultText;
    [SerializeField] AudioSource audioSrc;
    [SerializeField] GameObject endingBGM;
    [SerializeField] GameObject inGameBGM;

    // Start is called before the first frame update
    void Start()
    {
        // audioSrc = audioSrc.GetComponent<AudioSource>();
        
       

    }

    // Update is called once per frame
    void Update()
    {
        endingBGM.SetActive(true);
        inGameBGM.SetActive(false);
        // audioSrc.Play();
        int deliveryCount = Delivery.deliveryCount;

        if (deliveryCount == 0 ){
            resultText.text = "Don't Worry! They can just ask for a refund!";
        } else if (deliveryCount == 5) {
        resultText.text = "Awesome! All packages have been delivered!";
        } else {
       resultText.text = "Great Job! You delivered a total of " + deliveryCount.ToString() + " Packages!";
        } 

    }
}
