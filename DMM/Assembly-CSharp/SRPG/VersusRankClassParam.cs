// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankClassParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ECD")]
  public class VersusRankClassParam
  {
    [Token(Token = "0x4008179")]
    [FieldOffset(Offset = "0x8")]
    private int mScheduleId;
    [Token(Token = "0x400817A")]
    [FieldOffset(Offset = "0xC")]
    private RankMatchClass mClass;
    [Token(Token = "0x400817B")]
    [FieldOffset(Offset = "0x10")]
    private int mUpPoint;
    [Token(Token = "0x400817C")]
    [FieldOffset(Offset = "0x14")]
    private int mDownPoint;
    [Token(Token = "0x400817D")]
    [FieldOffset(Offset = "0x18")]
    private int mDownLosingStreak;
    [Token(Token = "0x400817E")]
    [FieldOffset(Offset = "0x1C")]
    private string mRewardId;
    [Token(Token = "0x400817F")]
    [FieldOffset(Offset = "0x20")]
    private int mWinPointBase;
    [Token(Token = "0x4008180")]
    [FieldOffset(Offset = "0x24")]
    private int mLosePointBase;

    [Token(Token = "0x170011AF")]
    public int ScheduleId
    {
      [Token(Token = "0x6007E09"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011B0")]
    public RankMatchClass Class
    {
      [Token(Token = "0x6007E0A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new RankMatchClass();
      }
    }

    [Token(Token = "0x170011B1")]
    public int UpPoint
    {
      [Token(Token = "0x6007E0B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011B2")]
    public int DownPoint
    {
      [Token(Token = "0x6007E0C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011B3")]
    public int DownLosingStreak
    {
      [Token(Token = "0x6007E0D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011B4")]
    public string RewardId
    {
      [Token(Token = "0x6007E0E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011B5")]
    public int WinPointBase
    {
      [Token(Token = "0x6007E0F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011B6")]
    public int LosePointBase
    {
      [Token(Token = "0x6007E10"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007E11")]
    [Address(RVA = "0x3FB130", Offset = "0x3F9F30", VA = "0x103FB130")]
    public bool Deserialize(JSON_VersusRankClassParam json) => new bool();

    [Token(Token = "0x6007E12")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankClassParam()
    {
    }
  }
}
