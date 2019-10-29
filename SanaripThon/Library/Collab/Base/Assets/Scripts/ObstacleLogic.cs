using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLogic : MonoBehaviour
{
    public float blinkDistance = 1f;

    private Vector2 _movement;

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }

    public void OnTriggerEnter2D(Collider2D playerCollider)
    {
        var newPosition = new Vector2()
        {
            x = playerCollider.gameObject.transform.position.x - _movement.x * blinkDistance,
            y = playerCollider.gameObject.transform.position.y - _movement.y * blinkDistance
        };
        playerCollider.gameObject.transform.position = newPosition;
    }


}
