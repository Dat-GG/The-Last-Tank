using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : TankController
{
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        Move(direction);

        Vector3 gundirection = new Vector3(
            Input.mousePosition.x - Screen.width / 2,
            Input.mousePosition.y - Screen.height / 2);
        RotateGun(gundirection);

        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }
    public void MoveUp()
    {
        var direction = new Vector3(0, i, 0);
        Move(direction);
    }
    public void MoveDown()
    {
        var direction = new Vector3(0, -i, 0);
        Move(direction);
    }
    public void MoveLeft()
    {
        var direction = new Vector3(-i, 0, 0);
        Move(direction);
    }
    public void MoveRight()
    {
        var direction = new Vector3(i, 0, 0);
        Move(direction);
    }
}
public class Player : SingletonMonoBehaviour<PlayerController>
{

}

