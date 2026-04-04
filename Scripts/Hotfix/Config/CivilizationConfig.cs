using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CivilizationDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_civilizationID;

        /// <summary> 
        /// 文明名称颜色
        /// </summary>
        public string civilizationColour;

        /// <summary> 
        /// 语言包ID
        /// </summary>
        public int l_addNameID;

        /// <summary> 
        /// 加成语言包ID
        /// </summary>
        public int l_addDesID;

        /// <summary> 
        /// 加成描述解析
        /// </summary>
        public List<int> addData;

        /// <summary> 
        /// 文明加成
        /// </summary>
        public List<string> civilizationAdd;

        /// <summary> 
        /// 文明加成
        /// </summary>
        public List<attrType> civilizationAddNew;

        /// <summary> 
        /// 加成解析
        /// </summary>
        public List<int> civilizationAddData;

        /// <summary> 
        /// 初始统帅
        /// </summary>
        public int initialHero;

        /// <summary> 
        /// 特色兵种
        /// </summary>
        public List<int> featureArms;

        /// <summary> 
        /// 创角界面统帅展示资源
        /// </summary>
        public string heroRes;

        /// <summary> 
        /// 文明旗帜
        /// </summary>
        public string civilizationFlag;

        /// <summary> 
        /// 文明标签
        /// </summary>
        public string civilizationMark;

        /// <summary> 
        /// 标签颜色
        /// </summary>
        public string markColour;

        /// <summary> 
        /// 缩略图展示,修改为统帅图片形象
        /// </summary>
        public string cityShow;

        /// <summary> 
        /// 背景图展示
        /// </summary>
        public string background;

        /// <summary> 
        /// 特色兵种展示资源
        /// </summary>
        public string featureArmsShow;

        /// <summary> 
        /// 底纹资源
        /// </summary>
        public string shading;

        /// <summary> 
        /// 底板颜色
        /// </summary>
        public string floorColour;

        /// <summary> 
        /// 是否显示
        /// </summary>
        public int ifShow;

        /// <summary> 
        /// 是否锁定
        /// </summary>
        public int ifLock;

        /// <summary> 
        /// 医院标记显示
        /// </summary>
        public int hospitalMark;

        /// <summary> 
        /// 创角界面背景音乐
        /// </summary>
        public string bgm;

        /// <summary> 
        /// 角色头像
        /// </summary>
        public string playerImg;

        /// <summary> 
        /// 特色兵种展示名称
        /// </summary>
        public int armsName;

        /// <summary> 
        /// 创角界面SD动画左右偏移量（x轴坐标便偏移）
        /// </summary>
        public float aboutOffset;

        /// <summary> 
        /// 显示排序
        /// </summary>
        public int rank;

    }
}