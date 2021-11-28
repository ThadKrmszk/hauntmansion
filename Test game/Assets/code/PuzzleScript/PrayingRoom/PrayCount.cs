using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayCount : MonoBehaviour
{
    public static int prayCount;
    // Start is called before the first frame update
    void Start()
    {
        if (prayCount == 1)
        {
            MapOpen.haveAMap = true;
            Debug.Log("U got map");
            GameObjective.isFindABuddha = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("count"+prayCount);
    }
}
