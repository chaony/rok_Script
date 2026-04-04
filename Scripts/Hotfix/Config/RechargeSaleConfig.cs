using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeSaleDefine
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
        /// 礼包组
        /// </summary>
        public int group;

        /// <summary> 
        /// 档位
        /// </summary>
        public int gears;

        /// <summary> 
        /// 商品价格索引
        /// </summary>
        public int price;

        /// <summary> 
        /// 礼包类型
        /// </summary>
        public int giftType;

        /// <summary> 
        /// 参数1
        /// </summary>
        public string data1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int data2;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID1;

        /// <summary> 
        /// 文本解析
        /// </summary>
        public int desData1;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID2;

        /// <summary> 
        /// 文本解析
        /// </summary>
        public int desData2;

        /// <summary> 
        /// 打折标签语言包ID
        /// </summary>
        public int l_discountID;

        /// <summary> 
        /// 解析
        /// </summary>
        public int discountData;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_labelID;

        /// <summary> 
        /// 底图
        /// </summary>
        public string background;

        /// <summary> 
        /// 横幅颜色配置
        /// </summary>
        public string bannerColour;

        /// <summary> 
        /// 底板使用资源
        /// </summary>
        public string baseRes;

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