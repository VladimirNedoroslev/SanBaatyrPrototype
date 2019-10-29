using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Serialization;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float discreteMoveNumber = 10;
    public Animator playerAnimator;


    public MoveButtonHandler MoveUpButton;
    public MoveButtonHandler MoveDownButton;
    public MoveButtonHandler MoveLeftButton;
    public MoveButtonHandler MoveRightButton;

    private MoveButtonHandler _moveButtonUpHandler;

    private void Start()
    {
        discreteMoveNumber = Player.Instance.discreteMove;
    }

    public void Update()
    {
        playerAnimator.SetBool("Idle", true);
        if (MoveUpButton.ButtonIsPressed)
        {
            Move(Vector2.up);
            playerAnimator.SetBool("MovingUp", true);
            playerAnimator.SetBool("MovingRight", false);
            playerAnimator.SetBool("MovingLeft", false);
            playerAnimator.SetBool("MovingDown", false);
            playerAnimator.SetBool("Idle", false);
        }
        if (MoveDownButton.ButtonIsPressed)
        {
            Move(Vector2.down);
            playerAnimator.SetBool("MovingUp", false);
            playerAnimator.SetBool("MovingRight", false);
            playerAnimator.SetBool("MovingLeft", false);
            playerAnimator.SetBool("MovingDown", true);
            playerAnimator.SetBool("Idle", false);

        }
        if (MoveRightButton.ButtonIsPressed)
        {
            Move(Vector2.right);
            playerAnimator.SetBool("MovingUp", false);
            playerAnimator.SetBool("MovingRight", true);
            playerAnimator.SetBool("MovingLeft", false);
            playerAnimator.SetBool("MovingDown", false);
            playerAnimator.SetBool("Idle", false);

        }
        if (MoveLeftButton.ButtonIsPressed)
        {
            playerAnimator.SetBool("MovingUp", false);
            playerAnimator.SetBool("MovingRight", false);
            playerAnimator.SetBool("MovingLeft", true);
            playerAnimator.SetBool("MovingDown", false);
            playerAnimator.SetBool("Idle", false);
            Move(Vector2.left);
        }
    }

    private void Move(Vector2 direction)
    {
        for (int i = 0; i < discreteMoveNumber; i++)
        {
            Player.Instance.transform.position = (Vector2) Player.Instance.transform.position + 
                                                 Player.Instance.speed * direction / discreteMoveNumber;
        }
    }
}
