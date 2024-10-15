// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_JumpToStoryChapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001812")]
  [FlowNode.NodeType("Story/JumpToChapter", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "Out", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_JumpToStoryChapter : FlowNode
  {
    [Token(Token = "0x4005698")]
    private const int PIN_IN_INPUT = 0;
    [Token(Token = "0x4005699")]
    private const int PIN_OUT_OUTPUT = 101;
    [Token(Token = "0x400569A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_JumpToStoryChapter.Type JumpType;
    [Token(Token = "0x400569B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private eStoryPart ChapterId;

    [Token(Token = "0x600613F")]
    [Address(RVA = "0x1359B40", Offset = "0x1358940", VA = "0x11359B40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006140")]
    [Address(RVA = "0x1359910", Offset = "0x1358710", VA = "0x11359910")]
    private void Jump()
    {
    }

    [Token(Token = "0x6006141")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_JumpToStoryChapter()
    {
    }

    [Token(Token = "0x2001813")]
    private enum Type
    {
      [Token(Token = "0x400569D")] START,
      [Token(Token = "0x400569E")] NEWEST,
    }
  }
}
