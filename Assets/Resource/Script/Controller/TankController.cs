using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class TankController : MoveController
{
    public GameObject bodytank;
    public GameObject gun;
    public Transform shootpos;
    //public BulletController prefabBullet;
    public GameObject smoke;
    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            bodytank.transform.up = direction;
        }
        base.Move(direction);
    }
    protected virtual void RotateGun(Vector3 gundirection)
    {
        gun.gameObject.transform.up = gundirection;
    }
    protected virtual void Shoot()
    {
        //createBullet(shootpos);
    }
    public void ShootAgain()
    {
        Shoot();
    }
    //public BulletController createBullet(Transform shootpos)
    //{
    //    BulletController bullet = PoolingObject.createPooling<BulletController>(prefabBullet);
    //    if (bullet == null)
    //    {
    //        return Instantiate(prefabBullet, shootpos.position, shootpos.rotation);
    //    }
    //    bullet.time = 0;
    //    bullet.transform.position = shootpos.position;
    //    bullet.transform.rotation = shootpos.rotation;
    //    return bullet;
    //}
}
