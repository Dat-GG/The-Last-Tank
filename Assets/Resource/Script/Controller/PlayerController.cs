using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : TankController, IFireSkill
{
    public int i;
    public BulletController prefabBullet;
    public GameObject prefFire;
    //public GameObject jin;
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

        if (Input.GetMouseButtonDown(0))
        {
            //Shoot();
            createBullet(shootpos);
        }
        var pos = this.transform.position;
        if (pos.x >= 13)
        {
            pos.x = 13;
        }
        if (pos.x <= -13)
        {
            pos.x = -13;
        }
        if (pos.y >= 7)
        {
            pos.y = 7;
        }
        if (pos.y <= -7)
        {
            pos.y = -7;
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
    public BulletController createBullet(Transform shootpos)
    {
        BulletController bullet = PoolingObject.createPooling<BulletController>(prefabBullet);
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
        if (collision.gameObject.tag == "BulletEnemy")
        {
            HP.Instance.TruMau(1);
            Fire(1, prefFire);
            Destroy(collision.gameObject);
        }
        //if (collision.gameObject.tag == "BulletPlayer")
        //{
        //    Observer.Instance.Notify(TOPICNAME.ENEMYDESTROY);
        //    Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        //    Destroy(gameObject);
        //}

        //if (collision.gameObject.tag == "item")
        //{
        //    jin.gameObject.SetActive(true);
        //}
    }
    public void Fire(int dameff, GameObject Fire)
    {
        Instantiate(Fire, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
public class Player : SingletonMonoBehaviour<PlayerController>
{

}

