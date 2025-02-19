using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameManager gameManager;

  public enum GameState
    {
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


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
