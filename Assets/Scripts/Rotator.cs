using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float _speed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, _speed * Time.deltaTime);
    }

    public void updateSpeed()
    {
        this._speed += 7;
    }
}
