// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildSearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200152B")]
  [FlowNode.NodeType("Guild/ReqGuildSearch", 32741)]
  [FlowNode.Pin(1, "ギルド検索", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "ギルド検索完了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildSearch : FlowNode_Network
  {
    [Token(Token = "0x4004D7D")]
    private const int PIN_INPUT_START_GUILD_SEARCH = 1;
    [Token(Token = "0x4004D7E")]
    private const int PIN_OUTPUT_END_GUILD_SEARCH = 101;

    [Token(Token = "0x60057AE")]
    [Address(RVA = "0x12D2E80", Offset = "0x12D1C80", VA = "0x112D2E80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057AF")]
    [Address(RVA = "0x12D2F30", Offset = "0x12D1D30", VA = "0x112D2F30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057B0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildSearch()
    {
    }

    [Token(Token = "0x200152C")]
    public class Json_ReqGuildSearch
    {
      [Token(Token = "0x4004D7F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;

      [Token(Token = "0x60057B1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ReqGuildSearch()
      {
      }
    }
  }
}
