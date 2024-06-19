using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VooTranquilo : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    private CinemachineBasicMultiChannelPerlin noise;


    public NoiseSettings normalExtreme;

    private void Awake()
    {
        vcam = FindObjectOfType<CinemachineVirtualCamera>();
        noise = vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    private void OnTriggerEnter(Collider other)
    {
        noise.m_NoiseProfile = normalExtreme;
    }

}
