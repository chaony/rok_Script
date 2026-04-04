using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceDonateRankingDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 排名区间低
        /// </summary>
        public int targetMin;

        /// <summary> 
        /// 排名区间高
        /// </summary>
        public int targetMax;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

    }
}