using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectinteract : MonoBehaviour
{
   public GameObject obj;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && obj !=null)
        {
            obj.GetComponent<Interactionobject>().inter();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            obj = collision.gameObject;
            
        }

        if (collision.CompareTag("Info"))
        {
            obj = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            obj = null;
        }

        if (collision.CompareTag("Info"))
        {
            obj = null;
        }

    }
}
