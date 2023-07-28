using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : SnakeBodyBase
{
    public override void Set(SnakeBodyPart part, int index)
    {
        bodyIndex = index;
        bodyPart = part;
    }
}
