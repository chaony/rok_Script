using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TaskDialogDefine
    {
        /// <summary> 
        /// 任务ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 对白分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 分组中序号
        /// </summary>
        public int step;

        /// <summary> 
        /// 对白内容
        /// </summary>
        public int text;

        /// <summary> 
        /// 该句对话方向
        /// </summary>
        public int leftOrRight;

        /// <summary> 
        /// 对话指向NPC模型（作废）
        /// </summary>
        public string npcImg;

        /// <summary> 
        /// 按文明时代指向的模型索引
        /// </summary>
        public List<string> npcAgeModel;

        /// <summary> 
        /// 客户端语言设置
        /// </summary>
        public List<int> languageSet;

        /// <summary> 
        /// 对白语音
        /// </summary>
        public List<string> soundClient;

        /// <summary> 
        /// 对白语音(作废）
        /// </summary>
        public string heroSound;

    }
}