using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Random = UnityEngine.Random;

public class Mirror:MonoBehaviour
{
        public float XShift;
        public float YShift;
        public void Update()
        {
                var distance = Camera.main.transform.position - transform.position;
                distance.x += XShift;
                distance.y += YShift;
                distance.y = -distance.y;
                distance.x = -distance.x;
                GetComponent<MeshRenderer>().material.SetTextureOffset("_BaseMap", distance/10);
        }

        private void Start()
        {
                StartCoroutine(Glitching());
        }


        private IEnumerator Glitching()
        {
                while (true)
                {
                        GameObject.Find("MirrorCamera").GetComponent<Camera>().cullingMask =~LayerMask.GetMask("Hidden");
                        yield return new WaitForSeconds(Random.Range(0.1f, 0.8f));
                        
                        GameObject.Find("MirrorCamera").GetComponent<Camera>().cullingMask =~LayerMask.GetMask("Player");
                        yield return new WaitForSeconds(Random.Range(0.1f, 0.8f));
                }
        }


        public void EndLevel()
        {
                Debug.Log("Ends level");
                Light2D light = GetComponentInChildren<Light2D>();
                
                DOTween.To(()=>light.intensity, x=>light.intensity=x, 5f, 4f);
                Invoke("FreezePlayer", 0.05f);

        }

        public void FreezePlayer()
        {
                
                FindObjectOfType<Player>().GetComponentInChildren<CharacterController2D>().enabled = false;
                FindObjectOfType<Player>().RecieveInput = false;
                FindObjectOfType<Player>().transform.position = transform.position;
        }
}