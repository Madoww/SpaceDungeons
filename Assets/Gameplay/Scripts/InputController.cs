using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputController : Singleton<InputController>
{
    public PlayerInputActions.PlayerActions PlayerActions
    {
        get
        {
            if(playerInputActions == null)
            {
                playerInputActions = new PlayerInputActions();
                playerInputActions.Player.Enable();
            }

            return playerInputActions.Player;
        }
    }

    private PlayerInputActions playerInputActions;
}
