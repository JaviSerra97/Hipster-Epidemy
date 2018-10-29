using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public Transform personaje;

    private Vector3 posicionObjetivo;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float CameraSpeed;

    Transform t;

    void Start()
    {

        t = transform;

        posicionObjetivo = personaje.position;

    }

    public void Update()
    {

        t.position = new Vector3(
            Mathf.Lerp(t.position.x, ObtenerX(posicionObjetivo.x), .1f * CameraSpeed),
            Mathf.Lerp(t.position.y, ObtenerY(posicionObjetivo.y), .1f * CameraSpeed),
            -20f);

        posicionObjetivo = personaje.position;

    }

    float ObtenerX(float x)
    {

        return Mathf.Clamp(x, minX, maxX);

    }

    float ObtenerY(float y)
    {

        return Mathf.Clamp(y, minY, maxY);

    }

}