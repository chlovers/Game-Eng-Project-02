using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public string spawnPoint;
    public string sceneToLoad;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(sceneToLoad + spawnPoint);
           GameManager.Instance.levelManager.Loadscenesp(sceneToLoad, spawnPoint);
        }
    }

}
