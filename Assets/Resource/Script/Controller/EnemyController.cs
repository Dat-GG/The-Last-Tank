using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class EnemyController : TankController, IFireSkill
{
    public GameObject player;
    public BulletEnemyController prefabBullet;
    public GameObject prefFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerdic = Player.Instance.transform.position - transform.position;

        Move(playerdic);
        RotateGun(playerdic);
        if (Random.Range(0, 100) % 60 == 0)
        {
            //Shoot();
            createBullet(shootpos);
        }
    }
    public BulletEnemyController createBullet(Transform shootpos)
    {
        BulletEnemyController bullet = PoolingObject.createPooling<BulletEnemyController>(prefabBullet);
        if (bullet == null)
        {
            return Instantiate(prefabBullet, shootpos.position, shootpos.rotation);
        }
        bullet.time = 0;
        bullet.transform.position = shootpos.position;
        bullet.transform.rotation = shootpos.rotation;
        return bullet;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "BulletEnemy")
        //{
        //    HP.Instance.TruMau(1);
        //}
        if (collision.gameObject.tag == "BulletPlayer")
        {
            Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Fire(1, prefFire);
            Destroy(gameObject);
            GameController.instance.scorenumber += 1;
            if (GameController.instance.scorenumber % 20 == 0)
            {
                GameController.instance.Lvnumber += 1;
            }
            Destroy(collision.gameObject);
        }   
    }
    public void Fire(int dameff, GameObject Fire)
    {
        Instantiate(Fire, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
