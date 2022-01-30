using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool çitçit = false;
    [SerializeField] float sc;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!!!!!!!:(");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bep" /*&& !çitçit*/)
        {
            //çitçit = true;
            Debug.Log("BÝP BÝP BÝPPPP");
            Destroy(collision.gameObject,sc);
        }
        if(collision.tag == "lüplüp" /*&& çitçit*/)
        {
            Debug.Log("LAPS LAPS");
            //çitçit = false;
        }
    }
}
