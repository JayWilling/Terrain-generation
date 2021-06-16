using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public int octaves;
    [Range(0,1)]
    public float persistence;
    public float lacunarity;

    public int seed;
    public Vector2 offset;

    public bool autoUpdate;

    public void GenerateMap() {
        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale, seed, octaves, persistence, lacunarity, offset);

        // TODO: Add in lacunarity and persistence

        MapDisplay display = FindObjectOfType<MapDisplay> ();
        display.DrawNoiseMap(noiseMap);
    }

    private void OnValidate() {
        if (mapWidth < 1) {
            mapWidth = 1;
        }
        if (mapHeight < 1) {
            mapHeight = 1;
        }
        if (octaves < 1) {
            octaves = 1;
        }
        if (persistence < 0) {
            persistence = 0;
        } else if (persistence > 1) {
            persistence = 1;
        }
        if (lacunarity < 1) {
            lacunarity = 1;
        }
    }

}

// System.Serializable means the struct will show up in the inspector
[System.Serializable]
public struct TerrainType {
    public string name;
    public float height;
    public Color colour;
}
