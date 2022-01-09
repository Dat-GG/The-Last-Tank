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
        // Debug.Log(currentTime);
        if(timeLimit == currentTime)
        {
            Destroy(this.gameObject);
            // Debug.Log("boom");
        }
    }
    IEnumerator CountDown()
    {
        while (true)
        {
            DestroyObject();
            // Debug.Log("alo");
            yield return new WaitForSeconds(1f);
        }
    }
}
