using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroDefine
    {
        /// <summary> 
        /// 英雄ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 所属文明
        /// </summary>
        public int civilization;

        /// <summary> 
        /// 称号语言包
        /// </summary>
        public int l_appellationID;

        /// <summary> 
        /// 初始星级
        /// </summary>
        public int initStar;

        /// <summary> 
        /// 星级上限
        /// </summary>
        public int star;

        /// <summary> 
        /// 稀有度
        /// </summary>
        public int rare;

        /// <summary> 
        /// 英雄描述语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 基础战力
        /// </summary>
        public int score;

        /// <summary> 
        /// 招募所需道具
        /// </summary>
        public int getItem;

        /// <summary> 
        /// 招募所需道具数量
        /// </summary>
        public int getItemNum;

        /// <summary> 
        /// 招募所需道具兑换,0=不可以
        /// </summary>
        public int exchange;

        /// <summary> 
        /// 英雄特色语言语言包
        /// </summary>
        public List<int> l_heroLanguage;

        /// <summary> 
        /// 解锁天数条件
        /// </summary>
        public int getLimit;

        /// <summary> 
        /// 技能
        /// </summary>
        public List<int> skill;

        /// <summary> 
        /// 天赋
        /// </summary>
        public List<int> talent;

        /// <summary> 
        /// 是否显示在英雄列表中,1=不显示
        /// </summary>
        public int listDisplay;

        /// <summary> 
        /// 英雄头像
        /// </summary>
        public string heroIcon;

        /// <summary> 
        /// 英雄模型
        /// </summary>
        public string heroModel;

        /// <summary> 
        /// 序列帧动画
        /// </summary>
        public string heroAction;

        /// <summary> 
        /// 英雄场景
        /// </summary>
        public string heroScene;

        /// <summary> 
        /// 英雄场景召唤镜头
        /// </summary>
        public List<float> heroScenePoint;

        /// <summary> 
        /// 开场白语音
        /// </summary>
        public string voiceOpening;

        /// <summary> 
        /// 选中语音
        /// </summary>
        public string voiceSelect;

        /// <summary> 
        /// 移动语音
        /// </summary>
        public string voiceMove;

        public float heroLocationPoint1;

        public float heroLocationPoint2;

        public float heroScale;

    }
}