using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //Clamp for camera to not pass fixed "start"
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, -0.43f, 25.35f),
             Mathf.Clamp(targetToFollow.position.y, 0.02f, 5.55f),
             transform.position.z);
    }
}
