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

        public void LowerQuality(int lowerQualityWith)
        {
            quality = quality - lowerQualityWith;
        }

        public int Quality()
        {
            return quality;
        }

        public override string ToString()
        {
            return string.Format($"{type} {ballCount}");
        }
    }
}
