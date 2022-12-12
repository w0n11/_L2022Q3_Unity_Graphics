using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] 
public class PostEffects_Class : MonoBehaviour
{
    Material myMaterial;
    Shader myShader ;
    // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/GrayScale_Class");
        myMaterial = new Material(myShader);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }
}
