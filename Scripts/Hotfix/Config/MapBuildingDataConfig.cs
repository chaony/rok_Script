using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapBuildingDataDefine
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
        /// 建造速度参数1
        /// </summary>
        public int X1;

        /// <summary> 
        /// 建造速度参数2
        /// </summary>
        public int Y1;

        /// <summary> 
        /// 建造进度上限
        /// </summary>
        public int S;

        /// <summary> 
        /// 前置建筑类型1
        /// </summary>
        public int preBuilding1;

        /// <summary> 
        /// 前置建筑数量1
        /// </summary>
        public int preNum1;

        /// <summary> 
        /// 需求联盟人数
        /// </summary>
        public int playerNum;

        /// <summary> 
        /// 需求联盟总战力
        /// </summary>
        public int alliancePower;

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