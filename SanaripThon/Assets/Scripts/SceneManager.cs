using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public Animator ImageAnimator;
    public GameObject Scene2;
    public GameObject GameplayScene;
    public GameObject Joystick;

    public GameObject mazePanel;
    public ItemBehavior CloakItemBehavior; 
    public ItemBehavior BootsItemBehavior; 
    public ItemBehavior ShieldItemBehavior;

    public GameObject MazeEntryPoint;
     

    public void Awake()
    {
        Scene2.SetActive(false);
        ImageAnimator.gameObject.SetActive(true);
        Joystick.SetActive(false);
    }
    
    
    public void GoToGame()
    {
        Scene2.SetActive(false);
        ImageAnimator.gameObject.SetActive(false);
        GameplayScene.SetActive(true);
        Joystick.SetActive(true);
    }

    public void GetToTheDungeon()
    {
        mazePanel.gameObject.SetActive(false);
        Player.Instance.transform.position = new Vector3(0, -1.5f, Player.Instance.transform.position.z);
        if (CloakItemBehavior.IsChosen)
        {
            gameObject.AddComponent<CloakScene>().LoadScene(Joystick);
        }
        else if (ShieldItemBehavior.IsChosen)
        {
            gameObject.AddComponent<ShieldScene>().LoadScene(Joystick);
        }
        else
        {
            gameObject.AddComponent<BootsScene>().LoadScene(Joystick);
        }

        Player.Instance.speed = Player.defultSpeed;
        Player.Instance.transform.position = new Vector3(0,-1.5f, Player.Instance.transform.position.z);
    }
    
}
