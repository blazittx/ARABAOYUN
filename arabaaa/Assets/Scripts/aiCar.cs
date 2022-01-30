using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiCar : MonoBehaviour
{

    [SerializeField] public float moveSpeed;


    // Update is called once per frame
    void Update()
    {
        //float moveAmount = moveSpeed * Time.deltaTime;

        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "border")
        {
            Destroy(gameObject);
        }
    }
}
