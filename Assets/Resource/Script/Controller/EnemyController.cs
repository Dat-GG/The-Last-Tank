using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class EnemyController : TankController
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerdic = Player.Instance.transform.position - transform.position;

        Move(playerdic);
        RotateGun(playerdic);
        if (Random.Range(0, 100) % 30 == 0)
        {
            Shoot();
        }
    }
}
