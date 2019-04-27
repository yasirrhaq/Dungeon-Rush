using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private float magnitude;
    public AudioSource _mAudio;
    private GameObject player;

    void Start()
    {
        StopAllCoroutines();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(player.transform.position);
        bool offPosition = screenToPoint.y < 0.4;
        if (offPosition)
        {
            StartCoroutine(Shake(duration, magnitude));
        }
    }


    IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;

        PlayAudio();

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }

    void PlayAudio()
    {
        if (GetComponent<AudioSource>())
        {
            _mAudio = GetComponent<AudioSource>();
            _mAudio.Play();
        }
    }
}
