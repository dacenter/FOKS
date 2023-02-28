using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public List<SpriteRenderer> BGs;

    public float CorrectionFactor;

    public float DistanceFactor;
    public void Update()
    {
        float distance = 1f;

        Vector2 position = transform.position;

        foreach (SpriteRenderer bg in BGs)
        {
            ApplyBGPositionOffset(bg, position, distance);
            ApplyBGTextureOffset(bg, position, distance);

            distance *= DistanceFactor;
        }
    }

    private static void ApplyBGPositionOffset(SpriteRenderer bg, Vector2 position, float distance)
    {
        Vector2 bgPosition = bg.transform.position;

        bg.transform.position = new Vector3(position.x, bgPosition.y, 10 + distance);
    }

    private void ApplyBGTextureOffset(SpriteRenderer bg, Vector2 position, float distance)
    {
        Vector2 offset = new(position.x / (distance * CorrectionFactor), 0f);
        bg.material.SetTextureOffset("_MainTex", offset);
    }
}