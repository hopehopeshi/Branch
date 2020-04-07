using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonMusic : MonoBehaviour
{

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントを取得
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //左
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            audioSource.PlayOneShot(sound1);
        }

        //右
        if (Input.GetKey(KeyCode.RightArrow))
        {
            audioSource.PlayOneShot(sound2);
        }

        //上
        if (Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.PlayOneShot(sound3);
        }
    }
}
