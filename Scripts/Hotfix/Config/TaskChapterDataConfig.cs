using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TaskChapterDataDefine
    {
        /// <summary> 
        /// 章节序号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 章节标题名称
        /// </summary>
        public int l_titleNameId;

        /// <summary> 
        /// 目标简述
        /// </summary>
        public int l_descId1;

        /// <summary> 
        /// 详细描述
        /// </summary>
        public int l_descId2;

        /// <summary> 
        /// 序幕背景图
        /// </summary>
        public string preImg;

        /// <summary> 
        /// 序幕背景图
        /// </summary>
        public string prebg;

        /// <summary> 
        /// 序幕文本
        /// </summary>
        public int preText;

        /// <summary> 
        /// 序章的音效
        /// </summary>
        public string preSound;

        /// <summary> 
        /// 开启对白
        /// </summary>
        public List<int> dialogBegin;

        /// <summary> 
        /// 结束对白
        /// </summary>
        public List<int> dialogEnd;

        /// <summary> 
        /// 章节奖励
        /// </summary>
        public int reward;

        /// <summary> 
        /// 章节文明模型（作废）
        /// </summary>
        public List<string> imgCivRes;

        /// <summary> 
        /// 章节时代模型
        /// </summary>
        public List<string> imgAgeRes;

    }
}