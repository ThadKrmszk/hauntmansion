using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Effects : MonoBehaviour
{
    private static Effects _i;
    public static Effects i {
       get {
            if (_i == null) _i = Instantiate(Resources.Load<Effects>("soundEffect"));
            return _i;
        }
       
    }


    public SoundAudioClip[] soundAudioClipsArray;
    //playersound
   /* public  AudioClip playerWalk;
    public  AudioClip playerHit;
    public  AudioClip playerDead;
    public  AudioClip playerOpenmap;
    
    //ghostsound
    public AudioClip ghostWalk;
    public AudioClip ghostHit;
    public AudioClip ghostDc;*/
    
    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManagers.Sound sound;
        public AudioClip audioClip;
    }
    
   
}
