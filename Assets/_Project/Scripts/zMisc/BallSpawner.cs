using System.Collections;
using System.Collections.Generic;
using _Project.SOs;
using UnityEngine;
using UnityEngine.UIElements;

public class BallSpawner : MonoBehaviour
{
    public void SpawnBallAtClick(ClickSO click)
    {
        var newBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // Transform stuff
        var newBallT = newBall.transform;
        newBallT.localScale = Vector3.one * 0.03f;
        newBallT.position = click.clickPosition;
        newBallT.rotation = click.clickRotation;
        StartCoroutine(GrowTransformOverTime(newBallT, 0.1f, 0.01f, 5f));
        // Color stuff
        var renderer = newBall.GetComponent<Renderer>();
        renderer.material.color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1f);
        // Rigidbody stuff
        var rb = newBall.AddComponent<Rigidbody>();
        rb.AddForce(newBallT.forward * 30, ForceMode.Impulse);
    }
    
    IEnumerator GrowTransformOverTime(Transform transformToGrow, float scaleAdditiveOnIntervals, float interval, float time)
    {
        for (float i = 0; i < time; i+= interval)
        {
            transformToGrow.localScale += (Vector3.one * scaleAdditiveOnIntervals);
            yield return new WaitForSeconds(interval);
        }
    }
}
