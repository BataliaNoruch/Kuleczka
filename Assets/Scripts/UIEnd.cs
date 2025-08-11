using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEnd : MonoBehaviour
{
    public MeatballPlayerControl playerControl;
    public UIManager uiManager;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (playerControl.liczbaPunktow == 6)
      {
       gameObject.SetActive(true);
            
      }

        if (playerControl.liczbaPunktow != 6)
        {
         gameObject.SetActive(false);
        }

    }
}
