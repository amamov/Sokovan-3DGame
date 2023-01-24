using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody playerRigidBody;
    
    // 게임이 처음 시작되었을대 한 번
    void Start()
    {
        // playerRigidBody.AddForce(0, 1000, 0);
    }

    // 영화 : 초당 24프레임, 모바일 : 초당 30프레임, PC : 초당 60프레임, 콘솔게임 : 초당 30프레임
    // Update is called once per frame
    void Update()
    {
        // Debug.Log("화면이 한 번 깜빡임");
        // Input : 사용자 입력을 받을 수 있는 객체
        // .GetKey(KeyCode.W) : 키보드에서 W를 눌렀을때
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidBody.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRigidBody.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigidBody.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidBody.AddForce( 0, speed, 0);
        }
    }
}
