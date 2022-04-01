using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MuteAudio : MonoBehaviour
{

    public Toggle tog;

    void Awake()
    {
        tog = GetComponent<Toggle>();
        var toggle = GetComponent<UnityEngine.UI.Toggle>();
        if (Global.isMute) {
            tog.isOn = true;
        } else {
            tog.isOn = false;
        }          
    }

   public void GoToMenu() {
        SceneManager.LoadScene("StartScreen");
    }

   public void MuteToggle(bool mute) {
        if (mute) {
            AudioListener.volume = 0;
            Global.isMute = mute;
            print(Global.isMute);
        } else {
            //AudioListener.volume = 1;
            Global.isMute = mute;
            print(Global.isMute);
        }
        Global.isMute = mute;
    }


}
