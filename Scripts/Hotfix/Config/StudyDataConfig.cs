using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class StudyDataDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 科技ID
        /// </summary>
        public int studyID;

        /// <summary> 
        /// 文明ID
        /// </summary>
        public int civilizationID;

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_studyNameID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

    }
}