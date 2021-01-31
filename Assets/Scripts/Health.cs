using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "playerhealth", menuName = "ScriptableObjects/Health")]
public class Health : ScriptableObject
{
    [Tooltip("Character current health amount")]
    public int CurrentHealth;
    [Tooltip("Character maximum health amount")]
    public int MaxHealth = 3;

    public event System.Action OnHealthReachedZero;

    public void FullLife()
    {
        CurrentHealth = MaxHealth;
    }

    public void DecreaseCurrentLife()
    {
        CurrentHealth -= 1;

        // If we hit 0. Die.
        if (CurrentHealth == 0)
        {
            OnHealthReachedZero?.Invoke();
        }
    }

    public void IncreaseCurrentLife()
    {
        CurrentHealth += 1;
    }
}
