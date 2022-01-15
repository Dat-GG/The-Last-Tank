using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBulletController : BulletController, IIceSkill
{
    public GameObject prefIce;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Ice(50, prefIce);
            collision.gameObject.GetComponent<EnemyController>().speed = 0.1f;
            LeanTween.delayedCall(2f, () =>
            {
                collision.gameObject.GetComponent<EnemyController>().speed = 0.5f;
            });
            //GameController.instance.scorenumber += 1;
        }
    }
    public void Ice(int dameff, GameObject Ice)
    {
        Instantiate(Ice, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
