using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.VFX;

public class Enemy:MonoBehaviour
{

        private Vector3 speed;

        private bool spawning;
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
        


        private void Update()
        {
                var distanceVector = GameObject.Find("Player").transform.position - transform.position;
                if (distanceVector.magnitude > 4)
                {
                        GetComponentInChildren<VisualEffect>().Stop();
                        Invoke("CancelAttack", 3);
                }
                else
                {
                        if (!GetComponentInChildren<VisualEffect>().enabled)
                        {
                                GetComponentInChildren<VisualEffect>().enabled = true;
                                
                                GetComponentInChildren<VisualEffect>().Play();
                        }
                        
                        
                        GetComponentInChildren<VisualEffect>().SetVector3("Target",distanceVector );
                        
                        if(GetComponentInChildren<VisualEffect>().enabled)
                                GameObject.Find("Player").GetComponent<Health>().DoDamage(Time.deltaTime);
                }
                
                
                
                if (distanceVector.magnitude < 6)
                {
                        var targetPosition = GameObject.Find("Player").transform.position -
                                             (distanceVector * (3f / distanceVector.magnitude));
                        targetPosition.y = GameObject.Find("Player").transform.position.y;
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