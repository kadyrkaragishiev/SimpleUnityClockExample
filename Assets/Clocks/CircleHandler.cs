using System;
using UnityEngine;

namespace Clocks
{
    public class CircleHandler : MonoBehaviour
    {
        [SerializeField]
        private Transform hourLine;

        [SerializeField]
        private Transform minutesLine;

        [SerializeField]
        private Transform secondsLine;


        private void DrawClock(string time)
        {
            var timeSplit = time.Split(':');
            var hour = int.Parse(timeSplit[0]);
            var minutes = int.Parse(timeSplit[1]);
            var seconds = int.Parse(timeSplit[2]);

            hourLine.localRotation = Quaternion.Euler(0, 0, -(hour * 30));
            minutesLine.localRotation = Quaternion.Euler(0, 0, -(minutes * 6));
            secondsLine.localRotation = Quaternion.Euler(0, 0, -(seconds * 6));
        }

        private void Update() => DrawClock(DateTime.Now.ToString("HH:mm:ss"));

    }
}
