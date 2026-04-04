using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class GuideDialogDefine
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
        /// 步骤
        /// </summary>
        public int step;

        /// <summary> 
        /// 剧情对白语言包
        /// </summary>
        public int l_dialogText;

        /// <summary> 
        /// 对白角色模型
        /// </summary>
        public string model;

        /// <summary> 
        /// 按文明时代指向的模型索引
        /// </summary>
        public List<string> npcAgeModel;

        /// <summary> 
        /// 对白触发额外条件
        /// </summary>
        public int delay;

        /// <summary> 
        /// 对白结束后处理
        /// </summary>
        public int dialogEvent;

        /// <summary> 
        /// 模型位置
        /// </summary>
        public string modelPos;

        /// <summary> 
        /// 模型是否镜像
        /// </summary>
        public int modelMirror;

        /// <summary> 
        /// 客户端语言设置
        /// </summary>
        public List<int> languageSet;

        /// <summary> 
        /// 语音
        /// </summary>
        public List<string> soundClient;

        /// <summary> 
        /// 语音
        /// </summary>
        public string sound;

        /// <summary> 
        /// 文明
        /// </summary>
        public List<int> civilization;

        /// <summary> 
        /// 统帅语音
        /// </summary>
        public List<string> heroSound;

    }
}