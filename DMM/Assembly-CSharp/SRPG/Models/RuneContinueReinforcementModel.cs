// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneContinueReinforcementModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003392")]
  public class RuneContinueReinforcementModel
  {
    [Token(Token = "0x400F410")]
    private const string RUNE_BULK_ENHANCE_AND_EVO_RESULT = "sys.RUNE_BULK_ENHANCE_AND_EVO_RESULT";
    [Token(Token = "0x400F411")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsVisible;
    [Token(Token = "0x400F412")]
    [FieldOffset(Offset = "0xC")]
    private int mNowEnhanceNum;
    [Token(Token = "0x400F413")]
    [FieldOffset(Offset = "0x10")]
    private int mNextEnhanceNum;
    [Token(Token = "0x400F414")]
    [FieldOffset(Offset = "0x14")]
    private int mEnhanceLevel;
    [Token(Token = "0x400F415")]
    [FieldOffset(Offset = "0x18")]
    private int mEvoLevel;
    [Token(Token = "0x400F416")]
    [FieldOffset(Offset = "0x1C")]
    private BindRuneData mRune;
    [Token(Token = "0x400F417")]
    [FieldOffset(Offset = "0x20")]
    private int mEnhanceNum;
    [Token(Token = "0x400F418")]
    [FieldOffset(Offset = "0x24")]
    private List<RuneCost> mEnhanceCostList;
    [Token(Token = "0x400F419")]
    [FieldOffset(Offset = "0x28")]
    private List<RuneCost> mEvoCostList;
    [Token(Token = "0x400F41A")]
    [FieldOffset(Offset = "0x2C")]
    private string mDisplayText;
    [Token(Token = "0x400F41B")]
    [FieldOffset(Offset = "0x30")]
    private int mEnhanceBeforeDisplayLevel;
    [Token(Token = "0x400F41C")]
    [FieldOffset(Offset = "0x34")]
    private int mEnhanceMinLevelCap;
    [Token(Token = "0x400F41D")]
    [FieldOffset(Offset = "0x38")]
    private int mEvoMinLevelCap;

    [Token(Token = "0x17002006")]
    public bool IsVisible
    {
      [Token(Token = "0x600E5B6"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002007")]
    public int NowEnhanceNum
    {
      [Token(Token = "0x600E5B7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002008")]
    public int NextEnhanceNum
    {
      [Token(Token = "0x600E5B8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002009")]
    public int EnhanceNum
    {
      [Token(Token = "0x600E5B9"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700200A")]
    public int EnhanceLevel
    {
      [Token(Token = "0x600E5BA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700200B")]
    public int EvoLevel
    {
      [Token(Token = "0x600E5BB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700200C")]
    public BindRuneData Rune
    {
      [Token(Token = "0x600E5BC"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x1700200D")]
    public List<RuneCost> EnhanceCostList
    {
      [Token(Token = "0x600E5BD"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<RuneCost>) null;
      }
    }

    [Token(Token = "0x1700200E")]
    public List<RuneCost> EvoCostList
    {
      [Token(Token = "0x600E5BE"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<RuneCost>) null;
      }
    }

    [Token(Token = "0x1700200F")]
    public string DisplayText
    {
      [Token(Token = "0x600E5BF"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E5C0")]
    [Address(RVA = "0xAC08A0", Offset = "0xABF6A0", VA = "0x10AC08A0")]
    public void Initialize(BindRuneData rune)
    {
    }

    [Token(Token = "0x600E5C1")]
    [Address(RVA = "0xAC0780", Offset = "0xABF580", VA = "0x10AC0780")]
    public bool CheckEnhanceLevel(int enhance) => new bool();

    [Token(Token = "0x600E5C2")]
    [Address(RVA = "0xAC0800", Offset = "0xABF600", VA = "0x10AC0800")]
    public bool CheckEvoLevel(int evo) => new bool();

    [Token(Token = "0x600E5C3")]
    [Address(RVA = "0xAC09A0", Offset = "0xABF7A0", VA = "0x10AC09A0")]
    public void SetDefaultLevel()
    {
    }

    [Token(Token = "0x600E5C4")]
    [Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")]
    public void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x600E5C5")]
    [Address(RVA = "0xAC0BA0", Offset = "0xABF9A0", VA = "0x10AC0BA0")]
    public void SetEnhanceLevel(int enhance)
    {
    }

    [Token(Token = "0x600E5C6")]
    [Address(RVA = "0xAC0E70", Offset = "0xABFC70", VA = "0x10AC0E70")]
    public void SetEvoLevel(int evo)
    {
    }

    [Token(Token = "0x600E5C7")]
    [Address(RVA = "0xAC0C80", Offset = "0xABFA80", VA = "0x10AC0C80")]
    public void SetEnhanceNum()
    {
    }

    [Token(Token = "0x600E5C8")]
    [Address(RVA = "0xAC10C0", Offset = "0xABFEC0", VA = "0x10AC10C0")]
    public void SetText()
    {
    }

    [Token(Token = "0x600E5C9")]
    [Address(RVA = "0xAC0F50", Offset = "0xABFD50", VA = "0x10AC0F50")]
    public void SetMaterialList()
    {
    }

    [Token(Token = "0x600E5CA")]
    [Address(RVA = "0xAC0970", Offset = "0xABF770", VA = "0x10AC0970")]
    public bool IsRuneIconEvoVisible() => new bool();

    [Token(Token = "0x600E5CB")]
    [Address(RVA = "0xAC0880", Offset = "0xABF680", VA = "0x10AC0880")]
    public int GetEvoIconIndex() => new int();

    [Token(Token = "0x600E5CC")]
    [Address(RVA = "0xAC0950", Offset = "0xABF750", VA = "0x10AC0950")]
    public bool IsEnhanceDisplayLevelFluctuation() => new bool();

    [Token(Token = "0x600E5CD")]
    [Address(RVA = "0xAC1210", Offset = "0xAC0010", VA = "0x10AC1210")]
    public RuneContinueReinforcementModel()
    {
    }
  }
}
