using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TaskDailyDefine
    {
        /// <summary> 
        /// 任务ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 任务名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 任务描述
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 任务类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 任务参数1
        /// </summary>
        public int param1;

        /// <summary> 
        /// 任务参数2
        /// </summary>
        public int param2;

        /// <summary> 
        /// 任务目标计数
        /// </summary>
        public int require;

        /// <summary> 
        /// 任务奖励
        /// </summary>
        public int reward;

        /// <summary> 
        /// 任务在分组中排序
        /// </summary>
        public int order;

        /// <summary> 
        /// 可显示最低等级（作废）
        /// </summary>
        public int reqLevMin;

        /// <summary> 
        /// 可显示最高等级（作废）
        /// </summary>
        public int reqLevMax;

        /// <summary> 
        /// 任务图标
        /// </summary>
        public string iconImg;

        /// <summary> 
        /// 时代编号
        /// </summary>
        public List<int> age;

        /// <summary> 
        /// 积分数量
        /// </summary>
        public int score;

    }
}