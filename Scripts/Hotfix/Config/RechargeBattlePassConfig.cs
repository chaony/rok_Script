using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeBattlePassDefine
    {
        /// <summary> 
        /// 货币ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public string l_name;

        public int price;

        /// <summary> 
        /// 货币语言包
        /// </summary>
        public int gifttype;

        /// <summary> 
        /// 对应item表子分组
        /// </summary>
        public int giftdata;

        /// <summary> 
        /// UI通货图标
        /// </summary>
        public string background;

        /// <summary> 
        /// 货币说明TIPSID
        /// </summary>
        public int discount;

        public int group;

        /// <summary> 
        /// 同组互斥
        /// </summary>
        public int mutex;

        public int rewardtype;

        public string rewardparam;

        public string rewardvalues;

    }
}