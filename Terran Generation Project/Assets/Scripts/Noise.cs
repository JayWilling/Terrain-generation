using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Mathf.PerlinNoise.html
// Basic noise generation utilises the example provided through Unity documentation

public static class Noise {
    
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale) {

        float[,] noiseMap = new float[mapWidth, mapHeight];

        if (scale <= 0) {
            scale = 0.0001f;
        }

        for (int x = 0; x < mapWidth; x++) {
            for (int y = 0; y < mapHeight; y++) {

                float xCoord = x / scale;
                float yCoord = y / scale;

                float perlinValue = Mathf.PerlinNoise(xCoord, yCoord);
                noiseMap[x, y] = perlinValue;
                
            }
        }

        return noiseMap;
    }

}
