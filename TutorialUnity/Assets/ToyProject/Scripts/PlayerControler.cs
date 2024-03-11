using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float playerSpeed = 2f;
    public Rigidbody playerRigid;

    public GameObject centerPointObject;

    // Start is called before the first frame update

    // 시작할때 한번만 실행
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // 계속 반복 (게임의 흐름)
    void Update()
    {
        var vartical = Input.GetAxis("Vertical");
        playerRigid.AddForce(centerPointObject.transform.forward * playerSpeed*vartical);
    }
}
