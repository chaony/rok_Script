using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityDropTypeDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int activityType;

        /// <summary> 
        /// 玩家行为
        /// </summary>
        public int playerBehavior;

        /// <summary> 
        /// 参数
        /// </summary>
        public int data0;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 语言包id
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

        /// <summary> 
        /// 跳转类型
        /// </summary>
        public int jumpType;

        /// <summary> 
        /// 是否发奖
        /// </summary>
        public int award;

    }
}