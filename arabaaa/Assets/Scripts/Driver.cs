using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Driver : MonoBehaviour
{
    [SerializeField] public float steerSpeed;
    [SerializeField] public float moveSpeed;
    [SerializeField] public float slowSpeed;
    [SerializeField] public float fastSpeed;
 
 
    void Start()
    {
        
    }

   
    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "boost")
        { 
            moveSpeed = fastSpeed;

        }
        else if (collision.tag == "bump")
        {
            
            moveSpeed = slowSpeed;

        }
     
    }
}
