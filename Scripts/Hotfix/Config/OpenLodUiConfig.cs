using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class OpenLodUiDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 界面模块名称
        /// </summary>
        public string uiName;

        /// <summary> 
        /// 界面模块预制
        /// </summary>
        public string uiId;

        /// <summary> 
        /// 内城级
        /// </summary>
        public int City;

        /// <summary> 
        /// 外城1级
        /// </summary>
        public int Tactical;

        /// <summary> 
        /// 外城2级
        /// </summary>
        public int TacticsToStrategy_1;

        /// <summary> 
        /// 外城3级
        /// </summary>
        public int TacticsToStrategy_2;

        /// <summary> 
        /// 战略（预览）级
        /// </summary>
        public int Strategic;

        /// <summary> 
        /// 王国级
        /// </summary>
        public int NationWide;

        /// <summary> 
        /// 大陆级
        /// </summary>
        public int Continental;

        /// <summary> 
        /// 默认窗口
        /// </summary>
        public int openWinDefault;

        /// <summary> 
        /// 选择部队与斥候窗口
        /// </summary>
        public int openWinCreateTroops;

        /// <summary> 
        /// 搜索窗口
        /// </summary>
        public int openWinSearch;

        /// <summary> 
        /// NPC对话窗口
        /// </summary>
        public int openWinNpcDialog;

        /// <summary> 
        /// 默认动画
        /// </summary>
        public string Animator;

        /// <summary> 
        /// 显示条件（新手引导步骤）
        /// </summary>
        public int guideStage;

        /// <summary> 
        /// 非阿语动画
        /// </summary>
        public string unArbAnimator;

        /// <summary> 
        /// 时代变化显示
        /// </summary>
        public int ageUpdate;

    }
}