using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public Renderer meshRenderer;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = meshRenderer.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        meshRenderer.material.mainTextureOffset = offset;
    }
}
