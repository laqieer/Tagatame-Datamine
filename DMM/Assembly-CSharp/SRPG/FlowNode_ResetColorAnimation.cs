// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResetColorAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015EE")]
  [FlowNode.NodeType("ColorAnimation/Reset", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ResetColorAnimation : FlowNode
  {
    [Token(Token = "0x4004F95")]
    private const int PIN_IN_INPUT = 0;
    [Token(Token = "0x4004F96")]
    private const int PIN_IN_OUTPUT = 10;
    [Token(Token = "0x4004F97")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    [FlowNode.ShowInInfo]
    [SerializeField]
    private GameObject m_Target;
    [Token(Token = "0x4004F98")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float m_Time;
    [Token(Token = "0x4004F99")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool m_IsSearchChildren;

    [Token(Token = "0x6005A19")]
    [Address(RVA = "0x12EB270", Offset = "0x12EA070", VA = "0x112EB270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A1A")]
    [Address(RVA = "0x12EB3C0", Offset = "0x12EA1C0", VA = "0x112EB3C0")]
    private void ResetTime(float time)
    {
    }

    [Token(Token = "0x6005A1B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResetColorAnimation()
    {
    }
  }
}
