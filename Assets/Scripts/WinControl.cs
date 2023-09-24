using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinControl : MonoBehaviour
{
    public TextMeshPro Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            Text.text = "Victory";
        }
    }
}
