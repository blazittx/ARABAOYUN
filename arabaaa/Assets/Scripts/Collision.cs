using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool �it�it = false;
    [SerializeField] float sc;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!!!!!!!:(");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bep" /*&& !�it�it*/)
        {
            //�it�it = true;
            Debug.Log("B�P B�P B�PPPP");
            Destroy(collision.gameObject,sc);
        }
        if(collision.tag == "l�pl�p" /*&& �it�it*/)
        {
            Debug.Log("LAPS LAPS");
            //�it�it = false;
        }
    }
}
