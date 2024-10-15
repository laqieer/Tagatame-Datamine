// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerRankingViewGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F86")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerRankingViewGuild : JSON_ViewGuild
  {
    [Token(Token = "0x400368B")]
    [FieldOffset(Offset = "0x30")]
    public int rank;
    [Token(Token = "0x400368C")]
    [FieldOffset(Offset = "0x38")]
    public long combat_power;

    [Token(Token = "0x600405A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerRankingViewGuild()
    {
    }
  }
}
