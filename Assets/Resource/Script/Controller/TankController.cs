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
    //public string opponent;
    public GameObject smoke;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "BulletEnemy")
    //    {
    //        HP.Instance.TruMau(1);
    //    }
    //    if (collision.gameObject.tag == "BulletPlayer")
    //    {
    //        Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY);
    //        Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
    //        Destroy(gameObject);
    //    }
    //}
}
