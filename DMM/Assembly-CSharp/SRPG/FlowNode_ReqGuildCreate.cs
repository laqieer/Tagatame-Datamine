// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200151A")]
  [FlowNode.Pin(101, "ギルド設立完了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Guild/ReqGuildCreate", 32741)]
  [FlowNode.Pin(1, "ギルド設立", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildCreate : FlowNode_Network
  {
    [Token(Token = "0x4004D4F")]
    private const int PIN_INPUT_START_GUILD_CREATE = 1;
    [Token(Token = "0x4004D50")]
    private const int PIN_OUTPUT_END_GUILD_CREATE = 101;

    [Token(Token = "0x6005782")]
    [Address(RVA = "0x12CFFE0", Offset = "0x12CEDE0", VA = "0x112CFFE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005783")]
    [Address(RVA = "0x12D00F0", Offset = "0x12CEEF0", VA = "0x112D00F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005784")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildCreate()
    {
    }

    [Token(Token = "0x200151B")]
    public class Json_ResGuildCreate
    {
      [Token(Token = "0x4004D51")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D52")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;
      [Token(Token = "0x4004D53")]
      [FieldOffset(Offset = "0x10")]
      public Json_Currencies currencies;

      [Token(Token = "0x6005785")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildCreate()
      {
      }
    }
  }
}
