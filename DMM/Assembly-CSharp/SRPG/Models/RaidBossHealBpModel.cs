// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RaidBossHealBpModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003381")]
  public class RaidBossHealBpModel
  {
    [Token(Token = "0x400F3A8")]
    [FieldOffset(Offset = "0x8")]
    private int mStartBp;
    [Token(Token = "0x400F3A9")]
    [FieldOffset(Offset = "0xC")]
    private int mNowBp;
    [Token(Token = "0x400F3AA")]
    [FieldOffset(Offset = "0x10")]
    private int mBpMax;
    [Token(Token = "0x400F3AB")]
    [FieldOffset(Offset = "0x14")]
    private int mBpByCoin;
    [Token(Token = "0x400F3AC")]
    [FieldOffset(Offset = "0x18")]
    private int mSelectNum;
    [Token(Token = "0x400F3AD")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsResult;

    [Token(Token = "0x17001FA4")]
    public int StartBp
    {
      [Token(Token = "0x600E517"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FA5")]
    public int NowBp
    {
      [Token(Token = "0x600E518"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FA6")]
    public int BpMax
    {
      [Token(Token = "0x600E519"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FA7")]
    public int BpByCoin
    {
      [Token(Token = "0x600E51A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FA8")]
    public int SelectNum
    {
      [Token(Token = "0x600E51B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FA9")]
    public bool IsResult
    {
      [Token(Token = "0x600E51C"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E51D")]
    [Address(RVA = "0xABF790", Offset = "0xABE590", VA = "0x10ABF790")]
    public void Initialize(int now_bp, int select_num, RaidPeriodParam param)
    {
    }

    [Token(Token = "0x600E51E")]
    [Address(RVA = "0xABF770", Offset = "0xABE570", VA = "0x10ABF770")]
    public void InitializeResult(int start_bp, int now_bp)
    {
    }

    [Token(Token = "0x600E51F")]
    [Address(RVA = "0xABF760", Offset = "0xABE560", VA = "0x10ABF760")]
    public int GetNeedCoin() => new int();

    [Token(Token = "0x600E520")]
    [Address(RVA = "0xABF7F0", Offset = "0xABE5F0", VA = "0x10ABF7F0")]
    public bool IsActiveNowBp(int _num) => new bool();

    [Token(Token = "0x600E521")]
    [Address(RVA = "0xABF7C0", Offset = "0xABE5C0", VA = "0x10ABF7C0")]
    public bool IsAcitveHealBp(int _num) => new bool();

    [Token(Token = "0x600E522")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidBossHealBpModel()
    {
    }
  }
}
