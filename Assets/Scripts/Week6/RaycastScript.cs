using UnityEditor;
using UnityEngine;
using TMPro;

public class RaycastScript : MonoBehaviour
{
    [SerializeField] float distances;
    [SerializeField] LayerMask layerMask;

    //[SerializeField] Color color;
    public TextMeshProUGUI ObjectName, Distance;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, distances, layerMask))
        {
            //Debug.Log($"Object name {hitInfo.transform.name}");
            //MeshRenderer renderer = hitInfo.transform.GetComponent<MeshRenderer>();
            //renderer.material.color = color;
            ObjectName.text = hitInfo.transform.name;
            Distance.text = hitInfo.distance.ToString("F2");

            Debug.DrawLine(ray.origin, hitInfo.point, Color.green);
        }
        else
        {
            ObjectName.text = "";
            Distance.text = "";
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * distances, Color.red);
        }
    }

    
}
