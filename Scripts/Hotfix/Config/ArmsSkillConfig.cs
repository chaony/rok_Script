using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ArmsSkillDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_skillID;

        /// <summary> 
        /// 技能描述，索引helpTips表ID
        /// </summary>
        public int tipsID;

        /// <summary> 
        /// 技能图标
        /// </summary>
        public string skillIcon;

        /// <summary> 
        /// 兵种克制参数
        /// </summary>
        public List<string> restraintCofig;

        /// <summary> 
        /// 兵种克制参数解析
        /// </summary>
        public List<int> restraintData;

    }
}