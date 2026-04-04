using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class GuideDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 阶段
        /// </summary>
        public int stage;

        /// <summary> 
        /// 步骤
        /// </summary>
        public int step;

        /// <summary> 
        /// 触发参数
        /// </summary>
        public string trigger;

        /// <summary> 
        /// 引导界面ID
        /// </summary>
        public int uiId;

        /// <summary> 
        /// 引导UI组件类型
        /// </summary>
        public int uiType;

        /// <summary> 
        /// 节点路径
        /// </summary>
        public string path;

        /// <summary> 
        /// list项索引
        /// </summary>
        public int listIndex;

        /// <summary> 
        /// 查找方式
        /// </summary>
        public int findWay;

        /// <summary> 
        /// 引导节点
        /// </summary>
        public string guideNode;

        /// <summary> 
        /// 引导节点类型
        /// </summary>
        public int guideNodeType;

        /// <summary> 
        /// 引导特效挂点
        /// </summary>
        public string guideEffectPos;

        /// <summary> 
        /// 引导箭头方向
        /// </summary>
        public int guideArrowhead;

        /// <summary> 
        /// 引导箭头方向(阿语）
        /// </summary>
        public int guideArrowheadAr;

        /// <summary> 
        /// 引导剧情
        /// </summary>
        public int guideDialog;

        /// <summary> 
        /// tips语言包
        /// </summary>
        public int l_guideTipsID;

        /// <summary> 
        /// 引导过程显示的UI
        /// </summary>
        public List<int> showUi;

        /// <summary> 
        /// tips方向
        /// </summary>
        public int guideTipsPos;

        /// <summary> 
        /// tips方向（阿语）
        /// </summary>
        public int guideTipsPosAr;

        /// <summary> 
        /// 客户端语言环境
        /// </summary>
        public List<int> languageSet;

        /// <summary> 
        /// 语言版本音效
        /// </summary>
        public List<string> soundClient;

        /// <summary> 
        /// 音效
        /// </summary>
        public string sound;

        /// <summary> 
        /// 文明
        /// </summary>
        public List<int> civilization;

        /// <summary> 
        /// 文明音效
        /// </summary>
        public List<string> heroSound;

        /// <summary> 
        /// 区域引导
        /// </summary>
        public int guideArena;

    }
}