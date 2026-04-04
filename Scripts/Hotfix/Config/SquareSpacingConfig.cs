using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SquareSpacingDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 朝向
        /// </summary>
        public int towards;

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 间距间距需计算前+后的距离，最前排离边缘需要有个距离+后排距离+后排前方距离才等于 0 和1 的距离
        /// </summary>
        public float spacing;

    }
}