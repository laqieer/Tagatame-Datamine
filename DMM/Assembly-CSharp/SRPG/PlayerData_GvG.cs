// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerData_GvG
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010B2")]
  public class PlayerData_GvG
  {
    [Token(Token = "0x4003BED")]
    [FieldOffset(Offset = "0x8")]
    public List<GvGPresetPartyUnits> GvGPresetList;
    [Token(Token = "0x4003BEE")]
    [FieldOffset(Offset = "0xC")]
    public int GvGPresetIndex;
    [Token(Token = "0x4003BEF")]
    [FieldOffset(Offset = "0x10")]
    public int GvGPresetOldIndex;
    [Token(Token = "0x4003BF0")]
    [FieldOffset(Offset = "0x14")]
    public int GvGPresetRenameIndex;
    [Token(Token = "0x4003BF1")]
    [FieldOffset(Offset = "0x18")]
    public bool IsGvGPresetEditor;

    [Token(Token = "0x60046C3")]
    [Address(RVA = "0x11E0370", Offset = "0x11DF170", VA = "0x111E0370")]
    public void SetupPresetParty(JSON_GvGPresetPartyUnits[] units)
    {
    }

    [Token(Token = "0x60046C4")]
    [Address(RVA = "0x11DFE40", Offset = "0x11DEC40", VA = "0x111DFE40")]
    public int GetPresetPartyNum(long uid) => new int();

    [Token(Token = "0x60046C5")]
    [Address(RVA = "0x11E02B0", Offset = "0x11DF0B0", VA = "0x111E02B0")]
    public void SetPresetEntryParty(UnitData[] units, int partyNo)
    {
    }

    [Token(Token = "0x60046C6")]
    [Address(RVA = "0x11E0100", Offset = "0x11DEF00", VA = "0x111E0100")]
    public void SetPresetEntryParty(long[] units, int partyNo)
    {
    }

    [Token(Token = "0x60046C7")]
    [Address(RVA = "0x11E0040", Offset = "0x11DEE40", VA = "0x111E0040")]
    public void SetGvGPresetListName(int index, string name)
    {
    }

    [Token(Token = "0x60046C8")]
    [Address(RVA = "0x11DFFC0", Offset = "0x11DEDC0", VA = "0x111DFFC0")]
    public bool IsCheckGvGPresetIndex(int index) => new bool();

    [Token(Token = "0x60046C9")]
    [Address(RVA = "0x11E0530", Offset = "0x11DF330", VA = "0x111E0530")]
    public PlayerData_GvG()
    {
    }
  }
}
