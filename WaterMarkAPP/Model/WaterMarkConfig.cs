using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaterMarkAPP.Enums;

namespace WaterMarkAPP.Model
{
    public class WaterMarkConfig
    {
        private string _copyName;
        /// <summary>
        /// 文字水印内容
        /// </summary>
        public string CopyName
        {
            get { return _copyName; }
            set { _copyName = value; }
        }

        private string _copyImgUrl;
        /// <summary>
        /// 图片水印路径
        /// </summary>
        public string CopyImgUrl
        {
            get { return _copyImgUrl; }
            set { _copyImgUrl = value; }
        }

        private WaterMarkLocationEnum _copyLocation;
        /// <summary>
        /// 水印位置
        /// </summary>
        public WaterMarkLocationEnum CopyLocation
        {
            get { return _copyLocation; }
            set { _copyLocation = value; }
        }

        private float _copyOpacity;
        /// <summary>
        /// 水印透明度
        /// </summary>
        public float CopyOpacity
        {
            get { return _copyOpacity; }
            set { _copyOpacity = value; }
        }
    }
}
