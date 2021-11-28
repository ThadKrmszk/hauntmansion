using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public static int puzzleCount;
    // Start is called before the first frame update
    void Start()
    {
        if (puzzleCount == 35)
        {
            MapOpen.haveAMap = true;
            Debug.Log("U got map");
            GameObjective.isGetAMap = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("count"+puzzleCount);
    }
}
