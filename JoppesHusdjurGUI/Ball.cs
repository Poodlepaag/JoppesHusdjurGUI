using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JoppesHusdjurGUI
{
    class Ball
    {
        protected int quality;
        protected string type;
        protected int ballCount;

        public Ball(int _ballCount)
        {
            ballCount = _ballCount;
            type = "Boll";
            quality = 10;
        }

        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public void LowerQuality(int lowerQualityWith)
        {
            quality = quality - lowerQualityWith;
        }

        public override string ToString()
        {
            return string.Format($"{type} {ballCount}");
        }
    }
}
