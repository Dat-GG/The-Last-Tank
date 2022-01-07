using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject TranShoot;
    public GameObject[] bullet;
    public float BulletLevel;
    Transform player;
    public static GunController instance;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        BulletLevel = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    public void shoot()
    {
            if (BulletLevel == 1)
            {
                Instantiate(bullet[0], TranShoot.transform.position, TranShoot.transform.rotation);
            }
            if (BulletLevel == 3)
            {
                Instantiate(bullet[1], TranShoot.transform.position, TranShoot.transform.rotation);
            }        
    }
}
