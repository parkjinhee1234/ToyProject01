using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 플레이어의 방향 (정중앙)
    // 밖으로 떨어지면 안되는 게임 -> 정중앙의 위치를 고수하는 것.
    // 적의 행동을 만드는 알고리즘 AI 행동 패턴

    public GameObject centerPoint;
    public float enemyMoveSpeed;
    public Rigidbody rigidbody;

    private Vector3 targetDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // 방향이 한번만 결정되고 Enemy 그 방향으로만 움직이기 때문에 (총알 피하기)
        //targetDirection = (playerObject.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy
        // 처음 시작할때 플레이어 오브젝트 생성 위치로 계속 이동하도록 설정
        targetDirection = (centerPoint.transform.position - transform.position).normalized;
        rigidbody.AddForce(targetDirection * enemyMoveSpeed);
    }
}
