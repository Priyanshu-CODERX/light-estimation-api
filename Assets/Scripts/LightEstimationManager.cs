using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class LightEstimationManager : MonoBehaviour
{
    public ARCameraManager cameraManager;

    [SerializeField] TMP_Text BrightnessValue;
    [SerializeField] TMP_Text ColorCorrectionValue;
    [SerializeField] TMP_Text TemperatureValue;
    [SerializeField] TMP_Text DirectionalLightIntensity;

    public Light MainLight;

    private void Awake()
    {
        MainLight = GetComponent<Light>();
    }

    private void OnEnable() => cameraManager.frameReceived += FrameUpdated;
    private void OnDisable() => cameraManager.frameReceived += FrameUpdated;

    private void Update()
    {
        DirectionalLightIntensity.text = $"Directional Light: {MainLight.intensity.ToString()}";
    }

    private void FrameUpdated(ARCameraFrameEventArgs cameraArgs)
    {
        if(cameraArgs.lightEstimation.averageBrightness.HasValue)
        {
            BrightnessValue.text = $"Brightness: {cameraArgs.lightEstimation.averageBrightness.Value}";
            MainLight.intensity = cameraArgs.lightEstimation.averageBrightness.Value;
        }

        if(cameraArgs.lightEstimation.averageColorTemperature.HasValue)
        {
            TemperatureValue.text = $"Temperature: {cameraArgs.lightEstimation.averageColorTemperature.Value}";
            MainLight.colorTemperature = cameraArgs.lightEstimation.averageColorTemperature.Value;
        }

        if (cameraArgs.lightEstimation.colorCorrection.HasValue)
        {
            TemperatureValue.text = $"Color Correction: {cameraArgs.lightEstimation.colorCorrection.Value}";
            MainLight.color = cameraArgs.lightEstimation.colorCorrection.Value;
        }
    }
}
