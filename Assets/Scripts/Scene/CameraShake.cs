using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private float magnitude;
    public AudioSource _mAudio;
    private GameObject player;

    public static CameraShake instance;
    public bool playerDead;

    void Start()
    {
        instance = this;
        StopAllCoroutines();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(player.transform.position);
        bool offPosition = screenToPoint.y < 0.25;
        if (offPosition && !playerDead)
        {
            StartCoroutine(Shake(duration, magnitude));
        }

        if (playerDead)
        {
            _mAudio.Stop();
        }
    }


    IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        
        _mAudio.Play();

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

}
