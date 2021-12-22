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

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, NewEnemy);
    }
    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(TOPICNAME.ENEMYDESTROY, NewEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scorenumber.ToString();
        Lv.text = "Level: " + Lvnumber.ToString();
    }
    public void NewEnemy(object data)
    {
        Instantiate(enemy, Location.transform.position, Location.transform.rotation);
    }   
}
