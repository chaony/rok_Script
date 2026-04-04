using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingScoutcampDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 斥候营地等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 斥候行军速度提升(千分比）
        /// </summary>
        public int scoutSpeedMulti;

        /// <summary> 
        /// 斥候数量
        /// </summary>
        public int scoutNumber;

        /// <summary> 
        /// 探索范围
        /// </summary>
        public int scoutView;

        /// <summary> 
        /// 侦察资源类型1
        /// </summary>
        public int costCurrencyType1;

        /// <summary> 
        /// 消耗数量1
        /// </summary>
        public int number1;

        /// <summary> 
        /// 侦察资源类型2
        /// </summary>
        public int costCurrencyType2;

        /// <summary> 
        /// 消耗数量2
        /// </summary>
        public int number2;

    }
}