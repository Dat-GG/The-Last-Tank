using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class ItemController : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int time;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HP.Instance.HPPlayer += a;
            if (HP.Instance.HPPlayer >= HP.Instance.HP.maxValue)
            {
                HP.Instance.HPPlayer = 1000;
            }

            Player.Instance.speed += b;

            HP.Instance.HPPlayer -= c;
            Destroy(gameObject);
        }
    }
}
public class item : SingletonMonoBehaviour<ItemController>
{

}
