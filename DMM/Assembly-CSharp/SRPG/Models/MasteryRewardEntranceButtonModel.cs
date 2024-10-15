// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MasteryRewardEntranceButtonModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336C")]
  public class MasteryRewardEntranceButtonModel
  {
    [Token(Token = "0x400F300")]
    [FieldOffset(Offset = "0x8")]
    private string mNowEmblemPath;
    [Token(Token = "0x400F301")]
    [FieldOffset(Offset = "0xC")]
    private string mNextMasteryNum;
    [Token(Token = "0x400F302")]
    [FieldOffset(Offset = "0x10")]
    private float mMasterySliderNum;
    [Token(Token = "0x400F303")]
    [FieldOffset(Offset = "0x14")]
    private float mMasterySliderMin;
    [Token(Token = "0x400F304")]
    [FieldOffset(Offset = "0x18")]
    private float mMasterySliderMax;
    [Token(Token = "0x400F305")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsAchievementMasteryReward;
    [Token(Token = "0x400F306")]
    [FieldOffset(Offset = "0x1D")]
    private bool mIsMax;

    [Token(Token = "0x17001F24")]
    public string NowEmblemPath
    {
      [Token(Token = "0x600E431"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F25")]
    public string NextMasteryNum
    {
      [Token(Token = "0x600E432"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F26")]
    public float MasterySliderNum
    {
      [Token(Token = "0x600E433"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F27")]
    public float MasterySliderMin
    {
      [Token(Token = "0x600E434"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F28")]
    public float MasterySliderMax
    {
      [Token(Token = "0x600E435"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001F29")]
    public bool IsAchievementMasteryReward
    {
      [Token(Token = "0x600E436"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F2A")]
    public bool IsMax
    {
      [Token(Token = "0x600E437"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E438")]
    [Address(RVA = "0xABA690", Offset = "0xAB9490", VA = "0x10ABA690")]
    public bool IsRequestAPI() => new bool();

    [Token(Token = "0x600E439")]
    [Address(RVA = "0xABA680", Offset = "0xAB9480", VA = "0x10ABA680")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E43A")]
    [Address(RVA = "0xABA800", Offset = "0xAB9600", VA = "0x10ABA800")]
    public void update()
    {
    }

    [Token(Token = "0x600E43B")]
    [Address(RVA = "0xABA790", Offset = "0xAB9590", VA = "0x10ABA790")]
    public MasteryRewardEntranceButtonModel()
    {
    }
  }
}
