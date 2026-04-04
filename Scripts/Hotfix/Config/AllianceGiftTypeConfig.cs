using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceGiftTypeDefine
    {
        /// <summary> 
        /// 联盟礼包宝箱类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 描述文字
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 显示分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 是否根据礼物等级变化
        /// </summary>
        public int levelFlag;

        /// <summary> 
        /// 有效时长
        /// </summary>
        public int lastTime;

        /// <summary> 
        /// 显示图标
        /// </summary>
        public string iconImg;

    }
}