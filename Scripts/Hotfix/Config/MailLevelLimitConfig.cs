using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MailLevelLimitDefine
    {
        /// <summary> 
        /// 市政厅等级
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 限制发送邮件数量
        /// </summary>
        public int mailNum;

    }
}