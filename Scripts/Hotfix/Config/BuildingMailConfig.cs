using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingMailDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int buildingType;

        /// <summary> 
        /// 建筑等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 发送邮件ID
        /// </summary>
        public int mailID;

    }
}