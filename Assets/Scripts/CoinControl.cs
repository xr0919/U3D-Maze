using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��collider���津������ѡ ʹ�䴩����ң�����ʱ��������
        transform.Rotate(Vector3.left*90*Time.deltaTime);//90*Time.deltaTime ÿ��ת90

    }
    //�������ʱ��������
    public void OnTriggerEnter(Collider other)//other������
    {
        if(other.tag == "Player")
        {
            AudioManager.instance.PlayCoin();

            Destroy(this.gameObject);

        }
    }
}
