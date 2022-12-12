using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects_Blend_Class : MonoBehaviour
{
    Shader myShader;
    Material myMaterial;
    public Texture2D BlendTex; //인스펙터에서 찾을 수 있게
    public float blendOpacity = 1.0f;
    
    private void Start()
    {
        myShader = Shader.Find("My/PostEffects/Blend_Class");
        myMaterial = new Material(myShader);
    }

     private void Update()
    {
        blendOpacity = Mathf.Clamp(blendOpacity, 0.0f, 1.0f);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial.SetTexture("_BlendTex", BlendTex);
        myMaterial.SetFloat("_Opacity", blendOpacity);
        Graphics.Blit(source, destination, myMaterial);
    }

}
