using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{
    public static AudioMaster instance;

    public AudioClip gameplayMusic;
    public AudioClip dieMusic;

    private AudioSource musicSource;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        musicSource = gameObject.GetComponent<AudioSource>();
        ChangeMusic(gameplayMusic);
    }

    public void ChangeMusic(AudioClip newMusicClip, bool loop = true)
    {
        musicSource.clip = newMusicClip;
        musicSource.loop = loop;
        musicSource.Play();
    }

    public void PlayDieMusic()
    {
        ChangeMusic(dieMusic, false);
    }
}
