using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingStorageDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 仓库等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 粮食包含量
        /// </summary>
        public int foodCnt;

        /// <summary> 
        /// 木材保护量
        /// </summary>
        public int woodCnt;

        /// <summary> 
        /// 石料保护量
        /// </summary>
        public int stoneCnt;

        /// <summary> 
        /// 金币保护量
        /// </summary>
        public int goldCnt;

    }
}