using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBulletController : BulletController, IWaterSkill
{
    public GameObject preWater;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Water(50, preWater);
            collision.gameObject.GetComponent<EnemyController>().speed = 0f;
            LeanTween.delayedCall(2f, () =>
            {
                collision.gameObject.GetComponent<EnemyController>().speed = 0.5f;
            });
            //GameController.instance.scorenumber += 1;
        }
    }
    public void Water(int dameff, GameObject Water)
    {
        Instantiate(Water, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
