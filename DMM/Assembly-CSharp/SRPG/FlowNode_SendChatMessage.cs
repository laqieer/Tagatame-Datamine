// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SendChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200160A")]
  [FlowNode.Pin(0, "メッセージ送信", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Failure", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "Interval", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(4, "スタンプ送信", FlowNode.PinTypes.Input, 4)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/ReqChat/ReqSendChatMessage", 32741)]
  public class FlowNode_SendChatMessage : FlowNode_Network
  {
    [Token(Token = "0x4004FE4")]
    [FieldOffset(Offset = "0x20")]
    private int mChannel;
    [Token(Token = "0x4004FE5")]
    [FieldOffset(Offset = "0x24")]
    private string mRoomToken;
    [Token(Token = "0x4004FE6")]
    [FieldOffset(Offset = "0x28")]
    private string mMessage;
    [Token(Token = "0x4004FE7")]
    [FieldOffset(Offset = "0x2C")]
    private int mStampId;
    [Token(Token = "0x4004FE8")]
    [FieldOffset(Offset = "0x30")]
    private ChatWindow.eChatType mTargetChatType;
    [Token(Token = "0x4004FE9")]
    [FieldOffset(Offset = "0x31")]
    private bool mIsGuildInvite;
    [Token(Token = "0x4004FEA")]
    [FieldOffset(Offset = "0x34")]
    private ChatWindow.FinishSendCallback mCallback;

    [Token(Token = "0x6005AA1")]
    [Address(RVA = "0x12F61D0", Offset = "0x12F4FD0", VA = "0x112F61D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AA2")]
    [Address(RVA = "0x12F71E0", Offset = "0x12F5FE0", VA = "0x112F71E0")]
    public void SetMessageData(
      int channle,
      string message,
      bool is_guild_invite = false,
      ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA3")]
    [Address(RVA = "0x12F7230", Offset = "0x12F6030", VA = "0x112F7230")]
    public void SetMessageData(
      string room_token,
      string message,
      ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA4")]
    [Address(RVA = "0x12F7280", Offset = "0x12F6080", VA = "0x112F7280")]
    public void SetMessageData(string message, ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA5")]
    [Address(RVA = "0x12F7330", Offset = "0x12F6130", VA = "0x112F7330")]
    public void SetStampData(int channle, int stamp_id, ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA6")]
    [Address(RVA = "0x12F72C0", Offset = "0x12F60C0", VA = "0x112F72C0")]
    public void SetStampData(
      string room_token,
      int stamp_id,
      ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA7")]
    [Address(RVA = "0x12F7300", Offset = "0x12F6100", VA = "0x112F7300")]
    public void SetStampData(int stamp_id, ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6005AA8")]
    [Address(RVA = "0x12F7180", Offset = "0x12F5F80", VA = "0x112F7180")]
    public void ResetParam()
    {
    }

    [Token(Token = "0x6005AA9")]
    [Address(RVA = "0x12F6560", Offset = "0x12F5360", VA = "0x112F6560")]
    public void ReqestSendMessage()
    {
    }

    [Token(Token = "0x6005AAA")]
    [Address(RVA = "0x12F6950", Offset = "0x12F5750", VA = "0x112F6950")]
    public void ReqestSendStamp()
    {
    }

    [Token(Token = "0x6005AAB")]
    [Address(RVA = "0x12F7370", Offset = "0x12F6170", VA = "0x112F7370")]
    private void Success()
    {
    }

    [Token(Token = "0x6005AAC")]
    [Address(RVA = "0x12F5F00", Offset = "0x12F4D00", VA = "0x112F5F00")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005AAD")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void Interval()
    {
    }

    [Token(Token = "0x6005AAE")]
    [Address(RVA = "0x12F6200", Offset = "0x12F5000", VA = "0x112F6200", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005AAF")]
    [Address(RVA = "0x12F6E00", Offset = "0x12F5C00", VA = "0x112F6E00")]
    private void RequestSendMessageToWorld(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB0")]
    [Address(RVA = "0x12F70D0", Offset = "0x12F5ED0", VA = "0x112F70D0")]
    private void RequestSendStampToWorld(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB1")]
    [Address(RVA = "0x12F6CF0", Offset = "0x12F5AF0", VA = "0x112F6CF0")]
    private void RequestSendMessageToRoom(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB2")]
    [Address(RVA = "0x12F7000", Offset = "0x12F5E00", VA = "0x112F7000")]
    private void RequestSendStampToRoom(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB3")]
    [Address(RVA = "0x12F5F60", Offset = "0x12F4D60", VA = "0x112F5F60")]
    private string[] GetRoomMemberUIDs(bool is_ignore_self = false) => (string[]) null;

    [Token(Token = "0x6005AB4")]
    [Address(RVA = "0x12F6C10", Offset = "0x12F5A10", VA = "0x112F6C10")]
    private void RequestSendMessageToGuild(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB5")]
    [Address(RVA = "0x12F6F50", Offset = "0x12F5D50", VA = "0x112F6F50")]
    private void RequestSendStampToGuild(Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x6005AB6")]
    [Address(RVA = "0x12F73E0", Offset = "0x12F61E0", VA = "0x112F73E0")]
    public FlowNode_SendChatMessage()
    {
    }
  }
}
