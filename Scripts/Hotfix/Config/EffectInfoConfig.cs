using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EffectInfoDefine
    {
        /// <summary> 
        /// 技能ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int skillID  { get; set; }

        /// <summary> 
        /// ID  - 具体特效的名称，唯一索引
        /// </summary>
        public string effectID;

        /// <summary> 
        /// 特效结束时间，程序根据此时间移除特效，单位秒 99 为循环播放不移除
        /// </summary>
        public float endTime;

        /// <summary> 
        /// 事件触发条件（配置值/100）秒，用于配置特效扣血时间
        /// </summary>
        public float key;

        /// <summary> 
        /// 特效挂载点位置 在建筑单位底下增加挂载点以匹配不同的建筑。effect-∞
        /// </summary>
        public string effectLocation;

        /// <summary> 
        /// 用于挂载不同范围的提示区域
        /// </summary>
        public string effectArea;

        /// <summary> 
        /// 特效音效
        /// </summary>
        public string sound;

        /// <summary> 
        /// 是否投掷
        /// </summary>
        public int beAttacked;

    }
}