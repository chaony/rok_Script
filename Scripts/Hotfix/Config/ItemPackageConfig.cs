using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemPackageDefine
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
        /// 奖励类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 道具&参数ID
        /// </summary>
        public int typeData;

        /// <summary> 
        /// 数量
        /// </summary>
        public int number;

        /// <summary> 
        /// 随机组
        /// </summary>
        public int randomGroup;

        /// <summary> 
        /// 随机权重
        /// </summary>
        public int odds;

        /// <summary> 
        /// 文明类型限制
        /// </summary>
        public List<int> civilization_limit;

        /// <summary> 
        /// 奖励数量等级增量基础等级
        /// </summary>
        public int numberStep_lv;

        /// <summary> 
        /// 每级增量
        /// </summary>
        public int numberStep_increment;

        /// <summary> 
        /// 奖励浮动范围最小比例
        /// </summary>
        public int numberFloat_min;

        /// <summary> 
        /// 奖励浮动范围最大比例
        /// </summary>
        public int numberFloat_max;

        /// <summary> 
        /// 展示类型
        /// </summary>
        public int showType;

        /// <summary> 
        /// 奖励组图标
        /// </summary>
        public int showGroupIcon;

        /// <summary> 
        /// 来源名称语言包
        /// </summary>
        public int rewardSrcName;

    }
}