using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerControl : MonoBehaviour
{
    private float power;
    public float POWERPLUS = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))// 왼쪽 버튼이 눌리면
        {
            power += POWERPLUS * Time.deltaTime;// 힘을 모은다. 기를 모으는것
        }
        if (Input.GetMouseButtonUp(0))//왼족 버튼을 떼면
        {
            this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(power, power, 0)); // 힘을 x 와 y 에 반영
            power = 0.0f;// 파워 초기화
        }
        if (this.transform.position.y < -5.0f)//지면보다 아래 -5.0f 까지 떨어지면 구명에 떨어진 순간
        {
            Application.LoadLevel("gameScene");//씬을 다시 로드 다시 시작의 개념
        }
    }
}
