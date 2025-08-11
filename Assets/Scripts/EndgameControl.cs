using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndgameControl : MonoBehaviour
{
    public Transform playerTransform;
    public MeatballPlayerControl playerControl;

    public TextMeshProUGUI endGameText;

    public AudioSource audioSource;
    public AudioClip clip;

    public CameraFollow cameraFollow;
    //public AudioSource audioMusic;
   // public AudioClip clipMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerControl.liczbaPunktow == 8)
            {
                endGameText.gameObject.SetActive(true);
                Debug.Log("KONIEC");

                //audioEnd.gameObject.SetActive(false);

                
                cameraFollow.audioMusic.mute = true;
                audioSource.PlayOneShot(clip);
                
               
                //cameraFollow.audioMusic.mute = false;
               
            }
        }
    }
}
