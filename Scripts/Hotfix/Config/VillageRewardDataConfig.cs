using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class VillageRewardDataDefine
    {
        /// <summary> 
        /// 系统编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 奖励类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 奖励参数
        /// </summary>
        public int typeData;

        /// <summary> 
        /// 奖励数量
        /// </summary>
        public int typeNum;

        /// <summary> 
        /// 需求等级
        /// </summary>
        public int reqLevel;

        /// <summary> 
        /// 概率权重
        /// </summary>
        public int chance;

        /// <summary> 
        /// 奖励描述
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 表现倍率
        /// </summary>
        public int multiple;

        /// <summary> 
        /// 倍率提示
        /// </summary>
        public int l_desc2;

    }
}