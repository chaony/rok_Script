using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceOfficiallyDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_officiallyID;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 加成语言包
        /// </summary>
        public int l_addDesID;

        /// <summary> 
        /// 语言包解析
        /// </summary>
        public List<int> addDesData;

        /// <summary> 
        /// 加成
        /// </summary>
        public List<string> add;

        public List<attrType> addAtt;

        /// <summary> 
        /// 加成解析
        /// </summary>
        public List<int> addData;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

    }
}