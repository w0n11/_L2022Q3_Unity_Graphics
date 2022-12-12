using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class PostEffects_Depth_Class : MonoBehaviour
{
    Shader myShader;
    Material myMaterial;


    private void Start()
    {
        myShader = Shader.Find("My/PostEffects/Depth_Class");
        myMaterial = new Material(myShader);
    }

    

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
    
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable(){
        if (myMaterial) 
        {
            DestroyImmediate(myMaterial);
        }
    }
}
