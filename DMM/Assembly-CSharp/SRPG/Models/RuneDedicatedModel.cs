// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDedicatedModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200338B")]
  public class RuneDedicatedModel
  {
    [Token(Token = "0x400F3DF")]
    [FieldOffset(Offset = "0x8")]
    private RuneData selectedRuneData;
    [Token(Token = "0x400F3E0")]
    [FieldOffset(Offset = "0xC")]
    private UnitData selectedUnitData;
    [Token(Token = "0x400F3E1")]
    [FieldOffset(Offset = "0x10")]
    private string runeType;
    [Token(Token = "0x400F3E2")]
    [FieldOffset(Offset = "0x14")]
    private BaseStatus baseAddStatus;
    [Token(Token = "0x400F3E3")]
    [FieldOffset(Offset = "0x18")]
    private BaseStatus baseScaleStatus;
    [Token(Token = "0x400F3E4")]
    [FieldOffset(Offset = "0x1C")]
    private string beforeRuneName;
    [Token(Token = "0x400F3E5")]
    [FieldOffset(Offset = "0x20")]
    private string beforeRuneDedicatedConditions;
    [Token(Token = "0x400F3E6")]
    [FieldOffset(Offset = "0x24")]
    private Color beforeRuneTextColor;
    [Token(Token = "0x400F3E7")]
    [FieldOffset(Offset = "0x34")]
    private string afterRuneName;
    [Token(Token = "0x400F3E8")]
    [FieldOffset(Offset = "0x38")]
    private string afterRuneDedicatedConditions;
    [Token(Token = "0x400F3E9")]
    [FieldOffset(Offset = "0x3C")]
    private Color afterRuneTextColor;
    [Token(Token = "0x400F3EA")]
    [FieldOffset(Offset = "0x4C")]
    private int costGold;
    [Token(Token = "0x400F3EB")]
    [FieldOffset(Offset = "0x50")]
    private int costCoin;
    [Token(Token = "0x400F3EC")]
    [FieldOffset(Offset = "0x54")]
    private bool canDedicated;
    [Token(Token = "0x400F3ED")]
    [FieldOffset(Offset = "0x58")]
    private string unitImagePath;
    [Token(Token = "0x400F3EE")]
    [FieldOffset(Offset = "0x5C")]
    private Vector2 unitImageAnchoredPosition;
    [Token(Token = "0x400F3EF")]
    [FieldOffset(Offset = "0x64")]
    private Color defaultRuneTextColor;
    [Token(Token = "0x400F3F0")]
    [FieldOffset(Offset = "0x74")]
    private Color dedicatedRuneTextColor;

    [Token(Token = "0x17001FD7")]
    public RuneData SelectedRuneData
    {
      [Token(Token = "0x600E56B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (RuneData) null;
      }
    }

    [Token(Token = "0x17001FD8")]
    public UnitData SelectedUnitData
    {
      [Token(Token = "0x600E56C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001FD9")]
    public string RuneType
    {
      [Token(Token = "0x600E56D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FDA")]
    public BaseStatus BaseAddStatus
    {
      [Token(Token = "0x600E56E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x17001FDB")]
    public BaseStatus BaseScaleStatus
    {
      [Token(Token = "0x600E56F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (BaseStatus) null;
      }
    }

    [Token(Token = "0x17001FDC")]
    public string BeforeRuneName
    {
      [Token(Token = "0x600E570"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FDD")]
    public string BeforeRuneDedicatedConditions
    {
      [Token(Token = "0x600E571"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FDE")]
    public Color BeforeRuneTextColor
    {
      [Token(Token = "0x600E572"), Address(RVA = "0xAB37E0", Offset = "0xAB25E0", VA = "0x10AB37E0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001FDF")]
    public bool BeforeRuneIsDedicated
    {
      [Token(Token = "0x600E573"), Address(RVA = "0xAC2120", Offset = "0xAC0F20", VA = "0x10AC2120")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FE0")]
    public string AfterRuneName
    {
      [Token(Token = "0x600E574"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FE1")]
    public string AfterRuneDedicatedConditions
    {
      [Token(Token = "0x600E575"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FE2")]
    public Color AfterRuneTextColor
    {
      [Token(Token = "0x600E576"), Address(RVA = "0xAC2100", Offset = "0xAC0F00", VA = "0x10AC2100")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001FE3")]
    public bool AfterRuneIsDedicated
    {
      [Token(Token = "0x600E577"), Address(RVA = "0xAC20D0", Offset = "0xAC0ED0", VA = "0x10AC20D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FE4")]
    public int CostGold
    {
      [Token(Token = "0x600E578"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FE5")]
    public int CostCoin
    {
      [Token(Token = "0x600E579"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FE6")]
    public bool IsUseGold
    {
      [Token(Token = "0x600E57A"), Address(RVA = "0xAC2160", Offset = "0xAC0F60", VA = "0x10AC2160")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FE7")]
    public bool IsUseCoin
    {
      [Token(Token = "0x600E57B"), Address(RVA = "0xAC2150", Offset = "0xAC0F50", VA = "0x10AC2150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FE8")]
    public bool IsDedicated
    {
      [Token(Token = "0x600E57C"), Address(RVA = "0xAC2120", Offset = "0xAC0F20", VA = "0x10AC2120")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FE9")]
    public bool CanDedicated
    {
      [Token(Token = "0x600E57D"), Address(RVA = "0x2AABC0", Offset = "0x2A99C0", VA = "0x102AABC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FEA")]
    public string UnitImagePath
    {
      [Token(Token = "0x600E57E"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FEB")]
    public Vector2 UnitImageAnchoredPosition
    {
      [Token(Token = "0x600E57F"), Address(RVA = "0xAC2170", Offset = "0xAC0F70", VA = "0x10AC2170")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x600E580")]
    [Address(RVA = "0xAC1B10", Offset = "0xAC0910", VA = "0x10AC1B10")]
    public void Initialize(RuneData runeData, UnitData unitData)
    {
    }

    [Token(Token = "0x600E581")]
    [Address(RVA = "0xAC1470", Offset = "0xAC0270", VA = "0x10AC1470")]
    public void Initialize(
      RuneData runeData,
      UnitData unitData,
      Color defaultColor,
      Color dedicatedColor)
    {
    }

    [Token(Token = "0x600E582")]
    [Address(RVA = "0xAC1B50", Offset = "0xAC0950", VA = "0x10AC1B50")]
    private (string, string, Color) SetupRuneStatusData(
      RuneData runeData,
      UnitData unitData,
      bool is_dedicated)
    {
      return ();
    }

    [Token(Token = "0x600E583")]
    [Address(RVA = "0xAC20A0", Offset = "0xAC0EA0", VA = "0x10AC20A0")]
    public RuneDedicatedModel()
    {
    }
  }
}
