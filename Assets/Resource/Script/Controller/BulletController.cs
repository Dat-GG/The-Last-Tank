using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController
{
    public int time;
    public int dame;
    //public GameObject smoke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void BulletEx()
    {
        time += 1;
        if (time == 50)
        {
            //Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }
    }
}
