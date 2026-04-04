using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroSkillEffectDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 增加战力
        /// </summary>
        public int score;

        /// <summary> 
        /// 属性类型（客户端）
        /// </summary>
        public List<attrType> attrTypeNew;

        /// <summary> 
        /// 属性类型（服务端）
        /// </summary>
        public List<string> attrType;

        /// <summary> 
        /// 属性值
        /// </summary>
        public List<int> attrNumber;

    }
}