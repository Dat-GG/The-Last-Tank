using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class HPController : MonoBehaviour
{
    public Slider HP;
    SpriteRenderer spriterender;
    private int HPPlayer = 1000;
    public int HPEnemy;
    void Start()
    {
        HP.maxValue = HPPlayer;
    }
    void Update()
    {
        HP.value = HPPlayer;
    }
    public void TruMau(int dame)
    {
        HPPlayer -= dame;
    }
    public void TruMauEnemy(int damage) // có thể sẽ xóa
    {
        HPEnemy -= damage;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "HPItem")
        {
            HPPlayer += 100;
            Destroy(collision.gameObject);
            if (HPPlayer >= 1000)
            {
                HPPlayer = 1000;
            }
        }

        if(collision.gameObject.tag == "PoisonTrap")
        {
            HPPlayer -= 100;
            Destroy(collision.gameObject);
        }
    }
}
public class HP : SingletonMonoBehaviour<HPController>
{

}
