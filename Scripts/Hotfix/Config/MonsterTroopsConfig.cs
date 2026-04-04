using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterTroopsDefine
    {
        /// <summary> 
        /// 军队构成编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 士兵构成分组
        /// </summary>
        public int troopsId;

        /// <summary> 
        /// 主将ID
        /// </summary>
        public int heroID1;

        /// <summary> 
        /// 主将星级
        /// </summary>
        public int hero1Star;

        /// <summary> 
        /// 主将等级
        /// </summary>
        public int heroLevel1;

        /// <summary> 
        /// 主将技能是否觉醒
        /// </summary>
        public int hero1AwakenSkill;

        /// <summary> 
        /// 主将技能1等级
        /// </summary>
        public int hero1SkillLevel1;

        /// <summary> 
        /// 主将技能2等级
        /// </summary>
        public int hero1SkillLevel2;

        /// <summary> 
        /// 主将技能3等级
        /// </summary>
        public int hero1SkillLevel3;

        /// <summary> 
        /// 主将技能4等级
        /// </summary>
        public int hero1SkillLevel4;

        /// <summary> 
        /// 副将ID
        /// </summary>
        public int heroID2;

        /// <summary> 
        /// 副将星级
        /// </summary>
        public int hero2Star;

        /// <summary> 
        /// 副将等级
        /// </summary>
        public int heroLevel2;

        /// <summary> 
        /// 副将技能是否觉醒
        /// </summary>
        public int hero2AwakenSkill;

        /// <summary> 
        /// 副将技能1等级
        /// </summary>
        public int hero2SkillLevel1;

        /// <summary> 
        /// 副将技能2等级
        /// </summary>
        public int hero2SkillLevel2;

        /// <summary> 
        /// 副将技能3等级
        /// </summary>
        public int hero2SkillLevel3;

        /// <summary> 
        /// 副将技能4等级
        /// </summary>
        public int hero2SkillLevel4;

        /// <summary> 
        /// 队伍加成属性类型
        /// </summary>
        public List<string> troopsAttrTypes;

        /// <summary> 
        /// 队伍加成属性值
        /// </summary>
        public List<int> troopsAttrDatas;

    }
}