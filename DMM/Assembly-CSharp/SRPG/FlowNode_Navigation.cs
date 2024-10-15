// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Navigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200143A")]
  [FlowNode.NodeType("UI/Navigation", 32741)]
  [FlowNode.Pin(1, "Show", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Discard", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(11, "Destory", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  public class FlowNode_Navigation : FlowNode
  {
    [Token(Token = "0x4004AE1")]
    [FieldOffset(Offset = "0x18")]
    public NavigationWindow Template;
    [Token(Token = "0x4004AE2")]
    [FieldOffset(Offset = "0x1C")]
    public string TemplatePath;
    [Token(Token = "0x4004AE3")]
    [FieldOffset(Offset = "0x20")]
    [StringIsTextID(false)]
    public string TextID;
    [Token(Token = "0x4004AE4")]
    [FieldOffset(Offset = "0x24")]
    public NavigationWindow.Alignment Alignment;
    [Token(Token = "0x4004AE5")]
    [FieldOffset(Offset = "0x0")]
    private static NavigationWindow m_Template;

    [Token(Token = "0x600546C")]
    [Address(RVA = "0x1290EB0", Offset = "0x128FCB0", VA = "0x11290EB0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600546D")]
    [Address(RVA = "0x1290CA0", Offset = "0x128FAA0", VA = "0x11290CA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600546E")]
    [Address(RVA = "0x1290B40", Offset = "0x128F940", VA = "0x11290B40")]
    private void LoadTemplate(string path)
    {
    }

    [Token(Token = "0x600546F")]
    [Address(RVA = "0x1290ED0", Offset = "0x128FCD0", VA = "0x11290ED0")]
    public FlowNode_Navigation()
    {
    }
  }
}
