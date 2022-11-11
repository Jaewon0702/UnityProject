using System.Collections; //python의 import == using
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GetComponent<AudioSource>().Play(); // 점프할 때마다 소리 출력
            rb.velocity = Vector2.up * jumpPower; //(0,1)*3, Vector3면 3차원(x,y,z), 3만큼 힘을 받아서 점프
   
        }
    }

    private void OnCollisionEnter2D(Collision2D other) { //물체가 서로 부딪혔을 때 {}안의 내용을 실행
        if(Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene"); // 새가 물체에 부딪혀서 GameOverScene으로 전환
    }
}
