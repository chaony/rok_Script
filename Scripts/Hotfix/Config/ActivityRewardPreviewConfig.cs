using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityRewardPreviewDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 服务类型
        /// </summary>
        public int openServiceType;

        /// <summary> 
        /// 预览类型
        /// </summary>
        public int rewardPreview;

    }
}