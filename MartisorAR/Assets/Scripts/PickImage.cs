using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickImage : MonoBehaviour
{
    [SerializeField] Material mat;

    public void PickImage1(int maxSize) {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null) {
                // Creez textura pt imagine
                Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
                if (texture == null) {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }
          
                mat.mainTexture = texture;
            }
        }, "Select a PNG image", "image/png");
    }
}
