using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingMenuDataDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 菜单行为
        /// </summary>
        public string func;

        /// <summary> 
        /// 菜单参数
        /// </summary>
        public int param;

        /// <summary> 
        /// 菜单参数1
        /// </summary>
        public int param1;

        /// <summary> 
        /// 非升级/研究/治疗/训练时是否显示
        /// </summary>
        public int showType1;

        /// <summary> 
        /// 升级时是否显示
        /// </summary>
        public int showType2;

        /// <summary> 
        /// 研究/治疗/训练时是否显示
        /// </summary>
        public int showType3;

        /// <summary> 
        /// 最低显示等级
        /// </summary>
        public int showLevelMin;

        /// <summary> 
        /// 最高显示等级
        /// </summary>
        public int showLevelMax;

        /// <summary> 
        /// 菜单按钮图标
        /// </summary>
        public string btnIcon;

    }
}