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
        // spawnRate 간격으로 Spawn 함수를 주기적으로 호출합니다.
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        // InvokeRepeating을 취소하여 Spawn 함수 호출을 중지합니다.
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        // prefab을 복제하여 파이프 오브젝트를 생성합니다.
        GameObject pipe = Instantiate(prefab, transform.position, Quaternion.identity);

        // 생성된 파이프 오브젝트를 세로로 랜덤한 위치로 이동시킵니다.
        pipe.transform.position += Vector3.left * Random.Range(minHeight, maxHeight);
    }
}
