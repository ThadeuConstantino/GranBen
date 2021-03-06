using UnityEngine;
using Sirenix.OdinInspector;

namespace GranGames.Scriptable
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(fileName = "Enemy", menuName = "GranGames/Enemy", order = 3)]
    public class Enemy : SerializedScriptableObject
    {
        [Header("Data")]
        [SerializeField]
        [Range(1, 100)]
        private float health;
        [SerializeField]
        [Range(1, 100)]
        private float attackpower;
      
        //Getters and Setters
        public float Health { get => health; set => health = value; }
        public float AttackPower { get => attackpower; set => attackpower = value; }
    }
}