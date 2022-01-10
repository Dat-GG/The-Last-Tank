using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBulletController : BulletController, ILightningSkill
{
    public GameObject prefLightning;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.LogError("va cham");
            Lightning(50, prefLightning);
            collision.gameObject.GetComponent<EnemyController>().speed = 0;
            LeanTween.delayedCall(3f, () =>
            {
                collision.gameObject.GetComponent<EnemyController>().speed = 0.3f;
            });

        }
    }
    public void Lightning(int dameff, GameObject Lightning)
    {
        Instantiate(Lightning, this.gameObject.transform.position, this.gameObject.transform.rotation);
        damage = dameff;
    }
}
