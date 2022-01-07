using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBulletController : BulletController, IIceSkill
{
    public GameObject prefIce;
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
            Ice(1, prefIce);
            collision.gameObject.GetComponent<EnemyController>().speed = 0;
            LeanTween.delayedCall(2f, () =>
            {
                collision.gameObject.GetComponent<EnemyController>().speed = 5;
            });

        }
    }

    public void Ice(int dameff, GameObject Ice)
    {
        Instantiate(Ice, this.gameObject.transform.position, this.gameObject.transform.rotation);
        dame = dameff;
    }
    
}
