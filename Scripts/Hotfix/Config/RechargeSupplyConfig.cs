using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeSupplyDefine
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
        /// 直接给予的宝石
        /// </summary>
        public int giveGem;

        /// <summary> 
        /// 持续天数
        /// </summary>
        public int continueDays;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 描述解析
        /// </summary>
        public int desData;

        /// <summary> 
        /// 图片
        /// </summary>
        public string background;

        /// <summary> 
        /// 给与崛起之路的进度
        /// </summary>
        public int rechargeProgress;

        /// <summary> 
        /// 补发邮件
        /// </summary>
        public int mailID;

    }
}