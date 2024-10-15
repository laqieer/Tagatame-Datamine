// Decompiled with JetBrains decompiler
// Type: SRPG.RuneStateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F0")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneStateData
  {
    [Token(Token = "0x4003D33")]
    [FieldOffset(Offset = "0x8")]
    public RuneBuffDataBaseState base_state;
    [Token(Token = "0x4003D34")]
    [FieldOffset(Offset = "0xC")]
    public List<RuneBuffDataEvoState> evo_state;
    [Token(Token = "0x4003D35")]
    [FieldOffset(Offset = "0x10")]
    private long dedicated_unit_id;

    [Token(Token = "0x17000745")]
    public long DedicatedUnitID
    {
      [Token(Token = "0x6004788"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004789")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void GetRuneLotteryEvoState()
    {
    }

    [Token(Token = "0x600478A")]
    [Address(RVA = "0x11E96D0", Offset = "0x11E84D0", VA = "0x111E96D0")]
    public bool Deserialize(Json_RuneStateData json) => new bool();

    [Token(Token = "0x600478B")]
    [Address(RVA = "0x11E96A0", Offset = "0x11E84A0", VA = "0x111E96A0")]
    private static int Compare(RuneBuffDataEvoState a, RuneBuffDataEvoState b) => new int();

    [Token(Token = "0x600478C")]
    [Address(RVA = "0x11E98A0", Offset = "0x11E86A0", VA = "0x111E98A0")]
    public Json_RuneStateData Serialize() => (Json_RuneStateData) null;

    [Token(Token = "0x600478D")]
    [Address(RVA = "0x11E9A80", Offset = "0x11E8880", VA = "0x111E9A80")]
    public RuneStateData()
    {
    }
  }
}
