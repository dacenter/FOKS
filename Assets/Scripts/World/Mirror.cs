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

        [SerializeField] private Camera MirrorCamera;
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
                var mirrorCamera = GameObject.Find("MirrorCamera").GetComponent<Camera>();
                while (true)
                {
                        MirrorCamera.cullingMask =~LayerMask.GetMask("Hidden");
                        yield return new WaitForSeconds(Random.Range(0f, 0.8f));
                        
                        MirrorCamera.cullingMask =~LayerMask.GetMask("Player");
                        yield return new WaitForSeconds(Random.Range(0f, 0.8f));
                }
        }


        public void EndLevel()
        {
                Light2D light = GetComponentInChildren<Light2D>();
                
                DOTween.To(()=>light.intensity, x=>light.intensity=x, 2f, 4f).OnComplete(() =>
                {
                        DOTween.To(() => light.intensity, x => light.intensity = x, 200000f, 1f);
                });
                Invoke("FreezePlayer", 0.05f);

        }

        public void FreezePlayer()
        {
                var player = FindObjectOfType<Player>();
                player.StopMoving();
                player.RecieveInput = false;
                player.transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);
        }
}