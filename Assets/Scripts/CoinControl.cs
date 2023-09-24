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
        //把collider里面触发器勾选 使其穿过金币，碰到时触发方法
        transform.Rotate(Vector3.left*90*Time.deltaTime);//90*Time.deltaTime 每秒转90

    }
    //金币碰到时触发方法
    public void OnTriggerEnter(Collider other)//other就是球
    {
        if(other.tag == "Player")
        {
            AudioManager.instance.PlayCoin();

            Destroy(this.gameObject);

        }
    }
}
