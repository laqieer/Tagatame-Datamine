// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200151C")]
  [FlowNode.NodeType("Guild/ReqGuildEdit", 32741)]
  [FlowNode.Pin(1, "ギルド編集", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ギルドデータ更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "ギルド編集完了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildEdit : FlowNode_Network
  {
    [Token(Token = "0x4004D54")]
    private const int PIN_INPUT_START_GUILD_EDIT = 1;
    [Token(Token = "0x4004D55")]
    private const int PIN_INPUT_START_DEFAULTGUILD_EDIT = 2;
    [Token(Token = "0x4004D56")]
    private const int PIN_OUTPUT_END_GUILD_EDIT = 101;

    [Token(Token = "0x6005786")]
    [Address(RVA = "0x12D03D0", Offset = "0x12CF1D0", VA = "0x112D03D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005787")]
    [Address(RVA = "0x12D0570", Offset = "0x12CF370", VA = "0x112D0570", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005788")]
    [Address(RVA = "0x12D09B0", Offset = "0x12CF7B0", VA = "0x112D09B0")]
    private void RollbackGuildCommand()
    {
    }

    [Token(Token = "0x6005789")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildEdit()
    {
    }

    [Token(Token = "0x200151D")]
    public class Json_ResGuildEdit
    {
      [Token(Token = "0x4004D57")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D58")]
      [FieldOffset(Offset = "0xC")]
      public Json_Currencies currencies;

      [Token(Token = "0x600578A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildEdit()
      {
      }
    }
  }
}
