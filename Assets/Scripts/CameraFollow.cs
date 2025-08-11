using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;

    public AudioSource audioMusic;
    public AudioClip clipMusic;

    //public EndgameControl endgameControl;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;

        /*if (endgameControl.audioSource.isPlaying)
        {
            endgameControl.audioSource.Play();
            audioMusic.Pause();
            
            
           
        }*/
        //else if (endgameControl.audioSource.isPlaying)
        //{
        //    audioMusic.Play();
        //}

    }
}
