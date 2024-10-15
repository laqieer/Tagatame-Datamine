// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C20")]
  public class UnitSetting
  {
    [Token(Token = "0x4001F82")]
    [FieldOffset(Offset = "0x8")]
    public OString uniqname;
    [Token(Token = "0x4001F83")]
    [FieldOffset(Offset = "0xC")]
    public OString ai;
    [Token(Token = "0x4001F84")]
    [FieldOffset(Offset = "0x10")]
    public OIntVector2 pos;
    [Token(Token = "0x4001F85")]
    [FieldOffset(Offset = "0x38")]
    public OInt dir;
    [Token(Token = "0x4001F86")]
    [FieldOffset(Offset = "0x4C")]
    public OInt side;
    [Token(Token = "0x4001F87")]
    [FieldOffset(Offset = "0x60")]
    public OInt waitEntryClock;
    [Token(Token = "0x4001F88")]
    [FieldOffset(Offset = "0x74")]
    public OInt waitMoveTurn;
    [Token(Token = "0x4001F89")]
    [FieldOffset(Offset = "0x88")]
    public OInt waitExitTurn;
    [Token(Token = "0x4001F8A")]
    [FieldOffset(Offset = "0x9C")]
    public eMapUnitCtCalcType startCtCalc;
    [Token(Token = "0x4001F8B")]
    [FieldOffset(Offset = "0xA0")]
    public OInt startCtVal;
    [Token(Token = "0x4001F8C")]
    [FieldOffset(Offset = "0xB4")]
    public bool DisableFirceVoice;
    [Token(Token = "0x4001F8D")]
    [FieldOffset(Offset = "0xB8")]
    public AIActionType ai_type;
    [Token(Token = "0x4001F8E")]
    [FieldOffset(Offset = "0xBC")]
    public OIntVector2 ai_pos;
    [Token(Token = "0x4001F8F")]
    [FieldOffset(Offset = "0xE4")]
    public OInt ai_len;
    [Token(Token = "0x4001F90")]
    [FieldOffset(Offset = "0xF8")]
    public EventTrigger trigger;
    [Token(Token = "0x4001F91")]
    [FieldOffset(Offset = "0xFC")]
    public List<UnitEntryTrigger> entries;
    [Token(Token = "0x4001F92")]
    [FieldOffset(Offset = "0x100")]
    public OInt entries_and;
    [Token(Token = "0x4001F93")]
    [FieldOffset(Offset = "0x114")]
    public OString parent;

    [Token(Token = "0x6003032")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitSetting()
    {
    }

    [Token(Token = "0x6003033")]
    [Address(RVA = "0xFEBAD0", Offset = "0xFEA8D0", VA = "0x10FEBAD0")]
    public UnitSetting(JSON_MapPartyUnit json)
    {
    }
  }
}
