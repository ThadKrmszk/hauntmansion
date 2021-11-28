using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpen : MonoBehaviour
{
    [SerializeField] public GameObject map;
    private bool isMap;
    public static bool haveAMap;
    // Start is called before the first frame update
    void Start()
    {
        haveAMap = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (haveAMap == false)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Debug.Log("i dont have a map");
            }
        }
        if (haveAMap)
        {
             if (Input.GetKeyDown(KeyCode.M))
                
                   {
                       SoundManagers.Playsound(SoundManagers.Sound.PlayerOpenMap);
                       isMap = !isMap;

                       if (isMap)

                           map.SetActive(true);


                       else
                           
                           map.SetActive(false); 
                       SoundManagers.Playsound(SoundManagers.Sound.PlayerCloseMap);
                   } 
        }
        //Open map
      
    }

   
}
