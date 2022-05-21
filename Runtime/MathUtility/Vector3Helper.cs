using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheKnightsSanctuary.Core
{
    public class Vector3Helper : MonoBehaviour
    {
        /// <summary>
        /// https://answers.unity.com/questions/1271974/inverselerp-for-vector3.html
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Vector3InverseLerp(Vector3 a, Vector3 b, Vector3 value)
        {
            Vector3 AB = b - a;
            Vector3 AV = value - a;
            return Vector3.Dot(AV, AB) / Vector3.Dot(AB, AB);
        }
    }
}
