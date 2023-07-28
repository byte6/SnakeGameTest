using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISnakeBodyPart 
{
    SnakeBodyPart GetSnakeBodyPart();

    int SetIndex(int index);
}
