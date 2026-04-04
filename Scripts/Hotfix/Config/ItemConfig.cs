using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 道具名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// tips道具名称语言包
        /// </summary>
        public int l_tipsID;

        /// <summary> 
        /// 子分组标签
        /// </summary>
        public int subType;

        /// <summary> 
        /// 功能分组
        /// </summary>
        public int type;

        /// <summary> 
        /// 功能分组语言包
        /// </summary>
        public int l_typeDes;

        /// <summary> 
        /// 类型组
        /// </summary>
        public int typeGroup;

        /// <summary> 
        /// 道具图标
        /// </summary>
        public string itemIcon;

        /// <summary> 
        /// 使用等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 品质
        /// </summary>
        public int quality;

        /// <summary> 
        /// 是否可批量使用
        /// </summary>
        public int batchUse ;

        /// <summary> 
        /// 按钮语言包
        /// </summary>
        public int l_buttonDes;

        /// <summary> 
        /// 按钮功能
        /// </summary>
        public int itemFunction;

        /// <summary> 
        /// 功能参数1
        /// </summary>
        public int data1;

        /// <summary> 
        /// 功能参数2
        /// </summary>
        public int data2;

        /// <summary> 
        /// 道具描述语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 道具描述解析0
        /// </summary>
        public int desData1;

        /// <summary> 
        /// 道具描述解析1
        /// </summary>
        public int desData2;

        /// <summary> 
        /// 图标顶部信息描述语言包
        /// </summary>
        public int l_topID;

        /// <summary> 
        /// 图标顶部信息解析
        /// </summary>
        public int topData;

        /// <summary> 
        /// 获得途径，关联itemGet表
        /// </summary>
        public List<int> get;

        /// <summary> 
        /// 快捷使用道具价格
        /// </summary>
        public int shortcutPrice;

        /// <summary> 
        /// 商城道具价格
        /// </summary>
        public int shopPrice;

        /// <summary> 
        /// 是否需要红点提示
        /// </summary>
        public int redDotPrompt;

        /// <summary> 
        /// 显示排序
        /// </summary>
        public int rank;

    }
}