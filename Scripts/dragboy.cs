
using UnityEngine;
// using UnityEngine.EventSystem;
using EventSystems = UnityEngine.EventSystems;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class DragController : MonoBehaviour
{
    
    public static GameObject mydragboy;
    Vector3 startPosition;
    float zDistanceToCamera;
    Vector3 touchOffset;

    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data)
    {
        mydragboy = gameObject;
        startPosition = transform.position;
        zDistanceToCamera = Mathf.Abs(startPosition.z - Camera.main.transform.position.z);
        touchOffset = startPosition - Camera.main.ScreenToWorldPoint
         (new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera));
    }

    public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
    {
        if (Input.touchCount > 1)
            return;

        transform.position = Camera.main. ScreenToWorldPoint 
        (new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera))+touchOffset;
    }   
    
    public void OnEndDrag(UnityEngine.EventSystems.PointerEventData data)
    {
        mydragboy = null;
        touchOffset = Vector3.zero;
    }
}