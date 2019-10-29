using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    public float speed;
    public float discreteMove;

    public static float defultSpeed = 0.5f;
}
