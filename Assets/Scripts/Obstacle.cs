using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;

    public float TopEdge;

    private void Start()
    {
        // ���� ������Ʈ�� ��ġ�� ī�޶� ���� ��ǥ�� ��ȯ�� ��, y ��ǥ���� 1�� �� ���� leftEdge ������ �����մϴ�.
        TopEdge = Camera.main.ScreenToWorldPoint(transform.position).y - 1f;
        Debug.Log(TopEdge);
    }
    private void Update()
    {
        // ���� ���� ������Ʈ�� ��ġ�� ���� �ӵ�(speed)�� �ð�(Time.deltaTime)�� ���� ����ŭ �Ʒ������� �̵���ŵ�ϴ�.
        transform.position -= Vector3.up * speed * Time.deltaTime;
        // ���� ������Ʈ�� y ��ǥ�� TopEdge �������� ���� ��� (ȭ�� ���� ��踦 �Ѿ ���) �ش� ���� ������Ʈ�� �ı��մϴ�.
        if (transform.position.y < TopEdge)
        {
            Destroy(gameObject);

        }
    }
}
