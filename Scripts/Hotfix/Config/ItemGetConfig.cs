using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemGetDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 途径图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 功能开启类型
        /// </summary>
        public int openType;

        /// <summary> 
        /// 功能开启参数
        /// </summary>
        public int openData;

        /// <summary> 
        /// 前往跳转界面
        /// </summary>
        public int openUi;

        /// <summary> 
        /// 是否需要返回主界面,1=是
        /// </summary>
        public int closeUi;

    }
}