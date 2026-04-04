using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeGemMallDefine
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
        /// 充值宝石数
        /// </summary>
        public int denarNum;

        /// <summary> 
        /// 首次购买赠送
        /// </summary>
        public int firstPresenter;

        /// <summary> 
        /// 第二次之后购买赠送
        /// </summary>
        public int presenter;

        /// <summary> 
        /// icon
        /// </summary>
        public string gemIcon;

        /// <summary> 
        /// 给与崛起之路的进度
        /// </summary>
        public int rechargeProgress;

        /// <summary> 
        /// 邮件
        /// </summary>
        public int mail;

    }
}