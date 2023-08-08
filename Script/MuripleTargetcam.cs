using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MuripleTargetcam : MonoBehaviour
{
    
    public List<Transform> target;
    public float smoothTime = .5f;
    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zommLimiter =50f;
    public Vector3 offset;
    private Vector3 velocity;
    private Camera cam;
    private void Start() {
        cam = GetComponent<Camera>();
    }
    private void LateUpdate() {

        if(target.Count == 0)
        {
            return;
        }
        Move();
        Zoom();
    }
    void Zoom()
    {
       float newZoom = Mathf.Lerp(maxZoom,minZoom, GetGreatesDistance()/zommLimiter);
       cam.fieldOfView = Mathf.Lerp(cam.fieldOfView,newZoom,Time.deltaTime);
    }
    void Move()
    {
         Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position =  Vector3.SmoothDamp(transform.position, newPosition,ref velocity,smoothTime);
    }
    float GetGreatesDistance()
    {
          var bounds = new Bounds(target[0].position,Vector3.zero);
          for (int i = 0; i < target.Count; i++)
          {
            bounds.Encapsulate(target[i].position);
          }
          return bounds.size.x;
    }
    Vector3 GetCenterPoint()
    {
        if(target.Count == 1)
        {
            return target[0].position;
        }
        var bounds = new Bounds(target[0].position,Vector3.zero);
        for (int i = 0; i < target.Count; i++)
        {
            bounds.Encapsulate(target[i].position);
        }
        return bounds.center;
        
    }
}
