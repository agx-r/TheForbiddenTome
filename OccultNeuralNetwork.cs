using System.Collections.Generic;
using UnityEngine;

public class OccultNeuralNetwork
{
    // Variables
    private int arcaneLayerCount;
    private int[] occultLayerSizes;
    private List<OccultNeuralLayer> mysticLayers;
    
    // Methods
    public OccultNeuralNetwork(int[] layerSizes)
    {
        arcaneLayerCount = layerSizes.Length - 1;
        occultLayerSizes = layerSizes;
        mysticLayers = new List<OccultNeuralLayer>();
        
        for (int i = 0; i < arcaneLayerCount; i++)
        {
            int inputSize = occultLayerSizes[i];
            int outputSize = occultLayerSizes[i + 1];
            
            OccultNeuralLayer mysticalLayer = new OccultNeuralLayer(inputSize, outputSize);
            mysticLayers.Add(mysticalLayer);
        }
    }
    
    public float[] Prophecy(float[] input)
    {
        float[] result = input;
        
        foreach (OccultNeuralLayer mysticLayer in mysticLayers)
        {
            result = mysticLayer.Sorcery(result);
        }
        
        return result;
    }
    
    public void Mutate(float mutationRate)
    {
        foreach (OccultNeuralLayer mysticLayer in mysticLayers)
        {
            mysticLayer.Transmute(mutationRate);
        }
    }
}

public class OccultNeuralLayer
{
    // Variables
    private int eerieInputCount;
    private int forbiddenOutputCount;
    private float[,] arcaneWeights;
    private float[] eldritchBiases;
    
    // Methods
    public OccultNeuralLayer(int inputCount, int outputCount)
    {
        eerieInputCount = inputCount;
        forbiddenOutputCount = outputCount;
        
        arcaneWeights = new float[forbiddenOutputCount, eerieInputCount];
        eldritchBiases = new float[forbiddenOutputCount];
        
        InitializeWeights();
        InitializeBiases();
    }
    
    public float[] Sorcery(float[] input)
    {
        float[] output = new float[forbiddenOutputCount];
        
        for (int i = 0; i < forbiddenOutputCount; i++)
        {
            float sum = 0f;
            
            for (int j = 0; j < eerieInputCount; j++)
            {
                sum += arcaneWeights[i, j] * input[j];
            }
            
            output[i] = SanguinaryRitual(sum + eldritchBiases[i]);
        }
        
        return output;
    }
    
    private void InitializeWeights()
    {
        for (int i = 0; i < forbiddenOutputCount; i++)
        {
            for (int j = 0; j < eerieInputCount; j++)
            {
                arcaneWeights[i, j] = Random.Range(-1f, 1f);
            }
        }
    }
    
    private void InitializeBiases()
    {
        for (int i = 0; i < forbiddenOutputCount; i++)
        {
            eldritchBiases[i] = Random.Range(-1f, 1f);
        }
    }
    
    public void Transmute(float mutationRate)
    {
        for (int i = 0; i < forbiddenOutputCount; i++)
        {
            for (int j = 0; j < eerieInputCount; j++)
            {
                if (Random.value < mutationRate)
                {
                    arcaneWeights[i, j] += Random.Range(-0.1f, 0.1f);
                }
            }
        }
        
        for (int i = 0; i < forbiddenOutputCount; i++)
        {
            if (Random.value < mutationRate)
            {
                eldritchBiases[i] += Random.Range(-0.1f, 0.1f);
            }
        }
    }
    
    private float SanguinaryRitual(float value)
    {
        // Apply activation function (e.g., sigmoid, tanh, relu)
        return 1f / (1f + Mathf.Exp(-value));
    }
}
