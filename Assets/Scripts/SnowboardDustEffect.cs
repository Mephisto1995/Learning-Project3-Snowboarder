using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowboardDustEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            particleSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            particleSystem.Stop();
        }
    }
}
