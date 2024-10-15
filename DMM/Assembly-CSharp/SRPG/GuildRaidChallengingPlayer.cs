// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidChallengingPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB1")]
  public class GuildRaidChallengingPlayer
  {
    [Token(Token = "0x1700059E")]
    public string Name
    {
      [Token(Token = "0x60040EF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60040F0"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700059F")]
    public UnitParam Unit
    {
      [Token(Token = "0x60040F1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitParam) null;
      }
      [Token(Token = "0x60040F2"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x170005A0")]
    public int Lv
    {
      [Token(Token = "0x60040F3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040F4"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170005A1")]
    public AwardParam SelectedAward
    {
      [Token(Token = "0x60040F5"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (AwardParam) null;
      }
      [Token(Token = "0x60040F6"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x170005A2")]
    public GuildMemberData.eRole Role
    {
      [Token(Token = "0x60040F7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new GuildMemberData.eRole();
      }
      [Token(Token = "0x60040F8"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x170005A3")]
    public DateTime ChallengeTime
    {
      [Token(Token = "0x60040F9"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60040FA"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x60040FB")]
    [Address(RVA = "0x1192890", Offset = "0x1191690", VA = "0x11192890")]
    public bool Deserialize(JSON_GuildRaidChallengingPlayer json) => new bool();

    [Token(Token = "0x60040FC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidChallengingPlayer()
    {
    }
  }
}
