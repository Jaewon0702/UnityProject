using System.Collections; //python의 import == using
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower; //public을 이용하면 unity에서 변수에 입력 가능!

    // Start is called before the first frame update, 코드가 동작할 때 딱 한 번만 실행
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 게임에서 매 프레임마다 실행
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; //(0,1)*3, Vector3면 3차원(x,y,z), 3만큼 힘을 받아서 점프
   
        }
    }
}
