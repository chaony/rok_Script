using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceTreasureDefine
    {
        /// <summary> 
        /// 联盟珍藏ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 需求钥匙点数
        /// </summary>
        public int reqPoints;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int reward;

        /// <summary> 
        /// 可领取有效时长（秒）
        /// </summary>
        public int lastTime;

        /// <summary> 
        /// 宝藏图片
        /// </summary>
        public string imgShow;

    }
}