using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MailDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 邮件分页
        /// </summary>
        public int type;

        /// <summary> 
        /// 邮件类型组
        /// </summary>
        public int group;

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 副标题语言包
        /// </summary>
        public int l_subheadingID;

        /// <summary> 
        /// 邮件内容语言包
        /// </summary>
        public int l_mesID;

        /// <summary> 
        /// 附件
        /// </summary>
        public int enclosure;

        /// <summary> 
        /// 是否需要手动领取附件
        /// </summary>
        public int receiveAuto;

        /// <summary> 
        /// 领取附件后是否自动删除
        /// </summary>
        public int deleteAuto;

        /// <summary> 
        /// 发件人语言包
        /// </summary>
        public int l_senderID;

        /// <summary> 
        /// 邮件操作按钮
        /// </summary>
        public List<int> operate;

        /// <summary> 
        /// 邮件内图片
        /// </summary>
        public string image;

        /// <summary> 
        /// 邮件头像
        /// </summary>
        public string icon;

        /// <summary> 
        /// 邮件海报
        /// </summary>
        public string poster;

        /// <summary> 
        /// 邮件气泡名称语言包
        /// </summary>
        public int messageName;

        /// <summary> 
        /// 邮件气泡名称颜色
        /// </summary>
        public string messageNameColor;

        /// <summary> 
        /// 邮件气泡描述语言包
        /// </summary>
        public int message;

    }
}