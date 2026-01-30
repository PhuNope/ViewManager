namespace Nope.ViewManager.Editor.ScriptableObjects
{
    using Runtime.ScriptableObjects;
    using Editor;
    using UnityEditor;
    using UnityEngine;

    public class ViewRegistrarCreator : MonoBehaviour
    {
        [MenuItem("Tools/View Manager/Create Registrar")]
        public static void CreateViewRegistrar()
        {
            ScriptableObjectUtility.CreateAsset<ViewRegistrar>();
        }
    }
}