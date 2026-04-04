using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceMemberJurisdictionDefine
    {
        /// <summary> 
        /// 类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int type  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_typeID;

        /// <summary> 
        /// R1玩家权限
        /// </summary>
        public int R1;

        /// <summary> 
        /// R2玩家权限
        /// </summary>
        public int R2;

        /// <summary> 
        /// R3玩家权限
        /// </summary>
        public int R3;

        /// <summary> 
        /// R4玩家权限
        /// </summary>
        public int R4;

        /// <summary> 
        /// 盟主
        /// </summary>
        public int R5;

    }
}