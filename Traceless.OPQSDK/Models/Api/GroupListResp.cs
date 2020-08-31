﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Traceless.OPQSDK.Models.Api
{
    /// <summary>
    /// 群列表返回
    /// </summary>
    public class GroupListResp
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 下次请求token
        /// </summary>
        public string NextToken { get; set; }

        public Trooplist[] TroopList { get; set; }
    }

    public class Trooplist
    {
        /// <summary>
        /// 群号
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// 群成员数量
        /// </summary>
        public int GroupMemberCount { get; set; }

        /// <summary>
        /// 群名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 入群公告
        /// </summary>
        public string GroupNotice { get; set; }

        /// <summary>
        /// 群主
        /// </summary>
        public long GroupOwner { get; set; }

        /// <summary>
        /// 群人数上限
        /// </summary>
        public int GroupTotalCount { get; set; }
    }
}