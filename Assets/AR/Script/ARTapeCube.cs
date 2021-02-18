using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARRaycastManager))]
public class ARTapeCube : MonoBehaviour
{

    public GameObject ObjectToInstance;

    private GameObject spawnedObject;

    private ARRaycastManager _ArRaycastManager;
    private Vector2 touchposition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    // Start is called before the first frame update
    private void Awake()
    {
        _ArRaycastManager = GetComponent<ARRaycastManager>();

    }
    bool TryGetTouchPosition(out Vector2 touchposition)
    {
        if (Input.touchCount > 0)
        {
            touchposition = Input.GetTouch(index: 0).position;
            return  true;
        }
        touchposition = default;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchposition))
            return;
        if (_ArRaycastManager.Raycast(touchposition, hits, trackableTypes: TrackableType.PlaneWithinPolygon))
        {
            var hitpose = hits[0].pose;
            
            if(spawnedObject == null)
            {
                spawnedObject = Instantiate(ObjectToInstance, hitpose.position, hitpose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitpose.position;
            }

        }
    }
}
