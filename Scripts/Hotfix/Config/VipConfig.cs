using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class VipDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 升至下级点数
        /// </summary>
        public int point;

        /// <summary> 
        /// 专属宝箱
        /// </summary>
        public int freeBox;

        /// <summary> 
        /// 特别尊享
        /// </summary>
        public int specialBox;

        /// <summary> 
        /// 特别尊享宝箱价格
        /// </summary>
        public int price;

        /// <summary> 
        /// VIP图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 补领邮件ID
        /// </summary>
        public int mailID;

        /// <summary> 
        /// 通知邮件ID
        /// </summary>
        public int noticeMail;

        /// <summary> 
        /// 特别尊享宝箱邮件
        /// </summary>
        public int specialBoxMail;

    }
}