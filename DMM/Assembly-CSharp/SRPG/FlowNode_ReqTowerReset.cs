// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTowerReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015BF")]
  [FlowNode.NodeType("Tower/Req/ReqTowerReset", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTowerReset : FlowNode_Network
  {
    [Token(Token = "0x4004F23")]
    [FieldOffset(Offset = "0x20")]
    private long rtime;
    [Token(Token = "0x4004F24")]
    [FieldOffset(Offset = "0x28")]
    private byte round;

    [Token(Token = "0x600597A")]
    [Address(RVA = "0x12E1460", Offset = "0x12E0260", VA = "0x112E1460", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600597B")]
    [Address(RVA = "0x12E1930", Offset = "0x12E0730", VA = "0x112E1930")]
    private void Success()
    {
    }

    [Token(Token = "0x600597C")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x600597D")]
    [Address(RVA = "0x12E15C0", Offset = "0x12E03C0", VA = "0x112E15C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600597E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTowerReset()
    {
    }

    [Token(Token = "0x20015C0")]
    public class Json_ReqTowerReset
    {
      [Token(Token = "0x4004F25")]
      [FieldOffset(Offset = "0x8")]
      public long rtime;
      [Token(Token = "0x4004F26")]
      [FieldOffset(Offset = "0x10")]
      public byte round;
      [Token(Token = "0x4004F27")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ReqTowerResuponse.Json_RankStatus rank;
      [Token(Token = "0x4004F28")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ReqTowerResuponse.Json_UserCoin coin;

      [Token(Token = "0x600597F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ReqTowerReset()
      {
      }
    }
  }
}
