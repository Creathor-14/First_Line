using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoVision : MonoBehaviour
{
    public float ViewRadius;
    [Range(0,360)]
    public float viewAngle;

    public LayerMask AtaqueMask;
    [HideInInspector]
    public List<Transform> visibleTargets = new List<Transform>();

    private void Start()
    {
        StartCoroutine("FindTargetsWithDelay", .2f);
    }

    IEnumerator FindTargetsWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }
    
    void FindVisibleTargets()
    {
        visibleTargets.Clear();
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, ViewRadius, AtaqueMask);
        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToTarget) < viewAngle / 2)
            {
                float distToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast(transform.position, dirToTarget, distToTarget, AtaqueMask))
                {
                    visibleTargets.Add(target);
                }
            }
        }
    }

    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees*Mathf.Deg2Rad),0,Mathf.Cos(angleInDegrees * Mathf.Deg2Rad ));
    }
    
    
    
}
