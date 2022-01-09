using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    //public int time = 0;
    public GameObject[] gate;
    public GameObject[] item;

    void Start()
    {
        StartCoroutine(spawnItem());
    }
    void Update()
    {

    }

    IEnumerator spawnItem()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, gate.Length);
            int randomIndex1 = Random.Range(0, item.Length);
            GameObject instantiatedObject = Instantiate(item[randomIndex1], gate[randomIndex].transform.position, Quaternion.identity) as GameObject;
            yield return new WaitForSeconds(5f);
        }
    }
}
