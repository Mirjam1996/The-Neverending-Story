using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Wasser : MonoBehaviour {

    public int xSize = 20;
    public int zSize = 20;
    private Vector3[] vertices;
    private Mesh grid;
    float timer = 0.0f;

    private void Update()
    { timer += Time.deltaTime;
        if (timer >= 0.15f)
        {
            Generate();
            timer = 0.0f;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
    private void Generate()
    {
        vertices = new Vector3[(xSize + 1) * 1 * (zSize + 1)];
        GetComponent<MeshFilter>().mesh = grid = new Mesh();
        grid.name = "Procedural Grid";
        for (int i = 0, z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++, i++)
            {
                vertices[i] = new Vector3(x, Random.Range(-0.1f, 1.0f), z);
            }
        }
        grid.vertices = vertices;
        int[] triangles = new int[xSize* zSize* 6];
        for (int ti = 0, vi = 0, z = 0; z < zSize; z++, vi++)
        {
            for (int  x = 0; x < xSize; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 3] = triangles[ti + 2] = vi + 1;
                triangles[ti + 4] = triangles[ti + 1] = vi + xSize + 1;
                triangles[ti + 5] = vi + xSize + 2;
                grid.triangles = triangles;

            }
        }

    }
    //private void OnDrawGizmos()
    //{
    //    if (vertices == null)
    //    {
    //        return;
    //    }
    //    Gizmos.color = Color.black;
    //    for (int i = 0; i < vertices.Length; i++)
    //    {
    //       Gizmos.DrawSphere(vertices[i], 0.1f);
    //    }
    //}
}


    
