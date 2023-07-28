using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SnakeTail : SnakeBodyBase
{
    public override void Set(SnakeBodyPart part, int index)
    {
        bodyIndex = index;
        bodyPart = part;
    }
}
