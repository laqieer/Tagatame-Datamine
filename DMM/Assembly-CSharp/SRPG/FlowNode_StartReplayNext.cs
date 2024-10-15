// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_StartReplayNext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200163E")]
  [FlowNode.NodeType("System/Replay/StartReplayNext", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "OK", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Cancel", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_StartReplayNext : FlowNode
  {
    [Token(Token = "0x40050C2")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x40050C3")]
    private const int PIN_OUT_OK = 101;
    [Token(Token = "0x40050C4")]
    private const int PIN_OUT_CANCEL = 102;

    [Token(Token = "0x6005B6D")]
    [Address(RVA = "0x1301400", Offset = "0x1300200", VA = "0x11301400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B6E")]
    [Address(RVA = "0x1301560", Offset = "0x1300360", VA = "0x11301560")]
    private IEnumerator PrepareAssets(QuestParam quest_param) => (IEnumerator) null;

    [Token(Token = "0x6005B6F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_StartReplayNext()
    {
    }
  }
}
