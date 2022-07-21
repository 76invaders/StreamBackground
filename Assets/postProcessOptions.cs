using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
public class postProcessOptions : MonoBehaviour
{
    //Control panel//-------------------------------
    public Slider sliderHueValue, sliderLensValue;
    public Toggle gradientSwitch,bloomSwitch,neonSwitch,blurSwitch;
    //----------------------------------------------

    //Initialize avalible options//-----------------
    private PostProcessVolume _postProcessVolume; //main.option
    private Bloom _bloom; //option
    private AutoExposure _autoExposure; //option
    private ChromaticAberration _chromaticAberration; //option
    private ColorGrading _postGrading; //option
    private LensDistortion _lensDistortion; //option
    private Vignette _vignette; //option
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
        _postGrading.hueShift.value = sliderHueValue.value;
        _lensDistortion.intensity.value = sliderLensValue.value;
        _vignette.active = gradientSwitch.isOn;
        //-------------------------------------------------------
    }
}
