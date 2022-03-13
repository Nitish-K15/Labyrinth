using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : InputModule
{
    private Vector2 move;
    public override Vector2 GetInput()
    {
        move.x = Input.acceleration.x;
        move.y = Input.acceleration.y;
        return move;
    }
}
