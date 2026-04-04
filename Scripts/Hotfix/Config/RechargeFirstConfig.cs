using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeFirstDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 前置活动
        /// </summary>
        public int frontID;

        /// <summary> 
        /// 后置活动
        /// </summary>
        public int nextID;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 商品价格索引
        /// </summary>
        public int price;

        /// <summary> 
        /// 需求宝石
        /// </summary>
        public int needDenar;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 关联vip
        /// </summary>
        public int vipSpecialBox;

        /// <summary> 
        /// 模型展示
        /// </summary>
        public int heroShow;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 礼包价值
        /// </summary>
        public int giftValue;

        /// <summary> 
        /// 背景图
        /// </summary>
        public string background;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

        /// <summary> 
        /// 跳转类型
        /// </summary>
        public int jumpType;

    }
}