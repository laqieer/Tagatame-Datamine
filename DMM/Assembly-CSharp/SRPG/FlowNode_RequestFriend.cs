// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015C6")]
  [FlowNode.Pin(13, "Failed(フレンドorブロック)", FlowNode.PinTypes.Output, 13)]
  [FlowNode.NodeType("System/Friend/RequestFriend", 32741)]
  [FlowNode.Pin(2, "自分のフレンドリスト上限", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "相手のフレンドリスト上限", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(4, "存在しないプレイヤーを指定した", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(5, "一括申請Request", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(6, "すでにフレンド", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(7, "すでに申請を出している", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(10, "Request無し", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Success(ブロックリスト申請のみ)", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Success(フレンド申請&ブロックリスト申請)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_RequestFriend : FlowNode_Network
  {
    [Token(Token = "0x4004F2E")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004F2F")]
    private const int PIN_OT_SUCCESS_FRIEND_ADD = 1;
    [Token(Token = "0x4004F30")]
    private const int PIN_OT_ERR_REQ_FRIEND_REQUEST_MAX = 2;
    [Token(Token = "0x4004F31")]
    private const int PIN_OT_ERR_REQ_FRIEND_IS_FULL = 3;
    [Token(Token = "0x4004F32")]
    private const int PIN_OT_ERR_NOT_PLAYER = 4;
    [Token(Token = "0x4004F33")]
    private const int PIN_IN_REQUEST_ALL = 5;
    [Token(Token = "0x4004F34")]
    private const int PIN_OT_ERR_REQ_FRIEND_REGISTERED = 6;
    [Token(Token = "0x4004F35")]
    private const int PIN_OT_ERR_REQ_FRIEND_REQUESTING = 7;
    [Token(Token = "0x4004F36")]
    private const int PIN_OT_SUCCESS_NOT_REQUEST = 10;
    [Token(Token = "0x4004F37")]
    private const int PIN_OT_SUCCESS_BLOCKLIST_ADD = 11;
    [Token(Token = "0x4004F38")]
    private const int PIN_OT_SUCCESS_FRIEND_BLOCK_ADD = 12;
    [Token(Token = "0x4004F39")]
    private const int PIN_OT_FAILED_FRIEND_BLOCK_ADD = 13;
    [Token(Token = "0x4004F3A")]
    [FieldOffset(Offset = "0x20")]
    private int apiType;

    [Token(Token = "0x6005991")]
    [Address(RVA = "0x12E9650", Offset = "0x12E8450", VA = "0x112E9650", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005992")]
    [Address(RVA = "0x12EA190", Offset = "0x12E8F90", VA = "0x112EA190")]
    private void Success()
    {
    }

    [Token(Token = "0x6005993")]
    [Address(RVA = "0x12E9630", Offset = "0x12E8430", VA = "0x112E9630")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005994")]
    [Address(RVA = "0x12E9C40", Offset = "0x12E8A40", VA = "0x112E9C40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005995")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RequestFriend()
    {
    }

    [Token(Token = "0x20015C7")]
    private enum APIType
    {
      [Token(Token = "0x4004F3C")] None,
      [Token(Token = "0x4004F3D")] Friend,
      [Token(Token = "0x4004F3E")] Block,
    }
  }
}
