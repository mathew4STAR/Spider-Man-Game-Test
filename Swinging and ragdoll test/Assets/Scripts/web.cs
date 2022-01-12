using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class web : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 GrapplePoint;
    public LayerMask sticky;
    public Transform wrist;
    public Transform camera;
    public Transform player;
    public float maxdistance = 100f;
    private SpringJoint joint;
    public Transform firsttar;
    
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("hit button");
            startgrapple();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endgrapple();
        }
    }
    void startgrapple()
    {
        /*
        RaycastHit hit;
        if(Physics.Raycast(camera.position,camera.right, out hit, Mathf.Infinity))
        {
            Debug.Log("iowjflkasjfojmqwo;");
            GrapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = GrapplePoint;

            float distanceFromAnchor = Vector3.Distance(player.position, GrapplePoint);

            joint.maxDistance = distanceFromAnchor * 0.8f;
            joint.minDistance = distanceFromAnchor * 0.25f;

            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

        }
        */
        GrapplePoint = firsttar.position;
        joint = player.gameObject.AddComponent<SpringJoint>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedAnchor = GrapplePoint;
        float distanceFromAnchor = Vector3.Distance(player.position, GrapplePoint);
        joint.maxDistance = distanceFromAnchor * 0.8f;
        joint.minDistance = distanceFromAnchor * 0.25f;
        joint.spring = 4.5f;
        joint.damper = 7f;
        joint.massScale = 4.5f; 
    }
    
    void endgrapple()
    {

    }
}
