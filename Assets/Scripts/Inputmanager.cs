using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class Inputmanager : MonoBehaviour, Gameplay.IPlayerMovementActions
{
    private Gameplay game;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Actions.interact?.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       if (context.started || context.canceled || context.performed)
        {
            Actions.moving?.Invoke(context.ReadValue<Vector2>());
            
        }
    }

    private void Awake()
    {
        game = new Gameplay();
        game.PlayerMovement.Enable();
        game.PlayerMovement.SetCallbacks(this);
    }

}

public static class Actions
{
    public static Action<Vector2> moving;
    public static Action interact;
    public static Action<string, string> scenemove;
}