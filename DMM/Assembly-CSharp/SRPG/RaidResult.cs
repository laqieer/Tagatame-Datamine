// Decompiled with JetBrains decompiler
// Type: SRPG.RaidResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028F9")]
  public class RaidResult
  {
    [Token(Token = "0x400C513")]
    [FieldOffset(Offset = "0x8")]
    public QuestParam quest;
    [Token(Token = "0x400C514")]
    [FieldOffset(Offset = "0xC")]
    public int pexp;
    [Token(Token = "0x400C515")]
    [FieldOffset(Offset = "0x10")]
    public int uexp;
    [Token(Token = "0x400C516")]
    [FieldOffset(Offset = "0x14")]
    public int gold;
    [Token(Token = "0x400C517")]
    [FieldOffset(Offset = "0x18")]
    public List<UnitData> members;
    [Token(Token = "0x400C518")]
    [FieldOffset(Offset = "0x1C")]
    public List<RaidQuestResult> results;
    [Token(Token = "0x400C519")]
    [FieldOffset(Offset = "0x20")]
    public QuestParam[] chquest;
    [Token(Token = "0x400C51A")]
    [FieldOffset(Offset = "0x24")]
    public string[] campaignIds;
    [Token(Token = "0x400C51B")]
    [FieldOffset(Offset = "0x28")]
    public List<RuneData> runes_detail;
    [Token(Token = "0x400C51C")]
    [FieldOffset(Offset = "0x2C")]
    public List<Json_Disassemble> runes_disassemble;

    [Token(Token = "0x600B973")]
    [Address(RVA = "0x80A6A0", Offset = "0x8094A0", VA = "0x1080A6A0")]
    public RaidResult(PlayerPartyTypes type)
    {
    }
  }
}
