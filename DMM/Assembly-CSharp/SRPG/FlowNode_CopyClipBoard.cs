// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CopyClipBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013B2")]
  [FlowNode.Pin(0, "コピー", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "成功", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "失敗", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("System/ClipBoard/CopyClipBoard", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_CopyClipBoard : FlowNode
  {
    [Token(Token = "0x40048E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text Target;
    [Token(Token = "0x40048EA")]
    [FieldOffset(Offset = "0x1C")]
    public string LocalizeText;

    [Token(Token = "0x600526E")]
    [Address(RVA = "0x1272FA0", Offset = "0x1271DA0", VA = "0x11272FA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600526F")]
    [Address(RVA = "0x1272E50", Offset = "0x1271C50", VA = "0x11272E50")]
    private bool CopyFrom(Text target) => new bool();

    [Token(Token = "0x6005270")]
    [Address(RVA = "0x1272F20", Offset = "0x1271D20", VA = "0x11272F20")]
    private bool CopyFrom(string text) => new bool();

    [Token(Token = "0x6005271")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CopyClipBoard()
    {
    }
  }
}
