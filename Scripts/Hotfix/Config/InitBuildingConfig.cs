using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class InitBuildingDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 建筑等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 初始X坐标
        /// </summary>
        public int posX;

        /// <summary> 
        /// 初始Y坐标
        /// </summary>
        public int posY;

    }
}