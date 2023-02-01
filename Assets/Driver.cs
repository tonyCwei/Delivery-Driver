using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float defaultMoveSpeed = 22f;
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 22f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float boostDuration = 5f;
    [SerializeField] float slowDuration = 5f;
    [SerializeField] private bool isPlayer = false;

    private Animator anim;
    private float steerAmount;
    private float moveAmount;

    private void Awake()
    {
      
    }

   private void Start() {
     
   }


    void Update()
    {   
        if (isPlayer) {
         steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;       
         moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;       
        if (transform.rotation.z >= -90 && transform.rotation.z <= 90 && Input.GetKey(KeyCode.DownArrow)) {
           transform.Rotate(0,0,steerAmount);
           }
            else {
            transform.Rotate(0,0,-steerAmount);
        }
        transform.Translate(0,moveAmount,0); 
        }

    }

   void OnCollisionEnter2D(Collision2D other) {
    //  GetComponent<Rigidbody>().velocity = Vector3.zero;
   }

    void OnTriggerEnter2D(Collider2D other) {
      if (isPlayer) {
       if (other.tag == "Boost") {
        SoundManager.PlaySound("boost");
       StartCoroutine(boostingSpeed());
      Destroy(other.gameObject, 0.1f);

      } else if (other.tag == "Bump") {
        StartCoroutine(slowingSpeed()); 
      } else if (other.tag == "ActiveBuilding") {
        Debug.Log("Entering");
        anim = other.GetComponent<Animator>();
        anim.SetTrigger("carEnter");
      } 
      }
    }

    void OnTriggerExit2D(Collider2D other) {
      if (isPlayer) {
      if (other.tag == "ActiveBuilding") {
        Debug.Log("Exiting");
        anim = other.GetComponent<Animator>();
        anim.SetTrigger("carExit");
      }
      }
    }

   IEnumerator boostingSpeed () {
        moveSpeed = boostSpeed;
       yield return new WaitForSeconds (boostDuration);
       moveSpeed = defaultMoveSpeed;
   }

    IEnumerator slowingSpeed () {
       moveSpeed = slowSpeed;
        yield return new WaitForSeconds (slowDuration);
        moveSpeed = defaultMoveSpeed;
   }


 


}
