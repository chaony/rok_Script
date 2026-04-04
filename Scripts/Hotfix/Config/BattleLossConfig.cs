using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattleLossDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 进攻方重伤比例
        /// </summary>
        public int seriousInjuryProportion;

        /// <summary> 
        /// 进攻方死亡比例
        /// </summary>
        public int deathProportion;

        /// <summary> 
        /// 防守方重伤比例
        /// </summary>
        public int seriousInjuryProportionDefence;

        /// <summary> 
        /// 防守方死亡比例
        /// </summary>
        public int deathProportionDefence;

        /// <summary> 
        /// 城市援军重伤比例
        /// </summary>
        public int cityReinforceSeriousInjuryProportion;

        /// <summary> 
        /// 城市援军死亡比例
        /// </summary>
        public int cityReinforceDeathProportion;

    }
}