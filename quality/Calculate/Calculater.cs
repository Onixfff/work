using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quality
{
    class Calculater
    {
        public string StrangthActual(List<float> breakingLoad_kH, List<float> long1, List<float> with)
        {
            float sum = 0;
            for (int i = 0; i < breakingLoad_kH.Count(); i++)
            {
                sum += breakingLoad_kH[i] * 0.95f / (long1[i] * with[i]) * 0.8f * 100;
            }
            StringBuilder strB = new StringBuilder(Convert.ToString(sum));
            for(int i = 0; i < strB.Length; i++)
            {
                if(strB[i] == ',')
                {
                    strB[i] = '.';
                }
            }
            return strB.ToString();
        }

        public string DensityActual(List<int> drySampleWeight_gram, List<float> long1, List<float> with, List<float> height)
        {
            float sum = 0;
            for (int i = 0; i < drySampleWeight_gram.Count(); i ++)
            {
                sum += (drySampleWeight_gram[i] / (long1[i] * with[i] * height[i]));
            }
            StringBuilder strB = new StringBuilder(Convert.ToString(sum));
            for (int i = 0; i < strB.Length; i++)
            {
                if (strB[i] == ',')
                {
                    strB[i] = '.';
                }
            }
            return strB.ToString();
        }

        public string HumidityActual(List<int> drySampleWeight_gram, List<int> sampleWetWeight_gram)
        {
            float sum = 0;
            for(int i = 0; i < drySampleWeight_gram.Count(); i++)
            {
                sum += (sampleWetWeight_gram[i] - drySampleWeight_gram[i]) / drySampleWeight_gram[i] / 100;
            }
            StringBuilder strB = new StringBuilder(Convert.ToString(sum));
            for (int i = 0; i < strB.Length; i++)
            {
                if (strB[i] == ',')
                {
                    strB[i] = '.';
                }
            }
            return strB.ToString();
        }
    }
}
