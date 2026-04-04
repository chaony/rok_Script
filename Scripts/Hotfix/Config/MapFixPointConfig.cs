using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapFixPointDefine
    {
        /// <summary> 
        /// 系统编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 坐标X
        /// </summary>
        public int posX;

        /// <summary> 
        /// 坐标Y
        /// </summary>
        public int posY;

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

    }
}