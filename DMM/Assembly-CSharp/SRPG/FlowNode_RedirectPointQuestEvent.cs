// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RedirectPointQuestEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A6")]
  [FlowNode.Pin(1, "Redirect", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Guild/RedirectPointQuestEvent", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "ToEventQuestTop", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(102, "NotExistPointQuest", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "ToPointQuestTop", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_RedirectPointQuestEvent : FlowNode
  {
    [Token(Token = "0x4005241")]
    private const int PIN_IN_REDIRECT = 1;
    [Token(Token = "0x4005242")]
    private const int PIN_OUT_REDIRECT_EVENTQUEST_TOP = 100;
    [Token(Token = "0x4005243")]
    private const int PIN_OUT_REDIRECT_POINTQUEST_TOP = 101;
    [Token(Token = "0x4005244")]
    private const int PIN_OUT_NOT_EXIST_POINTQUEST = 102;

    [Token(Token = "0x6005CCA")]
    [Address(RVA = "0x1308540", Offset = "0x1307340", VA = "0x11308540", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CCB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RedirectPointQuestEvent()
    {
    }
  }
}
