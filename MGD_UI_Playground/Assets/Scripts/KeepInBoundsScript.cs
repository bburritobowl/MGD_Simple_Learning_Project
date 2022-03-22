using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInBoundsScript : MonoBehaviour
{
    public Camera MainCamera; //be sure to assign this in the inspector to your main camera
    private Vector2 screenBounds;
    // private float objectWidth;
    // private float objectHeight;

    // Use this for initialization
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        // objectWidth = transform.GetComponentInChildren<MeshRenderer>().bounds.extents.x; //extents = size of width / 2
        // objectHeight = transform.GetComponentInChildren<MeshRenderer>().bounds.extents.y; //extents = size of height / 2
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y, screenBounds.y * -1);
        viewPos.z = 500; //Ship location on z
        transform.position = viewPos;
    }
}
