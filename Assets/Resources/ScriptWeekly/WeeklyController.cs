using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
using LTAUnityBase.Base.UI;

public class WeeklyController : MonoBehaviour
{
    [SerializeField] ButtonController BtnBuy;
    [SerializeField] ButtonController BtnBuy2;
    [SerializeField] ButtonController BtnBuy3;
    [SerializeField] ButtonController BtnBuy4;
    void Start()
    {
        BtnBuy.OnClick((ButtonController btn) =>
        {
            Debug.LogError("Mua 1");
        });
        BtnBuy2.OnClick((ButtonController btn) =>
        {
            Debug.LogWarning("Mua 2");
        });
        BtnBuy3.OnClick((ButtonController btn) =>
        {
            Debug.LogError("Mua 3");
        });
        BtnBuy4.OnClick((ButtonController btn) =>
        {
            Debug.LogError("Mua 4");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
