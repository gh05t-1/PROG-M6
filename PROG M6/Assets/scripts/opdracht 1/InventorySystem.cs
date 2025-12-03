using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<string> _items = new List<string> { };
    [SerializeField] private List<string> _world = new List<string> { "Gun", "Gun", "Gun", "Medipack", "Medipack", "Medipack", "Gun", "Keycard" };
    private int _medipackCount;
    private int _gunCount;
    private int _keycardCount;
    private int _medipackCountItem;
    private int _gunCountItem;
    private int _keycardCountItem;


    private void Start()
    {

    }
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Items in world");
            Debug.Log("Medipacks : " + _medipackCount);
            Debug.Log("Guns : " + _gunCount);
            Debug.Log("Keycards : " + _keycardCount);

            Debug.Log("Items in inventory");
            Debug.Log("Medipacks : " + _medipackCountItem);
            Debug.Log("Guns : " + _gunCountItem);
            Debug.Log("Keycards : " + _keycardCountItem);

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            _items.Add("medipack");
            _world.Remove("medipack");
            WorldCheck();
            InventoryCheck();
            Debug.Log("Picked up medipack");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            _items.Add("gun");
            _world.Remove("gun");
            WorldCheck();
            InventoryCheck();
            Debug.Log("Picked up gun");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            _items.Add("keycard");
            _world.Remove("keycard");
            WorldCheck();
            InventoryCheck();
            Debug.Log("Picked up keycard");
        }
    }

    private void InventoryCheck()
    {

        foreach (var item in _items)
        {
            if(item == "medipack")
            {
                _medipackCountItem++;
            }
            if(item == "gun")
            {
                _gunCountItem++;
            }
            if(item == "keycard")
            {
                _keycardCountItem++;
            }
        }
    }
    private void WorldCheck()
    {

        foreach (var item in _world)
        {
            if (item == "medipack")
            {
                _medipackCount++;
            }
            if (item == "gun")
            {
                _gunCount++;
            }
            if (item == "keycard")
            {
                _keycardCount++;
            }
        }
    }
}

