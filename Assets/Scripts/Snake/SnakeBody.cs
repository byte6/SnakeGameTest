using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SnakeBody : SnakeBodyBase, ISnakeBodyPart
{
    public override void Set(SnakeBodyPart part, int index)
    {
        bodyIndex = index;
        bodyPart = part;
    }
}
