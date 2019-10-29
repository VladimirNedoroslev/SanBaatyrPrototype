using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterFinishTrigger : MonoBehaviour
{
    public GameObject darkening;
    public GameObject dialog;

    private void OnTriggerEnter2D(Collider2D other)
    {
        darkening.gameObject.SetActive(true);
        dialog.gameObject.SetActive(true);
        Destroy(gameObject);
        Player.Instance.speed = 0f;
    }
}