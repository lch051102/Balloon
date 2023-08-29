using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;

    public float TopEdge;

    private void Start()
    {
        // 현재 오브젝트의 위치를 카메라 월드 좌표로 변환한 후, y 좌표에서 1을 뺀 값을 leftEdge 변수에 저장합니다.
        TopEdge = Camera.main.ScreenToWorldPoint(transform.position).y - 1f;
        Debug.Log(TopEdge);
    }
    private void Update()
    {
        // 현재 게임 오브젝트의 위치를 현재 속도(speed)와 시간(Time.deltaTime)을 곱한 값만큼 아래쪽으로 이동시킵니다.
        transform.position -= Vector3.up * speed * Time.deltaTime;
        // 게임 오브젝트의 y 좌표가 TopEdge 변수보다 작을 경우 (화면 왼쪽 경계를 넘어갈 경우) 해당 게임 오브젝트를 파괴합니다.
        if (transform.position.y < TopEdge)
        {
            Destroy(gameObject);

        }
    }
}
