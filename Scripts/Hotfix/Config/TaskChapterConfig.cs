using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TaskChapterDefine
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
        /// 所属章节编号
        /// </summary>
        public int chapterId;

        /// <summary> 
        /// 任务图标
        /// </summary>
        public string iconImg;

    }
}