using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlsButtons : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject evidenceCam;
    public GameObject holoCam;
    public GameObject standCam;

    private void Start()
    {
        StartCoroutine(startCamera());
    }

    public void onMainClick()
    {
        mainCam.SetActive(true);
        evidenceCam.SetActive(false);
        holoCam.SetActive(false);
        standCam.SetActive(false);
    }

    public void onEvidenceClick()
    {
        evidenceCam.SetActive(true);
        mainCam.SetActive(false);
        holoCam.SetActive(false);
        standCam.SetActive(false);
    }

    public void onHoloClick()
    {
        holoCam.SetActive(true);
        mainCam.SetActive(false);
        evidenceCam.SetActive(false);
        standCam.SetActive(false);
    }

    public void onStandClick()
    {
        standCam.SetActive(true);
        mainCam.SetActive(false);
        evidenceCam.SetActive(false);
        holoCam.SetActive(false);
    }

    private IEnumerator startCamera()
    {
        evidenceCam.SetActive(true);
        yield return new WaitForSeconds(1);
        onMainClick();
    }

}
