﻿namespace ITXCM
{
    public class MessageDispatch<T> : Singleton<MessageDispatch<T>>
    {
        /// <summary>
        /// 响应协议分发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        public void Dispatch(T sender, SkillBridge.Message.NetMessageResponse message)
        {
            if (message.testResponseProto != null) { MessageDistributer<T>.Instance.RaiseEvent(sender, message.testResponseProto); }
        }

        /// <summary>
        /// 请求协议分发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        public void Dispatch(T sender, SkillBridge.Message.NetMessageRequest message)
        {
            if (message.testRequestProto != null) { MessageDistributer<T>.Instance.RaiseEvent(sender, message.testRequestProto); }
        }
    }
}