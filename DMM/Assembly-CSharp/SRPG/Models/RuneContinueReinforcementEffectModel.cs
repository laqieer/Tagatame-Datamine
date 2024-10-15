// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneContinueReinforcementEffectModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003391")]
  public class RuneContinueReinforcementEffectModel
  {
    [Token(Token = "0x400F407")]
    [FieldOffset(Offset = "0x8")]
    private BindRuneData mBeforeBindRune;
    [Token(Token = "0x400F408")]
    [FieldOffset(Offset = "0xC")]
    private RuneData mBeforeRune;
    [Token(Token = "0x400F409")]
    [FieldOffset(Offset = "0x10")]
    private BindRuneData mAfterBindRune;
    [Token(Token = "0x400F40A")]
    [FieldOffset(Offset = "0x14")]
    private RuneData mAfterRune;
    [Token(Token = "0x400F40B")]
    [FieldOffset(Offset = "0x18")]
    private int mAddEnhanceLevel;
    [Token(Token = "0x400F40C")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsButtonEnable;
    [Token(Token = "0x400F40D")]
    [FieldOffset(Offset = "0x20")]
    private int mEvoLevelStart;
    [Token(Token = "0x400F40E")]
    [FieldOffset(Offset = "0x24")]
    private int mEvoLevelEnd;
    [Token(Token = "0x400F40F")]
    [FieldOffset(Offset = "0x28")]
    private bool mNextEnhance;

    [Token(Token = "0x17001FFD")]
    public BindRuneData BeforeBindRune
    {
      [Token(Token = "0x600E5A9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x17001FFE")]
    public RuneData BeforeRune
    {
      [Token(Token = "0x600E5AA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (RuneData) null;
      }
    }

    [Token(Token = "0x17001FFF")]
    public BindRuneData AfterBindRune
    {
      [Token(Token = "0x600E5AB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x17002000")]
    public RuneData AfterRune
    {
      [Token(Token = "0x600E5AC"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (RuneData) null;
      }
    }

    [Token(Token = "0x17002001")]
    public int AddEnhanceLevel
    {
      [Token(Token = "0x600E5AD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002002")]
    public bool IsButtonEnable
    {
      [Token(Token = "0x600E5AE"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002003")]
    public int EvoLevelStart
    {
      [Token(Token = "0x600E5AF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002004")]
    public int EvoLevelEnd
    {
      [Token(Token = "0x600E5B0"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002005")]
    public bool NextEnhance
    {
      [Token(Token = "0x600E5B1"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E5B2")]
    [Address(RVA = "0xAC05D0", Offset = "0xABF3D0", VA = "0x10AC05D0")]
    public void Initialize(BindRuneData before_rune, BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600E5B3")]
    [Address(RVA = "0xAC06E0", Offset = "0xABF4E0", VA = "0x10AC06E0")]
    public void SetParam()
    {
    }

    [Token(Token = "0x600E5B4")]
    [Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")]
    public void SetButtonEnable(bool is_enable)
    {
    }

    [Token(Token = "0x600E5B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneContinueReinforcementEffectModel()
    {
    }
  }
}
