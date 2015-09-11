// <copyright> Copyright (c) All Rights Reserved </copyright>
// <author>Michele Pirovano</author>

namespace Cat.Editor
{
    using UnityEngine;
    using UnityEditor;
    using System.IO;

    public static class CustomAssetUtility
    {
        public static void CreateAsset<T>(string path = null, string name = null) where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance<T>();

            if (path == null) path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
            {
                path = "Assets";
            }
            else if (Path.GetExtension(path) != "")
            {
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
            }

            if (name == null) name = "New " + typeof(T).ToString();

            string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/" + name + ".asset");
            AssetDatabase.CreateAsset(asset, assetPathAndName);

            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

    }
}