using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //��ײЧ��
    public GameObject HitPre;
    //��ըЧ��
    public GameObject BombPre;
    //Ѫ��
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
        //ˮƽ��
        float horizontal = Input.GetAxis("Horizontal"); //����-1 - 1 Ĭ��0
        //��ֱ��
        float vertical = Input.GetAxis("Vertical");
        //����
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if(dir != Vector3.zero)
        {
            //�ƶ�
            rBody.velocity = dir *2;
        }

    }
    //ֻҪ������ײ��ͻ����
    public void OnCollisionEnter(Collision collision)//Collision��������ײ������
    {
        if(collision.collider.tag == "Wall")
        {
            hp--;
            if(hp < 0)
            {
                AudioManager.instance.PlayBomb();

                //ʵ��Ԥ����
                Instantiate(BombPre, transform.position, Quaternion.identity);//ʵ����һ��Ԥ���壬�ڷŵ�λ�ã�����ת
                Destroy(gameObject);
            }
            else
            {
                Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);//collision.contacts[0].point�������Ǹ����λ��
            }
        }
    }
}
