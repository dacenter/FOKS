using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.Universal;

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


        public void EndLevel()
        {
                Debug.Log("Ends level");
                Light2D light = GetComponentInChildren<Light2D>();
                DOTween.To(()=>light.intensity, x=>light.intensity=x, 5f, 4f);

        }
}