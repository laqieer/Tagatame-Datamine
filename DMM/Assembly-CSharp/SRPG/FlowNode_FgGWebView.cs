// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FgGWebView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013EC")]
  [FlowNode.NodeType("FgGID/FgGWebView", 32741)]
  [FlowNode.Pin(1, "Enable", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Disable", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "Finished", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_FgGWebView : FlowNode
  {
    [Token(Token = "0x40049D6")]
    private const int PIN_ID_ENABLE = 1;
    [Token(Token = "0x40049D7")]
    private const int PIN_ID_DISABLE = 2;
    [Token(Token = "0x40049D8")]
    private const int PIN_ID_FINISHED = 3;
    [Token(Token = "0x40049D9")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    [FlowNode.ShowInInfo]
    public GameObject Target;
    [Token(Token = "0x40049DA")]
    [FieldOffset(Offset = "0x1C")]
    public string URL;
    [Token(Token = "0x40049DB")]
    [FieldOffset(Offset = "0x20")]
    public RawImage mClientArea;

    [Token(Token = "0x600536A")]
    [Address(RVA = "0x12804C0", Offset = "0x127F2C0", VA = "0x112804C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600536B")]
    [Address(RVA = "0x12805E0", Offset = "0x127F3E0", VA = "0x112805E0")]
    private IEnumerator OpenURL() => (IEnumerator) null;

    [Token(Token = "0x600536C")]
    [Address(RVA = "0x12803C0", Offset = "0x127F1C0", VA = "0x112803C0")]
    private Rect GetRect() => new Rect();

    [Token(Token = "0x600536D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_FgGWebView()
    {
    }
  }
}
