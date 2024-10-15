// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SelectParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001601")]
  [FlowNode.Pin(151, "SaveTeamID", FlowNode.PinTypes.Input, 151)]
  [FlowNode.NodeType("UI/SelectParty", 32741)]
  [FlowNode.Pin(150, "LoadTeamID", FlowNode.PinTypes.Input, 150)]
  [FlowNode.Pin(1000, "ApplyToPlayerData", FlowNode.PinTypes.Input, 1000)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Select Team", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 1001)]
  public class FlowNode_SelectParty : FlowNode
  {
    [Token(Token = "0x4004FCE")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_SelectParty.PartyTypes PartyType;
    [Token(Token = "0x4004FCF")]
    [FieldOffset(Offset = "0x1C")]
    public int PartyIndex;

    [Token(Token = "0x6005A86")]
    [Address(RVA = "0x12F3E40", Offset = "0x12F2C40", VA = "0x112F3E40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A87")]
    [Address(RVA = "0x12F3C90", Offset = "0x12F2A90", VA = "0x112F3C90")]
    public static void LoadTeamID(FlowNode_SelectParty.PartyTypes type)
    {
    }

    [Token(Token = "0x6005A88")]
    [Address(RVA = "0x12F3FA0", Offset = "0x12F2DA0", VA = "0x112F3FA0")]
    private void SaveTeamID()
    {
    }

    [Token(Token = "0x6005A89")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SelectParty()
    {
    }

    [Token(Token = "0x2001602")]
    public enum PartyTypes
    {
      [Token(Token = "0x4004FD1")] Normal,
      [Token(Token = "0x4004FD2")] Multi,
      [Token(Token = "0x4004FD3")] Arena,
      [Token(Token = "0x4004FD4")] ArenaDefense,
      [Token(Token = "0x4004FD5")] RankMatch,
      [Token(Token = "0x4004FD6")] Raid,
    }
  }
}
