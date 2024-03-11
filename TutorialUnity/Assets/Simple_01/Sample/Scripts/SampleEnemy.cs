using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleEnemy : MonoBehaviour
{
    [SerializeField] private GameObject centerPoint;
    [SerializeField] private float enemyMoveSpeed;
    private Rigidbody rigidbody;
    private Vector3 targetDirection;

    public GameObject CenterPoint
    {
        get => centerPoint;
        set => centerPoint = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // 방향이 한번만 결정되고. Enemy 그 방향으로만 움직이기 때문에 (총알 피하기)
        //targetDirection = (playerObject.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy가 정중앙의 위치를 계속해서 이동하는 게임
        targetDirection = (centerPoint.transform.position - transform.position).normalized;

        // Acceleration : 지속적인 힘을 받고 무게적용x
        // Force : 지속적인 힘을 받고 무게에 적용o
        // Impuse : 순간적인 힘o 무게적용o
        // VelocityChange : 순간적인 힘o 무게적용 x
        rigidbody.AddForce(targetDirection * enemyMoveSpeed,ForceMode.Force);


    }
}