using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityEndHandingDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int activityType;

        /// <summary> 
        /// 兑换道具
        /// </summary>
        public int conversionItem;

        /// <summary> 
        /// 数量
        /// </summary>
        public int conversionNum;

        /// <summary> 
        /// 补偿道具
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 邮件
        /// </summary>
        public int mailID;

        /// <summary> 
        /// 邮件
        /// </summary>
        public int mailActivity;

    }
}