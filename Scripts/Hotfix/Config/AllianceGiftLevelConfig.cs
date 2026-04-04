using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceGiftLevelDefine
    {
        /// <summary> 
        /// 联盟礼物等级
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 升级经验
        /// </summary>
        public int exp;

        /// <summary> 
        /// 珍藏类型ID
        /// </summary>
        public int treasureId;

    }
}