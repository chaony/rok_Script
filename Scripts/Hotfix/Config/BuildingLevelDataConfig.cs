using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingLevelDataDefine
    {
        /// <summary> 
        /// 编号
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
        /// 建筑宽度
        /// </summary>
        public int width;

        /// <summary> 
        /// 建筑长度
        /// </summary>
        public int length;

        /// <summary> 
        /// 前置建筑类型1
        /// </summary>
        public int reqType1;

        /// <summary> 
        /// 前置建筑等级1
        /// </summary>
        public int reqLevel1;

        /// <summary> 
        /// 前置建筑类型2
        /// </summary>
        public int reqType2;

        /// <summary> 
        /// 前置建筑等级2
        /// </summary>
        public int reqLevel2;

        /// <summary> 
        /// 前置建筑类型3
        /// </summary>
        public int reqType3;

        /// <summary> 
        /// 前置建筑等级3
        /// </summary>
        public int reqLevel3;

        /// <summary> 
        /// 粮食需求
        /// </summary>
        public int food;

        /// <summary> 
        /// 木材需求
        /// </summary>
        public int wood;

        /// <summary> 
        /// 矿石需求
        /// </summary>
        public int stone;

        /// <summary> 
        /// 金币需求
        /// </summary>
        public int coin;

        /// <summary> 
        /// 代币需求
        /// </summary>
        public int denar;

        /// <summary> 
        /// 道具需求类型
        /// </summary>
        public int itemType1;

        /// <summary> 
        /// 道具需求数量
        /// </summary>
        public int itemCnt;

        /// <summary> 
        /// 默认升级时间
        /// </summary>
        public int buildingTime;

        /// <summary> 
        /// 提供战力值
        /// </summary>
        public int power;

        /// <summary> 
        /// 减少神秘商人CD，单位秒
        /// </summary>
        public int mysteryStoreCD;

    }
}