﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : TankController
{
    public int i;
    //public BulletController prefabBullet;
    public GameObject BonusGun;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        Move(direction);

        Vector3 gundirection = new Vector3(
            Input.mousePosition.x - Screen.width / 2,
            Input.mousePosition.y - Screen.height / 2);
        RotateGun(gundirection);

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Shoot();
        //    //createBullet(shootpos);
        //}
        if (GameController.instance.scorenumber % 10 == 0 && GameController.instance.scorenumber > 0)
        {
            BonusGun.SetActive(true);
            
            LeanTween.delayedCall(6f, () =>
            {
                BonusGun.SetActive(false);
            });
        }
    }
    public void MoveUp()
    {
        var direction = new Vector3(0, i, 0);
        Move(direction);
    }
    public void MoveDown()
    {
        var direction = new Vector3(0, -i, 0);
        Move(direction);
    }
    public void MoveLeft()
    {
        var direction = new Vector3(-i, 0, 0);
        Move(direction);
    }
    public void MoveRight()
    {
        var direction = new Vector3(i, 0, 0);
        Move(direction);
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
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletEnemy")
        {
            this.GetComponent<HPController>().TruMau(collision.gameObject.GetComponent<BulletEnemyController>().dame);
            Destroy(collision.gameObject);
        }
      
        if (collision.gameObject.tag == "SpeedItem")
        {
            speed += 5;
            LeanTween.delayedCall(5f, () =>
            {
                speed -= 5;
            });
            Destroy(collision.gameObject);
        }
    }   
}
public class Player : SingletonMonoBehaviour<PlayerController>
{

}

