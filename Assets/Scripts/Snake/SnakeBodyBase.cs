using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SnakeBodyBase : MonoBehaviour, ISnakeBodyPart
{
    protected SnakeBodyPart bodyPart;

    protected int bodyIndex = -1;

    public abstract void Set(SnakeBodyPart part, int index);

    public SnakeBodyPart GetSnakeBodyPart()
    {
        return bodyPart;
    }

    public int SetIndex(int index)
    {
        return bodyIndex;
    }
}
