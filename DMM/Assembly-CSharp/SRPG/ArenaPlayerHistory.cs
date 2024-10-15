// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaPlayerHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E51")]
  public class ArenaPlayerHistory
  {
    [Token(Token = "0x4002B9A")]
    [FieldOffset(Offset = "0x8")]
    public string type;
    [Token(Token = "0x4002B9B")]
    [FieldOffset(Offset = "0xC")]
    public string result;
    [Token(Token = "0x4002B9C")]
    [FieldOffset(Offset = "0x10")]
    public JSON_ArenaRankInfo ranking;
    [Token(Token = "0x4002B9D")]
    [FieldOffset(Offset = "0x18")]
    public DateTime battle_at;
    [Token(Token = "0x4002B9E")]
    [FieldOffset(Offset = "0x20")]
    public ArenaPlayer my;
    [Token(Token = "0x4002B9F")]
    [FieldOffset(Offset = "0x24")]
    public ArenaPlayer enemy;

    [Token(Token = "0x6003B07")]
    [Address(RVA = "0x10CCD80", Offset = "0x10CBB80", VA = "0x110CCD80")]
    public bool IsAttack() => new bool();

    [Token(Token = "0x6003B08")]
    [Address(RVA = "0x10CCE60", Offset = "0x10CBC60", VA = "0x110CCE60")]
    public bool IsWin() => new bool();

    [Token(Token = "0x6003B09")]
    [Address(RVA = "0x10CCDC0", Offset = "0x10CBBC0", VA = "0x110CCDC0")]
    public bool IsNew() => new bool();

    [Token(Token = "0x6003B0A")]
    [Address(RVA = "0x10CCA80", Offset = "0x10CB880", VA = "0x110CCA80")]
    public void Deserialize(Json_ArenaPlayerHistory json)
    {
    }

    [Token(Token = "0x6003B0B")]
    [Address(RVA = "0x10CCEA0", Offset = "0x10CBCA0", VA = "0x110CCEA0")]
    public ArenaPlayerHistory()
    {
    }
  }
}
