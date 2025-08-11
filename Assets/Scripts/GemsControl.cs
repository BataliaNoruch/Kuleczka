using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GemsControl : MonoBehaviour
{
    public GameObject playerGameObject;

    public MeatballPlayerControl playerControl;

    public AudioSource audioSource;
    public AudioClip clip;

    public MeshRenderer meshRenderer;
    public SphereCollider sphereCollider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("SOS");

            playerControl.liczbaPunktow++;

            audioSource.PlayOneShot(clip);

            meshRenderer.enabled = false;
            sphereCollider.enabled = false;

            //Destroy(gameObject);
        }
    

    }
}
