using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceSignDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 展示图片资源
        /// </summary>
        public string showIcon;

        /// <summary> 
        /// 实际使用图标资源
        /// </summary>
        public string realityIcon;

        /// <summary> 
        /// 颜色
        /// </summary>
        public string colour;

    }
}