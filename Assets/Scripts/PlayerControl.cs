using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //碰撞效果
    public GameObject HitPre;
    //爆炸效果
    public GameObject BombPre;
    //血量
    public int hp = 3;

    private Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //水平轴
        float horizontal = Input.GetAxis("Horizontal"); //返回-1 - 1 默认0
        //垂直轴
        float vertical = Input.GetAxis("Vertical");
        //方向
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if(dir != Vector3.zero)
        {
            //移动
            rBody.velocity = dir *2;
        }

    }
    //只要碰到碰撞体就会调用
    public void OnCollisionEnter(Collision collision)//Collision传过来碰撞的物体
    {
        if(collision.collider.tag == "Wall")
        {
            hp--;
            if(hp < 0)
            {
                AudioManager.instance.PlayBomb();

                //实例预设体
                Instantiate(BombPre, transform.position, Quaternion.identity);//实例哪一个预设体，摆放的位置，不旋转
                Destroy(gameObject);
            }
            else
            {
                Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);//collision.contacts[0].point碰到的那个点的位置
            }
        }
    }
}
