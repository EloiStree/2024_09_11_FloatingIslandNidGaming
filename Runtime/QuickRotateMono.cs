using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickRotateMono : MonoBehaviour
{

    public Transform m_whatToRotate;
    public float m_speed=90;
    public Vector3 m_axis = Vector3.up;
    public Space Space = Space.Self;


    private void Reset()
    {
        m_whatToRotate = transform;
    }
    void Update()
    {
        
        m_whatToRotate.Rotate(m_axis, m_speed * Time.deltaTime, Space);
    }
}
