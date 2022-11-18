using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;
 
 
public class GrabbablePrefabCreator : MonoBehaviour
{
    [Header("Make a normal GO")]
    public GameObject objectToConvert;
    public Transform parent;
    public GameObject audioPrefab;
    public bool freeTransform;
    public bool rotateTransform;

    private void Start()
    {
         

    }

    public void CreateObjectFreeTransform()
    {
        objectToConvert = AddComponents();
    }

    public void CreateObjectRotate()
    {
        objectToConvert = AddComponents(2);
    }

    private GameObject AddComponents(int option = 0)
    {
        Rigidbody rigidB = objectToConvert.AddComponent(typeof(Rigidbody)) as Rigidbody;
        MeshCollider collider = objectToConvert.AddComponent(typeof(MeshCollider)) as MeshCollider;
        
        Grabbable grabbable = objectToConvert.AddComponent(typeof(Grabbable)) as Grabbable;
        GrabInteractable grabInteractable = objectToConvert.AddComponent(typeof(GrabInteractable)) as GrabInteractable;
        HandGrabInteractable handGrab = objectToConvert.AddComponent(typeof(HandGrabInteractable)) as HandGrabInteractable;
        //TouchHandGrabInteractable touchHandGI = gameObject.AddComponent(typeof(TouchHandGrabInteractable)) as TouchHandGrabInteractable;
        InteractableGroupView interactableGV = objectToConvert.AddComponent(typeof(InteractableGroupView)) as InteractableGroupView;
        InteractableUnityEventWrapper interacUnityEW = objectToConvert.AddComponent(typeof(InteractableUnityEventWrapper)) as InteractableUnityEventWrapper;
        PhysicsGrabbable physics = objectToConvert.AddComponent(typeof(PhysicsGrabbable)) as PhysicsGrabbable;
        switch (option)
        {
            case 1:
                OneGrabFreeTransformer grabFree = objectToConvert.AddComponent(typeof(OneGrabFreeTransformer)) as OneGrabFreeTransformer;
                break;

            case 2:
                OneGrabRotateTransformer grabRotate = objectToConvert.AddComponent(typeof(OneGrabRotateTransformer)) as OneGrabRotateTransformer;
                break;

            case 0:
                break;
        }
        Instantiate(audioPrefab, objectToConvert.transform);

        objectToConvert.transform.localPosition = Vector3.zero;
        objectToConvert.transform.localRotation = Quaternion.identity;
        objectToConvert.transform.SetParent(parent);

        return objectToConvert;
    }

}
