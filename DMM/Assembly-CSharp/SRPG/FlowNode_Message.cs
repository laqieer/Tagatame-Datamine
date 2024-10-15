// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Message
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200142F")]
  [FlowNode.NodeType("UI/Message", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Closed", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_Message : FlowNode
  {
    [Token(Token = "0x4004AB4")]
    [FieldOffset(Offset = "0x18")]
    public string Text;
    [Token(Token = "0x4004AB5")]
    [FieldOffset(Offset = "0x1C")]
    public bool systemModal;
    [Token(Token = "0x4004AB6")]
    [FieldOffset(Offset = "0x20")]
    public int systemModalPriority;
    [Token(Token = "0x4004AB7")]
    [FieldOffset(Offset = "0x24")]
    public GameObject parent;
    [Token(Token = "0x4004AB8")]
    [FieldOffset(Offset = "0x28")]
    public string parentName;
    [Token(Token = "0x4004AB9")]
    [FieldOffset(Offset = "0x2C")]
    public bool unscaledTime;
    [Token(Token = "0x4004ABA")]
    [FieldOffset(Offset = "0x2D")]
    public bool richTag;
    [Token(Token = "0x4004ABB")]
    [FieldOffset(Offset = "0x2E")]
    public bool anim;
    [Token(Token = "0x4004ABC")]
    [FieldOffset(Offset = "0x2F")]
    public bool input;
    [Token(Token = "0x4004ABD")]
    [FieldOffset(Offset = "0x30")]
    public float bgAlpha;
    [Token(Token = "0x4004ABE")]
    [FieldOffset(Offset = "0x34")]
    public float autoClose;
    [Token(Token = "0x4004ABF")]
    [FieldOffset(Offset = "0x38")]
    public TextAnchor textAnchor;
    [Token(Token = "0x4004AC0")]
    [FieldOffset(Offset = "0x3C")]
    private Win_SysMessage_Flx m_Window;

    [Token(Token = "0x600544A")]
    [Address(RVA = "0x128FBA0", Offset = "0x128E9A0", VA = "0x1128FBA0")]
    public void Update()
    {
    }

    [Token(Token = "0x600544B")]
    [Address(RVA = "0x128F790", Offset = "0x128E590", VA = "0x1128F790", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600544C")]
    [Address(RVA = "0x128FC60", Offset = "0x128EA60", VA = "0x1128FC60")]
    public FlowNode_Message()
    {
    }
  }
}
