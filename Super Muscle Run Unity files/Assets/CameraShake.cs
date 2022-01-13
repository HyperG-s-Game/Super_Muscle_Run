using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{

    public CinemachineVirtualCamera cineVirtual;

    private void Start()
    {
        cineVirtual = GetComponent<CinemachineVirtualCamera>();
    }


    public void ShakeTheCamera()
    {
        cineVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 10f;
        cineVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 2f;
        StartCoroutine(WaitAndReset());
    }

    IEnumerator WaitAndReset()
    {
        yield return new WaitForSeconds(1f);
        cineVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0f;
        cineVirtual.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0f;
    }
}
