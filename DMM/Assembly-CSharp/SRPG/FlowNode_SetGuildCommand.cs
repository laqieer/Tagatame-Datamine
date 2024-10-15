// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetGuildCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001619")]
  [FlowNode.NodeType("Guild/SetCommand", 32741)]
  [FlowNode.Pin(1, "開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "完了", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_SetGuildCommand : FlowNode
  {
    [Token(Token = "0x400501C")]
    private const int PIN_INPUT_START = 1;
    [Token(Token = "0x400501D")]
    private const int PIN_OUTPUT_END = 2;
    [Token(Token = "0x400501E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour Object;
    [Token(Token = "0x400501F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GuildCommand.eCommand Command;

    [Token(Token = "0x6005AE5")]
    [Address(RVA = "0x12F9FB0", Offset = "0x12F8DB0", VA = "0x112F9FB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AE6")]
    [Address(RVA = "0x12FA040", Offset = "0x12F8E40", VA = "0x112FA040")]
    private void SetCommand()
    {
    }

    [Token(Token = "0x6005AE7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetGuildCommand()
    {
    }
  }
}
