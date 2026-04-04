using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class PriceDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包id
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 价格，美元
        /// </summary>
        public float price;

        /// <summary> 
        /// 充值类型
        /// </summary>
        public int rechargeType;

        /// <summary> 
        /// 对应表ID
        /// </summary>
        public int rechargeTypeID;

        /// <summary> 
        /// 商品id
        /// </summary>
        public int rechargeID;

        /// <summary> 
        /// 商品购买成功后的提示语
        /// </summary>
        public int l_succeededID;

    }
}