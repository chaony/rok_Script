using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeDailySpecialDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 商品价格索引
        /// </summary>
        public int price;

        /// <summary> 
        /// 统帅限制
        /// </summary>
        public List<int> heroLimit;

        /// <summary> 
        /// 奖励索引
        /// </summary>
        public List<int> itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 礼包价值
        /// </summary>
        public int giftValue;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 给与崛起之路的进度
        /// </summary>
        public int rechargeProgress;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

    }
}