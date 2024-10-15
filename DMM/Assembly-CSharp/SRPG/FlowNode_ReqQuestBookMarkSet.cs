// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestBookMarkSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001309")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Bookmark/Req/QuestBookMarkSet", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqQuestBookMarkSet : FlowNode_Network
  {
    [Token(Token = "0x40046A2")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046A3")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005057")]
    [Address(RVA = "0x1263500", Offset = "0x1262300", VA = "0x11263500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005058")]
    [Address(RVA = "0x1263890", Offset = "0x1262690", VA = "0x11263890")]
    private void Success()
    {
    }

    [Token(Token = "0x6005059")]
    [Address(RVA = "0x1263690", Offset = "0x1262490", VA = "0x11263690", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600505A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestBookMarkSet()
    {
    }
  }
}
