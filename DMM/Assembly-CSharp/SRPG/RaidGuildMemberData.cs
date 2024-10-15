// Decompiled with JetBrains decompiler
// Type: SRPG.RaidGuildMemberData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F8F")]
  public class RaidGuildMemberData : GuildMemberData
  {
    [Token(Token = "0x40036C3")]
    [FieldOffset(Offset = "0x48")]
    private int mBeatScore;
    [Token(Token = "0x40036C4")]
    [FieldOffset(Offset = "0x4C")]
    private int mRescueScore;
    [Token(Token = "0x40036C5")]
    [FieldOffset(Offset = "0x50")]
    private int mRound;

    [Token(Token = "0x17000588")]
    public int BeatScore
    {
      [Token(Token = "0x60040A2"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000589")]
    public int RescueScore
    {
      [Token(Token = "0x60040A3"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700058A")]
    public int Round
    {
      [Token(Token = "0x60040A4"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60040A5")]
    [Address(RVA = "0x119C110", Offset = "0x119AF10", VA = "0x1119C110")]
    public bool Deserialize(JSON_RaidGuildMember json) => new bool();

    [Token(Token = "0x60040A6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidGuildMemberData()
    {
    }
  }
}
