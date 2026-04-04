using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class OpenUiDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 界面名称
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 系统功能开启
        /// </summary>
        public int systemOpen;

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int buildType;

        /// <summary> 
        /// 活动开启
        /// </summary>
        public List<int> activity;

        /// <summary> 
        /// 充值开启
        /// </summary>
        public int recharge;

        /// <summary> 
        /// 礼包开启
        /// </summary>
        public int pakege;

    }
}