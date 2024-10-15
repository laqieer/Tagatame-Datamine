// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BtlComOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200136A")]
  [FlowNode.NodeType("System/ReqBtlCom/ReqBtlComOpen", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(101, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_BtlComOpen : FlowNode_Network
  {
    [Token(Token = "0x6005170")]
    [Address(RVA = "0x1266AC0", Offset = "0x12658C0", VA = "0x11266AC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005171")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005172")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005173")]
    [Address(RVA = "0x1266C00", Offset = "0x1265A00", VA = "0x11266C00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005174")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_BtlComOpen()
    {
    }

    [Token(Token = "0x200136B")]
    public class JSON_BtlComOpenResponse
    {
      [Token(Token = "0x40047AA")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;
      [Token(Token = "0x40047AB")]
      [FieldOffset(Offset = "0xC")]
      public JSON_QuestProgress[] quests;

      [Token(Token = "0x6005175")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_BtlComOpenResponse()
      {
      }
    }
  }
}
