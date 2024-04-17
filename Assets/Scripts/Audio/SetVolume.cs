using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

namespace TTT
{
    public class SetVolume : MonoBehaviour
    {
        public AudioMixer mixer;
        public Slider sld;

        private int volVal;
        private float volValCalc;


        public void setVol(float sliderVal)
        {
            mixer.SetFloat("SFX", Mathf.Log10(sliderVal) * 20);
        }

        private void Update()
        {
            volValCalc = sld.value * 100;
            volVal = (int)volValCalc;
        }
    }
}
