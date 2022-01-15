using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class GunController : MonoBehaviour
{
    public Transform TranShoot;
    public GameObject[] bullet;
    public float BulletLevel;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    public void shoot()
    {
            if (BulletLevel == 0)
            {
                Instantiate(bullet[0], TranShoot.transform.position, TranShoot.transform.rotation);
            }
            if (BulletLevel == 1)
            {
                Instantiate(bullet[1], TranShoot.transform.position, TranShoot.transform.rotation);
            }   
            if (BulletLevel == 2)
            {
                Instantiate(bullet[2], TranShoot.transform.position, TranShoot.transform.rotation);
            }
            if (BulletLevel == 3)
            {
                Instantiate(bullet[3], TranShoot.transform.position, TranShoot.transform.rotation);
            }
            if (BulletLevel == 4)
            {
                Instantiate(bullet[4], TranShoot.transform.position, TranShoot.transform.rotation);
            }
    }
}
public class Gun : SingletonMonoBehaviour<GunController>
{

}
