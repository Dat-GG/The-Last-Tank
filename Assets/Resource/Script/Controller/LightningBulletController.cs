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
            Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY);
            Lightning(50, prefLightning);
            //collision.gameObject.GetComponent<EnemyController>().speed = 0;
            //LeanTween.delayedCall(3f, () =>
            //{
            //    collision.gameObject.GetComponent<EnemyController>().speed = 0.3f;
            //});
            Destroy(collision.gameObject);
            GameController.instance.scorenumber += 1;
            if (GameController.instance.scorenumber % 10 == 0 && GameController.instance.scorenumber > 0)
            {
                GameController.instance.Lvnumber += 1;
            }
        }
    }
    public void Lightning(int dameff, GameObject Lightning)
    {
        Instantiate(Lightning, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
