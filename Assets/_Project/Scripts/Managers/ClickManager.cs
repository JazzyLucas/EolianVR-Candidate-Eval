using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Listeners;
using _Project.SOs;
using UnityEngine;
using UnityEngine.UIElements;

namespace _Project.Managers
{
    public class ClickManager : MonoBehaviour
    {
        //// Dependencies
        private ClickListener clickListener;
        // Misc
        private BallSpawner ballSpawner;
        
        private void Start()
        {
            GrabDependenciesFromScene();
            SubscribeToEvents();
        }

        private void GrabDependenciesFromScene()
        {
            clickListener = FindObjectOfType<ClickListener>();
            ballSpawner = gameObject.AddComponent<BallSpawner>();
        }

        private void SubscribeToEvents()
        {
            clickListener.OnClickEvent += (ClickSO click) =>
            {
                ballSpawner.SpawnBallAtClick(click);
                Debug.Log("Click happened at pos: " + click.clickPosition);
            };
        }
    }
}