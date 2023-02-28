using UnityEngine;
using UnityEngine.Events;

public class Health:MonoBehaviour
{
    public float MaxHP;

    public float CurrentHP;

    public UnityEvent Dead;

    public float DoDamage(float damage)
    {
        CurrentHP -= damage;

        if (CurrentHP < 0)
        {
            CurrentHP = 0;
            Dead.Invoke();
        }

        return CurrentHP;
    }
    
    
}