using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
  public float fov = 10f;
  public float maxRange = 0.01f;
  public float minRange = 0f;
  public float aspectRatio = 1500f;

  public void OnDrawGizmos()
  {
    var gizmoMatrix = Gizmos.matrix;
    var gizmoColor = Gizmos.color;

    Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
    Gizmos.color = Color.red;
    Gizmos.DrawFrustum(Vector3.zero, maxRange, maxRange, minRange, aspectRatio);

    Gizmos.matrix = gizmoMatrix;
    Gizmos.color = gizmoColor;
  }
}
