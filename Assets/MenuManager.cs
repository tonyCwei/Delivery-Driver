using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public int mainMenuScene;
   public int gameScene;
   public GameObject endMenu;
   public GameObject pauseButton;
   
   

   public void quitGame() {
      Application.Quit();
   }

   public void returnToMenu() {
       SceneManager.LoadScene(mainMenuScene);
   }

   public void startGame() {
       Delivery.deliveryCount = 0;
       SceneManager.LoadScene(gameScene);

   }


   public void reset() {
       
       SceneManager.LoadScene(gameScene);
       PauseMenu.isPaused = false;
       Delivery.deliveryCount = 0;
       
   }
   
    public void End(){
        endMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

   




   
}
