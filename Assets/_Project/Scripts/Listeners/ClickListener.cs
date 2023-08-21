using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Managers;
using _Project.SOs;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace _Project.Listeners
{
    public class ClickListener : MonoBehaviour
    {
        public ClickSO clickTemplate;
        
        public event Action<ClickSO> OnClickEvent;
        private void InvokeClickEvent(ClickSO click) => OnClickEvent?.Invoke(click);
        
        private void Start()
        {
            var pointerHandler = gameObject.GetComponent<PointerHandler>();
            
            pointerHandler.OnPointerDown.AddListener((e) =>
            {
                var newClick = clickTemplate;
                newClick.clickPosition = e.Pointer.Position;
                newClick.clickRotation = e.Pointer.Rotation;
                InvokeClickEvent(newClick);
            });
        }
    }
}