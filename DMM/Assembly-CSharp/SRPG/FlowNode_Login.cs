// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Login
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001428")]
  [AddComponentMenu("")]
  [FlowNode.Pin(4, "Reset to Title", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(7, "アカウント削除済みのためログイン不可", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(5, "無期限ログイン不可", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(3, "Success To ReqBtlCom", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(6, "指定の日時までログイン不可", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(1, "Success To PlayNew", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Success To SetName", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("System/Login/Login", 32741)]
  public class FlowNode_Login : FlowNode_Network
  {
    [Token(Token = "0x6005428")]
    [Address(RVA = "0x128D230", Offset = "0x128C030", VA = "0x1128D230", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005429")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void Success()
    {
    }

    [Token(Token = "0x600542A")]
    [Address(RVA = "0x127E0C0", Offset = "0x127CEC0", VA = "0x1127E0C0")]
    private void Failure()
    {
    }

    [Token(Token = "0x600542B")]
    [Address(RVA = "0x128D410", Offset = "0x128C210", VA = "0x1128D410", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600542C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void SetUseDLC_EvalOnly(PlayerData player, bool _value)
    {
    }

    [Token(Token = "0x600542D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Login()
    {
    }

    [Token(Token = "0x2001429")]
    [MessagePackObject(true)]
    public class MP_PlayerDataAll : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004A9B")]
      [FieldOffset(Offset = "0x28")]
      public Json_PlayerDataAll body;

      [Token(Token = "0x600542F")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_PlayerDataAll()
      {
      }
    }
  }
}
