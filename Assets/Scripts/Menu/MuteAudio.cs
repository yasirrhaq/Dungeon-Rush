using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    public Image audioImage;
    public Sprite enableAudio;
    public Sprite muteAudio;

    private void Start()
    {
        if (AudioListener.volume > 0f)
        {
            audioImage.sprite = enableAudio;
        }
        else
        {
            audioImage.sprite = muteAudio;
        }
    }

    public void MuteAudioButton()
    {
        if (AudioListener.volume > 0f)
        {
            audioImage.sprite = muteAudio;
            AudioListener.volume = 0f;
        }
        else
        {
            audioImage.sprite = enableAudio;
            AudioListener.volume = 1f;
        }
    }
}
