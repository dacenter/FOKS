using System.Collections.Generic;
using UnityEngine;

public class MenuBG : MonoBehaviour
{
    public List<SpriteRenderer> BGs;

    public float CorrectionFactor;

    public float DistanceFactor;
    public void Update()
    {
        float distance = 1f;

        Vector2 position = new Vector2(Mathf.Sin(Time.time/2), Mathf.Sin(Time.time/2.1f));

        foreach (SpriteRenderer bg in BGs)
        {
            ApplyBGTextureOffset(bg, position, distance);

            distance *= DistanceFactor;
        }
    }


    private void ApplyBGTextureOffset(SpriteRenderer bg, Vector2 position, float distance)
    {
        Vector2 offset = new(position.x / (distance * CorrectionFactor), position.y / (distance * 3*CorrectionFactor));
        bg.material.SetTextureOffset("_MainTex", offset);
    }
}