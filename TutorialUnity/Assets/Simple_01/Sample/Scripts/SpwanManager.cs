using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform enemySpwanPosition;
    // Start is called before the first frame update
    void Start()
    {
        // 한 개의 적만, 특정 위치에서 생성되는 코드 작성
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy()
    {
        GameObject enemyObj = Instantiate(enemy, enemySpwanPosition.position, Quaternion.identity);
        
    }
}
