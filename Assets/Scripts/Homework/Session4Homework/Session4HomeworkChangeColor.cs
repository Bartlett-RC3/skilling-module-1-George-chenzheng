using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkChangeColor : MonoBehaviour
{

    private MeshRenderer meshRender;
    IEnumerator cubeColorChangingCoroutine;

    void Start()
    {
        meshRender = this.GetComponent<MeshRenderer>();
        cubeColorChangingCoroutine = changeCubeColor();
        StartCoroutine(cubeColorChangingCoroutine);
    }

    private void Update()
    {
        Debug.Log(Time.time);
    }
    private IEnumerator changeCubeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            meshRender.material.color = new Color(Random.value, Random.value, Random.value);

            yield return StartCoroutine(cubeColorChangingCoroutine);
 
        }

    }
}
