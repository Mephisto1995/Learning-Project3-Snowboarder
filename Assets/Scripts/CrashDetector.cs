using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float sceneDelay = 1f;
    [SerializeField] private ParticleSystem deathEffect;
    [SerializeField] private AudioClip crashSFX;

    private bool mHasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground" && !mHasCrashed)
        {
            mHasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControl();
            deathEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", sceneDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
