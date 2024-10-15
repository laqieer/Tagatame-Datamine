// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMailSelectConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200153A")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Mail/ReqMailSelectConceptCard", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_ReqMailSelectConceptCard : FlowNode_Network
  {
    [Token(Token = "0x4004D9B")]
    [FieldOffset(Offset = "0x20")]
    public GetConceptCardListWindow m_GetConceptCardListWindow;

    [Token(Token = "0x60057D5")]
    [Address(RVA = "0x12D4E10", Offset = "0x12D3C10", VA = "0x112D4E10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057D6")]
    [Address(RVA = "0x12D4F70", Offset = "0x12D3D70", VA = "0x112D4F70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057D7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMailSelectConceptCard()
    {
    }

    [Token(Token = "0x200153B")]
    public class Json
    {
      [Token(Token = "0x4004D9C")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqMailSelectConceptCard.Json_SelectConceptCard[] select;

      [Token(Token = "0x60057D8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }

    [Token(Token = "0x200153C")]
    public class Json_SelectConceptCard
    {
      [Token(Token = "0x4004D9D")]
      [FieldOffset(Offset = "0x8")]
      public long id;
      [Token(Token = "0x4004D9E")]
      [FieldOffset(Offset = "0x10")]
      public string iname;
      [Token(Token = "0x4004D9F")]
      [FieldOffset(Offset = "0x14")]
      public int has_count;

      [Token(Token = "0x60057D9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_SelectConceptCard()
      {
      }
    }
  }
}
