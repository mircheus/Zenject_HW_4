using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Homework_1.HW_1_4
{
    [RequireComponent(typeof(Collider))]
    public class Balloon : MonoBehaviour
    {
        [SerializeField] private BalloonColor balloonColor;
        
        private Collider _collider;
        
        public event Action<Balloon> Interacted;
        
        public BalloonColor BalloonColor => balloonColor;
        
        private void Awake()
        {
            _collider = GetComponent<Collider>();
        }
        
        private void OnMouseDown()
        {
            Debug.Log($"Balloon color is {balloonColor}");
            OnInteracted();
        }
        
        private void OnInteracted()
        {
            Interacted?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}

