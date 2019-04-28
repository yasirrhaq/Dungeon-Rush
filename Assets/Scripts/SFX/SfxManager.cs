using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public static AudioClip coinsound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        coinsound = Resources.Load<AudioClip>("coin");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string sfx)
    {
        switch (sfx)
        {
            case "coin":
                audioSrc.PlayOneShot(coinsound);
                break;
                    
        }
    }
}
