using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WhatImLookingAt : MonoBehaviour
{
    [System.Serializable]
    public struct Target
    {
        public Transform target;
        public float dot;
        public bool active;
    }

    public Target[] targets;


    private void Update()
    {
        int closest = 0;
        for (int i = 0; i < targets.Length; i++)
        {
            Vector3 dir = (targets[i].target.position - transform.position).normalized;
            targets[i].dot = Vector3.Dot(dir, transform.forward);
            targets[i].active = false;
            if (targets[i].dot > targets[closest].dot)
            {
                closest = i;
            }
        }
        targets[closest].active = true;
    }

    private void OnDrawGizmos()
    {
        foreach (Target obj in targets)
        {
            if (obj.active)
            {
                Gizmos.color = Color.green;
            }
            else
            {
                Gizmos.color = Color.red;
            }
            Gizmos.DrawWireSphere(obj.target.position, obj.dot + 1);
        }
    }
}
