using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceBuildingDataDefine
    {
        /// <summary> 
        /// 系统流水
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 联盟建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 第几座建筑
        /// </summary>
        public int orderNum;

        /// <summary> 
        /// 联盟粮食
        /// </summary>
        public int food;

        /// <summary> 
        /// 联盟木材
        /// </summary>
        public int wood;

        /// <summary> 
        /// 联盟石材
        /// </summary>
        public int stone;

        /// <summary> 
        /// 联盟金币
        /// </summary>
        public int coin;

        /// <summary> 
        /// 联盟积分
        /// </summary>
        public int fund;

    }
}