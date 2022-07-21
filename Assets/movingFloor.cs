using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingFloor : MonoBehaviour
{
    public Transform _floorPos;
    public Toggle floorSwitch;
    public movingWalls wallsSpeed;
    public Slider Speed;
    private float BreakPoint = 0.565f+0.022f;
    public bool SinhronizeWalls;
    public MeshRenderer MeshRenderer;

    // Update is called once per frame
    void Update()
    {
        if (SinhronizeWalls is true)
        {
            Speed = wallsSpeed.Speed;
        }

        if (_floorPos.transform.position.z > BreakPoint || _floorPos.transform.position.z < -BreakPoint)
        {
            _floorPos.transform.position = new Vector3(-0.5f,0,0.022f);
        }
        _floorPos.transform.position += new Vector3(0f,0f,Speed.value*0.0001f);

        FloorSwitcher();
    }

    public void FloorSwitcher()
    {
        MeshRenderer.enabled = floorSwitch.isOn;
    }
}
