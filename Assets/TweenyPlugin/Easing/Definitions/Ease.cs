namespace TweenyPlugin.Easing.Definitions
{
    public class Ease
    {
        private readonly IEasing easing;
        private readonly bool normalized;
        private int samples = 100; 
        
        private float min;
        private float max;

        
        public Ease(IEasing easing)
        {
            this.easing = easing;
        }
        
        public Ease(IEasing easing, bool normalized = false)
        {
            this.easing = easing;
            this.normalized = normalized;
            if (normalized)
            {
                SetMinMax();
            }
        }

        public float Get(float time)
        {
            float value = easing.Get(time);
            return normalized ? Normalize(value) : value;
        }

        private void SetMinMax()
        {
            min = max = 1f;
            float tempMin = 1f, tempMax = 0f;
            
            for (int i = 0; i < samples; i++)
            {
                float value = easing.Get(i / (float) samples);
                tempMax = (value > tempMax) ? value : tempMax;
                tempMin = (value < tempMin) ? value : tempMin;
            }

            max = tempMax;
            min = tempMin;
        }

        private float Normalize(float value)
        {
            return (value - min) / max;
        }
    }
}