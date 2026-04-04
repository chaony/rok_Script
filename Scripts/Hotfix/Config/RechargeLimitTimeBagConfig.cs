using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeLimitTimeBagDefine
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
        /// 触发类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 参数1
        /// </summary>
        public int data1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int data2;

        /// <summary> 
        /// 触发限制等级区间
        /// </summary>
        public int limitLvMin;

        /// <summary> 
        /// 触发限制等级区间
        /// </summary>
        public int limitLvMax;

        /// <summary> 
        /// 礼包触发次数
        /// </summary>
        public int limitTime;

        /// <summary> 
        /// 持续时间（秒）
        /// </summary>
        public int time;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 描述解析1
        /// </summary>
        public int desData1;

        /// <summary> 
        /// 描述解析2
        /// </summary>
        public int desData2;

        /// <summary> 
        /// 背景图
        /// </summary>
        public string background;

        /// <summary> 
        /// 入口图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 入口图标底框
        /// </summary>
        public string iconBorder;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

    }
}