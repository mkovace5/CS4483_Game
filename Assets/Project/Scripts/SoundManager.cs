using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider vslider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() {
        if (!Global.isMute) {
            vslider.value = Global.userVolume;
        }
    }

    // Update is called once per frame
    void Update() {
        //print("Testing");
        if (!Global.isMute) {
            AudioListener.volume = vslider.value;
            Global.userVolume = AudioListener.volume;
        }
        
    }

    public void ChangeVolume() {
        print("Testing");
        AudioListener.volume = vslider.value;
    }
}
