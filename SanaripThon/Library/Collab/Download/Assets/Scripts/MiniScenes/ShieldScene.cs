using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScene : MonoBehaviour, IMiniScene
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(GameObject player)
    {
        Player.Instance.speed = Player.defaultSpeed * 0.5f;

    }
}
