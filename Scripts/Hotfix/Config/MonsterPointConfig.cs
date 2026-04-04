using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterPointDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 怪物类型
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
        /// 怪物所属分组
        /// </summary>
        public int group;

    }
}