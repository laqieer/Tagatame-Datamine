// Decompiled with JetBrains decompiler
// Type: SRPG.RaidPeriodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C80")]
  public class RaidPeriodParam : RaidMasterParam<JSON_RaidPeriodParam>
  {
    [Token(Token = "0x4006FF4")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FF5")]
    [FieldOffset(Offset = "0xC")]
    private int mMaxBp;
    [Token(Token = "0x4006FF6")]
    [FieldOffset(Offset = "0x10")]
    private string mAddBpTime;
    [Token(Token = "0x4006FF7")]
    [FieldOffset(Offset = "0x14")]
    private int mBpByCoin;
    [Token(Token = "0x4006FF8")]
    [FieldOffset(Offset = "0x18")]
    private int mRescueMemberMax;
    [Token(Token = "0x4006FF9")]
    [FieldOffset(Offset = "0x1C")]
    private string mRescureSendInterval;
    [Token(Token = "0x4006FFA")]
    [FieldOffset(Offset = "0x20")]
    private int mCompleteRewardId;
    [Token(Token = "0x4006FFB")]
    [FieldOffset(Offset = "0x24")]
    private int mRoundBuffMax;
    [Token(Token = "0x4006FFC")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mBeginAt;
    [Token(Token = "0x4006FFD")]
    [FieldOffset(Offset = "0x30")]
    private DateTime mEndAt;
    [Token(Token = "0x4006FFE")]
    [FieldOffset(Offset = "0x38")]
    private DateTime mRewardBeginAt;
    [Token(Token = "0x4006FFF")]
    [FieldOffset(Offset = "0x40")]
    private DateTime mRewardEndAt;

    [Token(Token = "0x17000F21")]
    public int Id
    {
      [Token(Token = "0x6007583"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F22")]
    public int MaxBp
    {
      [Token(Token = "0x6007584"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F23")]
    public string AddBpTime
    {
      [Token(Token = "0x6007585"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F24")]
    public int BpByCoin
    {
      [Token(Token = "0x6007586"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F25")]
    public int RescueMemberMax
    {
      [Token(Token = "0x6007587"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F26")]
    public string RescureSendInterval
    {
      [Token(Token = "0x6007588"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F27")]
    public int CompleteRewardId
    {
      [Token(Token = "0x6007589"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F28")]
    public int RoundBuffMax
    {
      [Token(Token = "0x600758A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F29")]
    public DateTime BeginAt
    {
      [Token(Token = "0x600758B"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000F2A")]
    public DateTime EndAt
    {
      [Token(Token = "0x600758C"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000F2B")]
    public DateTime RewardBeginAt
    {
      [Token(Token = "0x600758D"), Address(RVA = "0x370600", Offset = "0x36F400", VA = "0x10370600")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000F2C")]
    public DateTime RewardEndAt
    {
      [Token(Token = "0x600758E"), Address(RVA = "0x3705E0", Offset = "0x36F3E0", VA = "0x103705E0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600758F")]
    [Address(RVA = "0x393540", Offset = "0x392340", VA = "0x10393540", Slot = "4")]
    public override bool Deserialize(JSON_RaidPeriodParam json) => new bool();

    [Token(Token = "0x6007590")]
    [Address(RVA = "0x393750", Offset = "0x392550", VA = "0x10393750")]
    public RaidPeriodParam()
    {
    }
  }
}
