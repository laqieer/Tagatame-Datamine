// Decompiled with JetBrains decompiler
// Type: SRPG.Json_DuelBattleRecode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002315")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_DuelBattleRecode
  {
    [Token(Token = "0x4009C86")]
    [FieldOffset(Offset = "0x8")]
    public int battle_total;
    [Token(Token = "0x4009C87")]
    [FieldOffset(Offset = "0xC")]
    public int win_streak;
    [Token(Token = "0x4009C88")]
    [FieldOffset(Offset = "0x10")]
    public int win_total;

    [Token(Token = "0x60096D7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_DuelBattleRecode()
    {
    }
  }
}
