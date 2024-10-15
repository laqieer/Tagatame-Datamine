// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetGuildConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200161A")]
  [FlowNode.NodeType("Guild/SetConfirmType", 32741)]
  [FlowNode.Pin(1, "開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "完了", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_SetGuildConfirm : FlowNode
  {
    [Token(Token = "0x4005020")]
    private const int PIN_INPUT_START = 1;
    [Token(Token = "0x4005021")]
    private const int PIN_OUTPUT_END = 2;
    [Token(Token = "0x4005022")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour Object;
    [Token(Token = "0x4005023")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GuildConfirm.eConfirmType ConfirmType;

    [Token(Token = "0x6005AE8")]
    [Address(RVA = "0x12FA0C0", Offset = "0x12F8EC0", VA = "0x112FA0C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AE9")]
    [Address(RVA = "0x12FA150", Offset = "0x12F8F50", VA = "0x112FA150")]
    private void SetConfirmType()
    {
    }

    [Token(Token = "0x6005AEA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetGuildConfirm()
    {
    }
  }
}
