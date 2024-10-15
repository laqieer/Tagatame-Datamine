// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerPlayerRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001189")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerPlayerRanking
  {
    [Token(Token = "0x4003F97")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4003F98")]
    [FieldOffset(Offset = "0xC")]
    public JSON_CombatPowerPlayerRankingData player;
    [Token(Token = "0x4003F99")]
    [FieldOffset(Offset = "0x10")]
    public JSON_CombatPowerPortRankingData guild;

    [Token(Token = "0x6004AF6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerPlayerRanking()
    {
    }
  }
}
