using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeliveryCount : MonoBehaviour
{
    
    [SerializeField] TMP_Text deliveryCountText;
    [SerializeField] GameObject GameEndMenu;
    [SerializeField] GameObject pauseButton;
    private int  deliveryCount;


    void Start()
    {
        deliveryCount = 0;
    }

    // Update is called once per frame
    void Update()
    {  
        deliveryCount = Delivery.deliveryCount;
        
        deliveryCountText.text = "Packages Delivered x "+ deliveryCount.ToString("00");

       if (deliveryCount == 5) {
        Time.timeScale = 0f;
        Timer.isEnd = true;    
        GameEndMenu.SetActive(true);
        pauseButton.SetActive(false);

       }


    }
}
