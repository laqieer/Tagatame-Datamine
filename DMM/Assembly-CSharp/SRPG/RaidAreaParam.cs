// Decompiled with JetBrains decompiler
// Type: SRPG.RaidAreaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C64")]
  public class RaidAreaParam : RaidMasterParam<JSON_RaidAreaParam>
  {
    [Token(Token = "0x4006F90")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006F91")]
    [FieldOffset(Offset = "0xC")]
    private int mOrder;
    [Token(Token = "0x4006F92")]
    [FieldOffset(Offset = "0x10")]
    private int mPeriodId;
    [Token(Token = "0x4006F93")]
    [FieldOffset(Offset = "0x14")]
    private int mBossCount;
    [Token(Token = "0x4006F94")]
    [FieldOffset(Offset = "0x18")]
    private int mAreaBossId;
    [Token(Token = "0x4006F95")]
    [FieldOffset(Offset = "0x1C")]
    private int mClearRewardId;

    [Token(Token = "0x17000EF6")]
    public int Id
    {
      [Token(Token = "0x600752E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF7")]
    public int Order
    {
      [Token(Token = "0x600752F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF8")]
    public int PeriodId
    {
      [Token(Token = "0x6007530"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF9")]
    public int BossCount
    {
      [Token(Token = "0x6007531"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EFA")]
    public int AreaBossId
    {
      [Token(Token = "0x6007532"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EFB")]
    public int ClearRewardId
    {
      [Token(Token = "0x6007533"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007534")]
    [Address(RVA = "0x3929A0", Offset = "0x3917A0", VA = "0x103929A0", Slot = "4")]
    public override bool Deserialize(JSON_RaidAreaParam json) => new bool();

    [Token(Token = "0x6007535")]
    [Address(RVA = "0x3929E0", Offset = "0x3917E0", VA = "0x103929E0")]
    public RaidAreaParam()
    {
    }
  }
}
