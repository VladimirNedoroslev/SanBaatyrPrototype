using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterMazeTrigger : MonoBehaviour
{
    public GameObject maze;

    private void OnTriggerEnter2D(Collider2D other)
    {
        maze.gameObject.SetActive(true);
        Destroy(gameObject);
        Player.Instance.speed = 0;
    }
}
