using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Move : MonoBehaviour
{
    public Renderer meshRenderer;
    public float speed=0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Vector2 offset = meshRenderer.material.mainTextureOffset;
     //  offset=offset+new Vector2(0, speed*Time.deltaTime);
      // meshRenderer.material.mainTextureOffset=offset;
       meshRenderer.material.mainTextureOffset +=new Vector2(0, speed*Time.deltaTime);

    }
}
