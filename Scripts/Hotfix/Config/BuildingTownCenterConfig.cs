using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingTownCenterDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 市政厅等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 对应时代
        /// </summary>
        public int age;

        /// <summary> 
        /// 部队容量
        /// </summary>
        public int troopsCapacity;

        /// <summary> 
        /// 工人队列数量
        /// </summary>
        public int builDqueue;

        /// <summary> 
        /// 可派遣队列数量
        /// </summary>
        public int troopsDispatchNumber;

        /// <summary> 
        /// 达成时发送邮件
        /// </summary>
        public int mail;

    }
}