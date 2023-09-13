using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    // Audio
    AudioSource finishSound;

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    // Respawn
    void reloadScene0()
    {
        SceneManager.LoadScene(0);
    }

    [SerializeField] float reloadSceneDelay = 1f;
    [SerializeField] ParticleSystem particleEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You crossed the line, Simo.");
            Invoke("reloadScene0", reloadSceneDelay);
            particleEffect.Play();
            finishSound.Play();
        }
    }
}
