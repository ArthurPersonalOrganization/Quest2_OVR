using Oculus.Interaction;
using UnityEngine;

[CreateAssetMenu(fileName = "Grabblable Objects")]
public class GrabbableSO : ScriptableObject
{
    public GameObject objectToConvert;
    public string name;

    private void OnEnable()
    {
        objectToConvert.name = name;
        Grabbable grabbable = objectToConvert.AddComponent(typeof(Grabbable)) as Grabbable;
        GrabInteractable grabInteractable = objectToConvert.AddComponent(typeof(GrabInteractable)) as GrabInteractable;
    }

}