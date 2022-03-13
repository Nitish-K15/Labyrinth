using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : InputModule
{
    private Vector2 move;
    public override Vector2 GetInput()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        return move;
    }
}
