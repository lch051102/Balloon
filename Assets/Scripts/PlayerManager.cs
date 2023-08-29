using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int point = 0;  
    public float moveSpeed = 5f; // 오브젝트 이동 속도

    private bool isMoving = false;

    void Update()
    {
        // 스크린 중앙을 기준으로 왼쪽과 오른쪽을 나누어 터치 또는 클릭을 감지합니다.
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 클릭했을 때
        {
            isMoving = true; // 이동 시작
        }
        

        if (isMoving == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 스크린 중앙을 기준으로 왼쪽인지 오른쪽인지 확인합니다.
            if (mousePos.x < 0)
            {
                // 왼쪽을 터치하면 왼쪽으로 이동합니다.
                MoveLeft();
            }
            else
            {
                // 오른쪽을 터치하면 오른쪽으로 이동합니다.
                MoveRight();
            }
        }
    }

    // 왼쪽으로 이동하는 함수
    void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // 오른쪽으로 이동하는 함수
    void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Point")
        {
            point += 1;
            Debug.Log("point");
        }
    }
}
