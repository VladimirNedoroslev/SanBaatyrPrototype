using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveGameField : MonoBehaviour
{
    public GameObject darkening;
    public GameObject dialog;

    private void OnTriggerLeave2d(Collider2D other)
    {
        darkening.gameObject.SetActive(true);
        dialog.gameObject.SetActive(true);
        Destroy(gameObject);
        Player.Instance.speed = 0f;
    }
}
