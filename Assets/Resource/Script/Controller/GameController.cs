using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text score;
    public int scorenumber;
    public GameObject Location;
    public GameObject enemy;
    public Text Lv;
    public int Lvnumber;
    public GameObject Boss;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, NewEnemy);
    }
    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(TOPICNAME.ENEMYDESTROY, NewEnemy);
    }
    void Update()
    {
        score.text = "Score: " + scorenumber.ToString();
        Lv.text = "Level: " + Lvnumber.ToString();

        if (Lvnumber == 0)
        {
            Gun.Instance.BulletLevel = 0;
        }
        if (Lvnumber == 1)
        {
            Gun.Instance.BulletLevel = 1;
        }
        if (Lvnumber == 2)
        {
            Gun.Instance.BulletLevel = 2;
        }
        if (Lvnumber == 3)
        {
            Gun.Instance.BulletLevel = 3;
        }
        if (Lvnumber == 4)
        {
            Gun.Instance.BulletLevel = 4;
            Location.SetActive(false);
            Boss.SetActive(true);
        }
    }
    public void NewEnemy(object data)
    {
        Instantiate(enemy, Location.transform.position, Location.transform.rotation);
    }   
}
