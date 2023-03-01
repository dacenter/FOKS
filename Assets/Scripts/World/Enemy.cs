using System;
using System.Collections;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Enemy:MonoBehaviour
{

        private Vector3 speed;

        private bool spawning;

        private Transform target;
        private void Start()
        {
        }

        private void Spawn()
        {
                spawning = false;
                GetComponent<SpriteRenderer>().material.SetFloat("_Phase", 0);
                GetComponent<SpriteRenderer>().material.DOFloat(64, "_Phase", 5).OnComplete(() =>
                {
                        
                        spawning = false;
                });
                
        }
        
        private void Despawn()
        {
                spawning = true;
                GetComponent<SpriteRenderer>().material.DOFloat(0, "_Phase", 3).OnComplete(() =>
                {
                        
                        spawning = false;
                });
                
                
        }
        
        private Transform GetClosestEnemy()
        {
                var enemies = FindObjectsOfType<Health>();
                Transform tMin = null;
                float minDist = Mathf.Infinity;
                Vector3 currentPos = transform.position;
                foreach (var t in enemies)
                {
                        float dist = Vector3.Distance(t.transform.position, currentPos);
                        if (dist < minDist)
                        {
                                tMin = t.transform;
                                minDist = dist;
                        }
                }
                return tMin;
        }
        


        private void Update()
        {
                var distanceVector = GameObject.Find("Player").transform.position - transform.position;
                if (distanceVector.magnitude > 7)
                {
                        GetComponentInChildren<VisualEffect>().Stop();
                        Invoke("CancelAttack", 3);
                }
                else
                {
                        Debug.Log("AI RUNNING");
                        this.target = GetClosestEnemy();
                        GetClosestEnemy().GetComponent<Health>().DoDamage(1*Time.deltaTime);
                        GetComponentInChildren<VisualEffect>().enabled = true;
                        GetComponentInChildren<VisualEffect>().Play();
                }
                
                
                
                if (distanceVector.magnitude < 6)
                {
                        var targetPosition =target.position-
                                             (distanceVector * (3f / distanceVector.magnitude));
                        targetPosition.y = target.position.y;
                        transform.position = Vector3.SmoothDamp(transform.position,targetPosition
                                , ref speed, Mathf.Max(100f * Time.deltaTime, 0.1f));

                        if (!spawning)
                        {
                                Spawn();
                        }
                }
                else
                {
                        if (!spawning)
                        {
                                Despawn();
                        }
                }
        }

        private void CancelAttack()
        {
                GetComponentInChildren<VisualEffect>().enabled = false;
        }
}