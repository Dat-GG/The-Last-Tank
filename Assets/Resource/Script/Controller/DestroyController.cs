using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    public int timeLimit;
    private int currentTime;
    
    void Start()
    {
        StartCoroutine(CountDown());
    }
    public void DestroyObject()
    {
        currentTime++;
        if(timeLimit == currentTime)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator CountDown()
    {
        while (true)
        {
            DestroyObject();
            yield return new WaitForSeconds(1f);
        }
    }
}
