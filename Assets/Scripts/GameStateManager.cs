using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public GameManager gameManager;

  public enum GameState
    {
        MainMenu_State,
        Gameplay_State,
        Paused_State


    }
    
    public GameState currentState { get; private set; }

    [SerializeField] private string currentStateDebug;
    [SerializeField] private string lastStateDebug;



    public void ChangeState(GameState newState)
    {
        lastStateDebug = currentState.ToString();
        currentState = newState;
        HandleStateChange(newState);
        currentStateDebug = currentState.ToString();
    }

    private void HandleStateChange(GameState state)
    {
        switch (state)
        {
            case GameState.MainMenu_State:
                Debug.Log("Switched to MainMenu State");
                Time.timeScale = 0;
                gameManager.iManager.EnableMainMenu();
                Cursor.visible = true;
   
                break;

            case GameState.Gameplay_State:
                Debug.Log("Switched to Gameplay State");
                Time.timeScale = 1;
                gameManager.iManager.GamePlayUI();
                Cursor.visible = false;

                break;

            case GameState.Paused_State:
                Debug.Log("Switched to Paused State");
                Time.timeScale = 0;
                gameManager.iManager.EnablePause();
                Cursor.visible = true;

                break;
        }

    }

    void Start()
    {
        ChangeState(GameState.MainMenu_State);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (currentState == GameState.Gameplay_State || currentState == GameState.Paused_State))
        {
            if (currentState == GameState.Paused_State)
            {
                ChangeState(GameState.Gameplay_State);
            }
            else
            {
                ChangeState(GameState.Paused_State);
            }
        }

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Main Menu")
        {
            ChangeState (GameState.MainMenu_State);

        }
    }
}
