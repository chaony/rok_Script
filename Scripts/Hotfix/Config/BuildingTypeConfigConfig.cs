using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingTypeConfigDefine
    {
        /// <summary> 
        /// 建筑类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int type  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 建筑分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 是否可移动
        /// </summary>
        public int isMove;

        /// <summary> 
        /// 列表TIPS编号
        /// </summary>
        public int tipList;

        /// <summary> 
        /// 建筑描述
        /// </summary>
        public int l_descId;

        /// <summary> 
        /// 建筑简述
        /// </summary>
        public int l_descId2;

        /// <summary> 
        /// 菜单按钮列表
        /// </summary>
        public List<int> menuButtons;

        /// <summary> 
        /// 长度
        /// </summary>
        public int width;

        /// <summary> 
        /// 宽度
        /// </summary>
        public int length;

    }
}