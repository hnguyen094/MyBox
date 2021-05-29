using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace MyBox {
    [CustomEditor(typeof(UnityEngine.MonoBehaviour), true)]
    public class ShowInInspectorMonoBehaviourEditor : ShowInInspectorEditor { }
}