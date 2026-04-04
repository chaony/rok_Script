using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class instantPriceDefine
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
        /// 购买数量
        /// </summary>
        public int num;

        /// <summary> 
        /// 宝石价格
        /// </summary>
        public int price;

        /// <summary> 
        /// 价格增加
        /// </summary>
        public float priceAdd;

    }
}