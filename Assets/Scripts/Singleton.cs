using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    static Singleton Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
