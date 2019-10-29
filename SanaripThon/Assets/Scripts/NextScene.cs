using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public GameObject Scene2;
    
    public void Next()
    {
        Scene2.SetActive(true);
    }
}
