using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public ParanormalScriptableObject[] clothing;
    public ParanormalScriptableObject[] color;
    public ParanormalScriptableObject[] expression;
    public Vector3 position;
    public List<string> toolsRequired;
    public string toolToAdd;

    //follow player
    public float speed = 20.0f;
    public float minDist = 1f;
    public Transform target;

    public void Start()
    {
        // if no target specified, assume the player
        if (target == null)
        {

            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    public void Update()
    {
        if (target == null)
            return;

        // face the target
        transform.LookAt(target);

        //get the distance between the chaser and the target
        float distance = Vector3.Distance(transform.position, target.position);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void OnEnable()
    {
        foreach (ParanormalScriptableObject obj in clothing)
        {
            int i = Random.Range(0, clothing.Length + 1);

            clothing[i].prefab = Resources.Load(clothing[i].Itemname) as GameObject;
            Instantiate(clothing[i].prefab,position,Quaternion.identity) ;

            foreach(string weakness in clothing[i].Weakness)
            {
                toolToAdd = weakness;
                toolsRequired.Add(toolToAdd);
            }
            
        }
        foreach (ParanormalScriptableObject obj in color)
        {
            int i = Random.Range(0, color.Length + 1);

            color[i].prefab = Resources.Load(color[i].Itemname) as GameObject;
            Instantiate(color[i].prefab,position,Quaternion.identity) ;

            foreach (string weakness in color[i].Weakness)
            {
                toolToAdd = weakness;
                toolsRequired.Add(toolToAdd);
            }

        }
        foreach (ParanormalScriptableObject obj in expression)
        {
            int i = Random.Range(0, expression.Length + 1);

            expression[i].prefab = Resources.Load(expression[i].Itemname) as GameObject;
            Instantiate(expression[i].prefab,position,Quaternion.identity) ;

            foreach (string weakness in expression[i].Weakness)
            {
                toolToAdd = weakness;
                toolsRequired.Add(toolToAdd);
            }
        }
        
    }  
    public void OnDisable()
    {
        toolsRequired.Clear();
    }
    // Set the target of the chaser
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void OnDeath()
    {
        this.gameObject.SetActive(false);
    }
}
