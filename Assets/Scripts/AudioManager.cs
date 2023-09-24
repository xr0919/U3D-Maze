using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource player;

    public AudioClip bomb;
    public AudioClip coin;

    // Start is called before the first frame update
    //awake更早调用 越快bug越少
    void Awake()
    {
        instance = this;
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBomb()
    {
        player.PlayOneShot(bomb);
    }
    public void PlayCoin()
    {
        player.PlayOneShot(coin);
    }
}
