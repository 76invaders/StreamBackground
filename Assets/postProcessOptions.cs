using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
using System;
public class postProcessOptions : MonoBehaviour
{
    //Control panel//-------------------------------
    public Slider sliderHueValue, sliderLensValue, movingWalls,rotationValue,vievValue,rainbowValue;
    public Toggle gradientSwitch,bloomSwitch,neonSwitch,blurSwitch, floorSwitch, shakoretkaSwitch;
    //----------------------------------------------

    //Initialize avalible options//-----------------
    private PostProcessVolume _postProcessVolume; //main.option
    private Bloom _bloom; //option
    private AutoExposure _autoExposure; //option
    private ChromaticAberration _chromaticAberration; //option
    private ColorGrading _postGrading, _shakoretka; //option
    private LensDistortion _lensDistortion; //option
    private Vignette _vignette; //option
    private float rainbow; //option
    //------------------------------------------------

    private void Start()
    {
        //Load avalible options//--------------------------------------
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _bloom);
        _postProcessVolume.profile.TryGetSettings(out _autoExposure);
        _postProcessVolume.profile.TryGetSettings(out _chromaticAberration);
        _postProcessVolume.profile.TryGetSettings(out _postGrading);
        _postProcessVolume.profile.TryGetSettings(out _lensDistortion);
        _postProcessVolume.profile.TryGetSettings(out _vignette);
        //--------------------------------------------------------------
    }

    private void Update()
    {
        //Control from interface---------------------------------
        _bloom.active = bloomSwitch.isOn;
        _autoExposure.active = neonSwitch.isOn;
        _chromaticAberration.active = blurSwitch.isOn;
        sliderHueValue.value = sliderHueValue.value + rainbowValue.value;
        if (sliderHueValue.value + rainbowValue.value > 180f)
            {
                sliderHueValue.value = -180;
            }
        if (sliderHueValue.value + rainbowValue.value < -180f)
            {
                sliderHueValue.value = 180;
            }
        _postGrading.hueShift.value = sliderHueValue.value;
        _lensDistortion.intensity.value = sliderLensValue.value;
        _vignette.active = gradientSwitch.isOn;
        if(shakoretkaSwitch.isOn)
            {
                _postGrading.saturation.value = -100f;
            }
            else
            {
                _postGrading.saturation.value = 100f;
            }
        //-------------------------------------------------------
    }

    public void RandomOptions()
    {
        bloomSwitch.isOn = Convert.ToBoolean(UnityEngine.Random.Range(0,2));
        neonSwitch.isOn = Convert.ToBoolean(UnityEngine.Random.Range(0,2));
        blurSwitch.isOn = Convert.ToBoolean(UnityEngine.Random.Range(0,2));
        sliderHueValue.value = UnityEngine.Random.Range(-180,181);
        sliderLensValue.value = UnityEngine.Random.Range(-100,1);
        gradientSwitch.isOn = Convert.ToBoolean(UnityEngine.Random.Range(0,2));
        movingWalls.value = UnityEngine.Random.Range(-25.0f,25.1f);
        floorSwitch.isOn = Convert.ToBoolean(UnityEngine.Random.Range(0,2));
        rotationValue.value = UnityEngine.Random.Range(0f,361f);
        vievValue.value = UnityEngine.Random.Range(40f,91f);
        rainbowValue.value = UnityEngine.Random.Range(-0.5f,0.5f);
    }
}
