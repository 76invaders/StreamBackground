using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : MonoBehaviour
{
    public Transform _floorPos;
    public movingWalls wallsSpeed;
    public int Speed;
    private float BreakPoint = 0.565f;
    public bool SinhronizeWalls;

    // Update is called once per frame
    void Update()
    {
        if (SinhronizeWalls is true)
        {
            Speed = wallsSpeed.Speed;
        }

        if (_floorPos.transform.position.z > BreakPoint || _floorPos.transform.position.z < -BreakPoint)
        {
            _floorPos.transform.position = new Vector3(-0.5f,0,0);
        }
        _floorPos.transform.position += new Vector3(0f,0f,Speed*0.0001f);
    }
}
