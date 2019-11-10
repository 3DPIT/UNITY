using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalControl : MonoBehaviour
{
    private bool is_collided = false;// 충돌했는지 안했는지 알려주는거 충돌시 true 이므로 초기화 false
    public float GOAL_MIN = 5.0f;
    public float GOAL_MAX = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        float rnd = Random.Range(GOAL_MIN, GOAL_MAX);//랜덤으로 x 위치 받아서
        this.transform.position = new Vector3(rnd,-1.0f, 0.0f);//x 축에 저장해서 실행
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionStay(Collision other)// 다른 게임 오브젝트와 충돌하는 동안 계속 호출하는 것
    {
        this.is_collided = true;

    }
    private void OnGUI()
    {
        if (is_collided)//        if (is_collided==true)와 같은 표현 참이면 들어가라라는 의미
        {
            GUI.Label(new Rect(Screen.width / 2, 80, 100, 20), "성공");
        }
    }
}
