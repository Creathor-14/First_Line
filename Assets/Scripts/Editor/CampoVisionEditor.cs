using System;
using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CampoVision))]
public class CampoVisionEditor : Editor 
{
    void OnSceneGUI()
    {
        CampoVision cv = (CampoVision)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(cv.transform.position, Vector3.up, Vector3.forward, 360,cv.ViewRadius);
        Vector3 viewAngleA = cv.DirFromAngle(-cv.viewAngle / 2, false);
        Vector3 viewAngleB = cv.DirFromAngle(cv.viewAngle / 2, false);
        
        Handles.DrawLine(cv.transform.position, cv.transform.position+viewAngleA*cv.ViewRadius);
        Handles.DrawLine(cv.transform.position, cv.transform.position+viewAngleB*cv.ViewRadius);
        
        Handles.color = Color.red;
        foreach (Transform visibleTarget in cv.visibleTargets)
        {
            Handles.DrawLine(cv.transform.position, visibleTarget.position);
        }
        {
            
        }

    }
}
