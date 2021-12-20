using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    public Slider HP;
    SpriteRenderer spriterender;
    public int HPPlayer;
    public static HPController instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        HP.maxValue = HPPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        HP.value = HPPlayer;
    }
    public void TruMau(int dame)
    {
        HPPlayer -= dame;
    }

}
