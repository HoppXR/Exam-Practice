using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControlManager
{
    private static Controls _Controls;

    private static Vector3 _mousePos;

    public static void Init(Player myPlayer)
    {
        _Controls = new Controls();

        _Controls.Game.Enable();

        _Controls.Game.WASD.performed += ctx => 
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };

        _Controls.Game.Jump.performed += ctx =>
        {
            myPlayer.PlayerJump(ctx.ReadValue<Vector3>());
        };

        _Controls.Game.Look.performed += ctx =>
        {
            myPlayer.SetLookRotation(ctx.ReadValue<Vector2>());
        };
    }

    public static void SetGameControls()
    {
        _Controls.Game.Enable();
    }
}
