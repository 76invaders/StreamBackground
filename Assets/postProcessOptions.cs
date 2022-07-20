using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class postProcessOptions : MonoBehaviour
{
    private PostProcessVolume _postProcessVolume;
    private ColorGrading _postGrading;
    public float Value = 0f;
    private void Start()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _postGrading);

    }

    private void Update()
    {
        _postGrading.hueShift.value = Value;
    }
}
