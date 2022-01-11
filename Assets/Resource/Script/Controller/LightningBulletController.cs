using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class LightningBulletController : BulletController, ILightningSkill
{
    public GameObject prefLightning;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Lightning(50, prefLightning);
            //collision.gameObject.GetComponent<EnemyController>().speed = 0;
            //LeanTween.delayedCall(3f, () =>
            //{
            //    collision.gameObject.GetComponent<EnemyController>().speed = 0.3f;
            //});
            Destroy(collision.gameObject);
            Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY);
        }
    }
    public void Lightning(int dameff, GameObject Lightning)
    {
        Instantiate(Lightning, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
