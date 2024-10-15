// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFirstChargeBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014ED")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Failue", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/ReqFirstChargeBonus", 32741)]
  public class FlowNode_ReqFirstChargeBonus : FlowNode_Network
  {
    [Token(Token = "0x4004CAB")]
    public const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004CAC")]
    public const int PIN_OT_SUCCESS = 10;
    [Token(Token = "0x4004CAD")]
    public const int PIN_OT_FAILURE = 11;

    [Token(Token = "0x6005706")]
    [Address(RVA = "0x12C73B0", Offset = "0x12C61B0", VA = "0x112C73B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005707")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005708")]
    [Address(RVA = "0x12C7460", Offset = "0x12C6260", VA = "0x112C7460", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005709")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFirstChargeBonus()
    {
    }

    [Token(Token = "0x20014EE")]
    [Serializable]
    public class Json
    {
      [Token(Token = "0x4004CAE")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqFirstChargeBonus.Reward[] rewards;

      [Token(Token = "0x600570A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }

    [Token(Token = "0x20014EF")]
    public class Reward
    {
      [Token(Token = "0x4004CAF")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4004CB0")]
      [FieldOffset(Offset = "0xC")]
      public string type;
      [Token(Token = "0x4004CB1")]
      [FieldOffset(Offset = "0x10")]
      public int num;

      [Token(Token = "0x600570B")]
      [Address(RVA = "0x12C83B0", Offset = "0x12C71B0", VA = "0x112C83B0")]
      public GiftTypes GetGiftType() => new GiftTypes();

      [Token(Token = "0x600570C")]
      [Address(RVA = "0x12C8520", Offset = "0x12C7320", VA = "0x112C8520")]
      public Reward()
      {
      }
    }
  }
}
