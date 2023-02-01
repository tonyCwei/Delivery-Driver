using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
   [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
   [SerializeField] float destroyDelay = 0.5f;
  
   
   
   static public int deliveryCount = 0;
    bool hasPackage = false;
   
    SpriteRenderer spriteRenderer ;

    void Start() {
      spriteRenderer = GetComponent<SpriteRenderer>();
    }



  
   

   void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Package") {
        if (hasPackage) {
         Debug.Log("You already has a Package"); 
        } else {
           hasPackage = true;
           spriteRenderer.color = hasPackageColor;
           SoundManager.PlaySound("pickUp");
           Destroy(other.gameObject, destroyDelay);
           
                      
        }

      } else if (other.tag == "Customer") {
         if (hasPackage) {
            SoundManager.PlaySound("deliver");
          spriteRenderer.color = noPackageColor; 
          Destroy(other.gameObject, 0f);
          hasPackage = false;           
          deliveryCount++;
         } else {
           Debug.Log("No Package to deliver");
         }
      }  
   }

   // public int getDeliveryCount() {
   //    return deliveryCount;
   // }

 


}
