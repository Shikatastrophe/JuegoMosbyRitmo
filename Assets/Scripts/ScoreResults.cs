using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreResults : MonoBehaviour
{

    public AudioSource audioSource;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            animator.SetBool("isFinished", true);
        }
              
    }
}
