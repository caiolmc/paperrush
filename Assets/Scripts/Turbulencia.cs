using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbulencia : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    private CinemachineBasicMultiChannelPerlin noise;

    public NoiseSettings sixDShake;

    private void Awake()
    {
        vcam = FindObjectOfType<CinemachineVirtualCamera>();
        noise = vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    private void OnTriggerEnter(Collider other)
    {
        noise.m_NoiseProfile = sixDShake;
    }

}
