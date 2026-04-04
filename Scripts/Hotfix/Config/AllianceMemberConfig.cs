using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceMemberDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 成员等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 人数限制
        /// </summary>
        public int researchersLimit;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

    }
}