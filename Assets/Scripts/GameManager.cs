using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
   

    public  LevelManager levelManager;
    public GameStateManager gameState;
    public UIManager iManager;


    void Start()
    {

       

    }

    private void Awake()
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
