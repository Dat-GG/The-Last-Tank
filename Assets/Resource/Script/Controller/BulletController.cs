using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController
{ 
    public int time;
    public int damage;
    public GameObject smoke;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    public void BulletEx()
    {
        time += 1;
        if (time == 50)
        {
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }
    }
   
}
public class Bullet: SingletonMonoBehaviour<BulletController>
{

}
