// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F87")]
  public class AdventureData : AdventureDataBase
  {
    [Token(Token = "0x4008529")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsAdv;
    [Token(Token = "0x400852A")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndTime;
    [Token(Token = "0x400852B")]
    [FieldOffset(Offset = "0x20")]
    private List<UnitData> mUnitList;
    [Token(Token = "0x400852C")]
    [FieldOffset(Offset = "0x24")]
    private List<UnitGroupParam> mUnitGroupList;
    [Token(Token = "0x400852D")]
    [FieldOffset(Offset = "0x28")]
    protected AdventureAreaParam mAreaParam;

    [Token(Token = "0x1700128E")]
    public bool IsAdv
    {
      [Token(Token = "0x6008178"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700128F")]
    public DateTime EndTime
    {
      [Token(Token = "0x6008179"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001290")]
    public List<UnitData> UnitList
    {
      [Token(Token = "0x600817A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x17001291")]
    public List<UnitGroupParam> UnitGroupList
    {
      [Token(Token = "0x600817B"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<UnitGroupParam>) null;
      }
    }

    [Token(Token = "0x17001292")]
    public AdventureAreaParam AreaParam
    {
      [Token(Token = "0x600817C"), Address(RVA = "0x41FB90", Offset = "0x41E990", VA = "0x1041FB90")] get
      {
        return (AdventureAreaParam) null;
      }
    }

    [Token(Token = "0x600817D")]
    [Address(RVA = "0x41FAA0", Offset = "0x41E8A0", VA = "0x1041FAA0")]
    public AdventureData()
    {
    }

    [Token(Token = "0x600817E")]
    [Address(RVA = "0x41F9A0", Offset = "0x41E7A0", VA = "0x1041F9A0")]
    public AdventureData(string iname)
    {
    }

    [Token(Token = "0x600817F")]
    [Address(RVA = "0x41F6A0", Offset = "0x41E4A0", VA = "0x1041F6A0")]
    public bool Deserialize(JSON_AdventureData json) => new bool();

    [Token(Token = "0x6008180")]
    [Address(RVA = "0x41F600", Offset = "0x41E400", VA = "0x1041F600")]
    public eAdventureStatus CalcAdventureStatus() => new eAdventureStatus();

    [Token(Token = "0x6008181")]
    [Address(RVA = "0x41F950", Offset = "0x41E750", VA = "0x1041F950")]
    public int GetListAreaLevel() => new int();

    [Token(Token = "0x6008182")]
    [Address(RVA = "0x41F900", Offset = "0x41E700", VA = "0x1041F900")]
    public int GetDisplayAreaLevel() => new int();
  }
}
