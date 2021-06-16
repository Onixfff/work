using System;
using System.Collections.Generic;
using System.Linq;

namespace quality
{
    class Calculater
    {
        public float StrangthActual(List<double> breakingLoad_kH, List<double> long1, List<double> with)
        {
            float sum = 0;
            for (int i = 0; i < breakingLoad_kH.Count(); i++)
            {
                sum += ((float)((float)(breakingLoad_kH[i] * 0.95 / (long1[i] * with[i])) * 0.8 * 100));
            }
            return sum;
        }

        public float DensityActual(List<int> drySampleWeight_gram, List<double> long1, List<double> with, List<double> height)
        {
            float sum = 0;
            float ig;
            for (int i = 0; i < drySampleWeight_gram.Count(); i ++)
            {
                float.TryParse(Convert.ToString(drySampleWeight_gram[i]), out ig);
                sum += (float)(ig / (long1[i] * with[i] * height[i]));
            }
            return sum;
        }

        public float HumidityActual(List<int> drySampleWeight_gram, List<int> sampleWetWeight_gram)
        {
            float sum = 0;
            for(int i = 0; i < drySampleWeight_gram.Count(); i++)
            {
                sum += (float)(sampleWetWeight_gram[i] - drySampleWeight_gram[i]) / drySampleWeight_gram[i] / 100;
            }
            return sum;
        }
    }
}
