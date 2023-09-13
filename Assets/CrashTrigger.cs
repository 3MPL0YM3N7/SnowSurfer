using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashTrigger : MonoBehaviour
{
    [SerializeField] AudioClip crashSound;

    void reloadScene0()
    {
        SceneManager.LoadScene(0);
    }

    [SerializeField] float reloadSceneDelay = 0.3f;
    [SerializeField] ParticleSystem particleEffect;

    bool isCrashed = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Surface" && isCrashed == false)
        {
            isCrashed = true;
            FindObjectOfType<PlayerRotate>().playerCrashed();
            FindObjectOfType<PlayerBoost>().playerCrashed();

            Debug.Log("Headache!");
            Invoke("reloadScene0", reloadSceneDelay);
            particleEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
        }
    }
}
