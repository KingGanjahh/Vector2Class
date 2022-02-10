using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    MyVector First;

    [SerializeField]
    MyVector Second;

    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;

    private void Start()
    {
    }

    private void Update()
    {
        First.DrawZero();
        Second.DrawZero();
        First.Lerp(First, Second, range).DrawZero();
    }
}
