
using UnityEditor;
using UnityEngine;
using VRC.SDK3.Dynamics.PhysBone.Components;
using ZeroFactory.AvatarPoseSystem.NDMF;

public class APSEBSetterEditor : Editor
{
    [MenuItem("Tools/N/APSEB Setter")]
    private static void SetAPSEB()
    {
        foreach (GameObject go in Selection.gameObjects)
        {
            VRCPhysBone physBone = go.GetComponent<VRCPhysBone>();
            if (physBone != null)
            {
                AvatarPoseSystemExtraBone apseb = go.GetComponent<AvatarPoseSystemExtraBone>();
                if (apseb == null)
                {
                    apseb = go.AddComponent<AvatarPoseSystemExtraBone>();
                }
                apseb.rootTransform = physBone.rootTransform;
            }
        }
    }
}
