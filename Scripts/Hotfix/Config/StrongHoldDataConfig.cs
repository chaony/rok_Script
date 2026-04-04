using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class StrongHoldDataDefine
    {
        /// <summary> 
        /// 系统流水
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 奇观建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 建筑坐标X
        /// </summary>
        public float posX;

        /// <summary> 
        /// 建筑坐标Y
        /// </summary>
        public float posY;

        /// <summary> 
        /// 建筑朝向
        /// </summary>
        public int posTo;

        /// <summary> 
        /// 连通省份1
        /// </summary>
        public int province1;

        /// <summary> 
        /// 省份1落脚坐标
        /// </summary>
        public int posX1;

        /// <summary> 
        /// 省份1落脚坐标
        /// </summary>
        public int posY1;

        /// <summary> 
        /// 连通省份2
        /// </summary>
        public int province2;

        /// <summary> 
        /// 省份2落脚坐标
        /// </summary>
        public int posX2;

        /// <summary> 
        /// 省份2落脚坐标
        /// </summary>
        public int posY2;

        /// <summary> 
        /// 怪物组编号
        /// </summary>
        public int monsterPointGroup;

    }
}