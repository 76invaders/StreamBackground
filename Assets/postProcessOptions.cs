using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
public class postProcessOptions : MonoBehaviour
{
    private PostProcessVolume _postProcessVolume;
    private ColorGrading _postGrading;
    public Slider _sliderValue;
    private void Start()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _postGrading);

    }

    private void Update()
    {
        _postGrading.hueShift.value = _sliderValue.value;
    }
}
