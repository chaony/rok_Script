using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceGiftRewardDefine
    {
        /// <summary> 
        /// 系统流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 礼物宝箱类型
        /// </summary>
        public int giftType;

        /// <summary> 
        /// 礼物等级
        /// </summary>
        public int giftLevel;

        /// <summary> 
        /// 对应奖励组ID
        /// </summary>
        public int reward;

        /// <summary> 
        /// 礼物点数
        /// </summary>
        public int giftPoint;

        /// <summary> 
        /// 钥匙点数
        /// </summary>
        public int keyPoint;

    }
}