using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletController : BulletController, IFireBulletSkill
{
    public GameObject preFireBullet;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FireBullet(50, preFireBullet);
            collision.gameObject.transform.position = GameController.instance.Location.transform.position;
        }
    }
    public void FireBullet(int dameff, GameObject Fire)
    {
        Instantiate(Fire, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
