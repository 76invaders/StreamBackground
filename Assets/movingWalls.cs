using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingWalls : MonoBehaviour
{
    public Transform _wallsPos;
    public int Speed;

    private float BreakPoint = 0.565f;

    // Update is called once per frame
    void Update()
    {
        if (_wallsPos.transform.position.y > BreakPoint || _wallsPos.transform.position.y < -BreakPoint)
        {
            _wallsPos.transform.position = new Vector3(0,0,0);
        }
        _wallsPos.transform.position += new Vector3(0f,Speed*0.0001f,0f);
    }
}
