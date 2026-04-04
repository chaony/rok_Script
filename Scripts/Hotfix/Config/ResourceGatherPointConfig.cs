using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ResourceGatherPointDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 资源点坐标X
        /// </summary>
        public int posX;

        /// <summary> 
        /// 资源点坐标Y
        /// </summary>
        public int posY;

    }
}