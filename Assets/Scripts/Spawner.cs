using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;

    public float minHeight = -1f;

    public float maxHeight = 1f;

    public float Topsize;


    private void OnEnable()
    {
        // spawnRate �������� Spawn �Լ��� �ֱ������� ȣ���մϴ�.
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        // InvokeRepeating�� ����Ͽ� Spawn �Լ� ȣ���� �����մϴ�.
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        // prefab�� �����Ͽ� ������ ������Ʈ�� �����մϴ�.
        GameObject pipe = Instantiate(prefab, transform.position, Quaternion.identity);

        // ������ ������ ������Ʈ�� ���η� ������ ��ġ�� �̵���ŵ�ϴ�.
        pipe.transform.position += Vector3.left * Random.Range(minHeight, maxHeight);
    }
}
