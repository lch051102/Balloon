using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int point = 0;  
    public float moveSpeed = 5f; // ������Ʈ �̵� �ӵ�

    private bool isMoving = false;

    void Update()
    {
        // ��ũ�� �߾��� �������� ���ʰ� �������� ������ ��ġ �Ǵ� Ŭ���� �����մϴ�.
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� Ŭ������ ��
        {
            isMoving = true; // �̵� ����
        }
        

        if (isMoving == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // ��ũ�� �߾��� �������� �������� ���������� Ȯ���մϴ�.
            if (mousePos.x < 0)
            {
                // ������ ��ġ�ϸ� �������� �̵��մϴ�.
                MoveLeft();
            }
            else
            {
                // �������� ��ġ�ϸ� ���������� �̵��մϴ�.
                MoveRight();
            }
        }
    }

    // �������� �̵��ϴ� �Լ�
    void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // ���������� �̵��ϴ� �Լ�
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
