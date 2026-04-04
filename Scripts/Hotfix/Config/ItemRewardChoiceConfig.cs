using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemRewardChoiceDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 显示的物品ID
        /// </summary>
        public int item;

        /// <summary> 
        /// 显示的数量
        /// </summary>
        public int num;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int reward;

    }
}