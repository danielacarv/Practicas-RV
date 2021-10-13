using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public Texture[] texture;
    public int currentTexture;

    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touches[0].phase == TouchPhase.Began)
        {
            currentTexture++;
            currentTexture %= texture.Length;
            gameObject.GetComponent<Renderer>().material.mainTexture = texture[currentTexture];
        }
    }
}
