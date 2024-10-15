// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E4E")]
  public class ArenaPlayer : ICombatPowerContent
  {
    [Token(Token = "0x4002B87")]
    [FieldOffset(Offset = "0x8")]
    public UnitData[] Unit;
    [Token(Token = "0x4002B88")]
    [FieldOffset(Offset = "0xC")]
    public string result;
    [Token(Token = "0x4002B89")]
    [FieldOffset(Offset = "0x10")]
    public string FUID;
    [Token(Token = "0x4002B8A")]
    [FieldOffset(Offset = "0x14")]
    public string PlayerName;
    [Token(Token = "0x4002B8B")]
    [FieldOffset(Offset = "0x18")]
    public int PlayerLevel;
    [Token(Token = "0x4002B8C")]
    [FieldOffset(Offset = "0x1C")]
    public int ArenaRank;
    [Token(Token = "0x4002B8D")]
    [FieldOffset(Offset = "0x20")]
    public int TotalAtk;
    [Token(Token = "0x4002B8E")]
    [FieldOffset(Offset = "0x28")]
    public DateTime battle_at;
    [Token(Token = "0x4002B8F")]
    [FieldOffset(Offset = "0x30")]
    public string SelectAward;
    [Token(Token = "0x4002B90")]
    [FieldOffset(Offset = "0x34")]
    public ViewGuildData ViewGuild;

    [Token(Token = "0x17000457")]
    public long CombatPower
    {
      [Token(Token = "0x6003AFF"), Address(RVA = "0x10CD3F0", Offset = "0x10CC1F0", VA = "0x110CD3F0", Slot = "4")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6003B00")]
    [Address(RVA = "0x5C9000", Offset = "0x5C7E00", VA = "0x105C9000")]
    public int BattleCount() => new int();

    [Token(Token = "0x6003B01")]
    [Address(RVA = "0x5C9280", Offset = "0x5C8080", VA = "0x105C9280")]
    public int WinCount() => new int();

    [Token(Token = "0x6003B02")]
    [Address(RVA = "0x10CD1D0", Offset = "0x10CBFD0", VA = "0x110CD1D0")]
    public void Serialize(StringBuilder sb)
    {
    }

    [Token(Token = "0x6003B03")]
    [Address(RVA = "0x10CCF00", Offset = "0x10CBD00", VA = "0x110CCF00")]
    public void Deserialize(Json_ArenaPlayer json)
    {
    }

    [Token(Token = "0x6003B04")]
    [Address(RVA = "0x10CD370", Offset = "0x10CC170", VA = "0x110CD370")]
    public ArenaPlayer()
    {
    }
  }
}
