using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour

{
    public GameObject Player;
    private string Spawnpoint;
    public GameManager GameManager;


    public void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
  


    }
    private void OnEnable()
    {
        


    }
    private void OnDisable()
    {
       
    }

    public void Loadscenesp(string scenes, string spawnpoint)
    {
        Spawnpoint = spawnpoint;
        SceneManager.sceneLoaded += OnSceneLoaded;

        SceneManager.LoadScene(scenes);

    }


    public void OnSceneLoaded(Scene GamePlay, LoadSceneMode mode)
    {

        Setpoint(Spawnpoint);

         SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void Setpoint(string Spawnpoint)
    {

        GameObject spawnpointOJ = GameObject.Find(Spawnpoint);
        if(spawnpointOJ != null)
        {
            Transform spawnpointtf = spawnpointOJ.transform;
            Player.transform.position = spawnpointtf.position;
        }


    }
  /*   public void leavebasement()
    {
        GameObject spawn = GameObject.Find("SpawnPointUp");
        Player.transform.position = spawn.transform.position;
    }    



    public void spawnplayermenu()
    {
        GameObject spwan = GameObject.Find("SpawnPointMenu");
        Debug.Log("spawned");
        Player.transform.position = spwan.transform.position;
    }
    */
   
}

