// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDrawCostBlockModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003393")]
  public class RuneDrawCostBlockModel
  {
    [Token(Token = "0x400F41E")]
    [FieldOffset(Offset = "0x8")]
    private bool mVisible;
    [Token(Token = "0x400F41F")]
    [FieldOffset(Offset = "0xC")]
    private string mCostImagePath;
    [Token(Token = "0x400F420")]
    [FieldOffset(Offset = "0x10")]
    private int mCostValue;
    [Token(Token = "0x400F421")]
    [FieldOffset(Offset = "0x14")]
    private int mCostHaveValue;
    [Token(Token = "0x400F422")]
    [FieldOffset(Offset = "0x18")]
    private Color32 mCostHaveValueColor;
    [Token(Token = "0x400F423")]
    [FieldOffset(Offset = "0x1C")]
    private string mCostColorCode;
    [Token(Token = "0x400F424")]
    [FieldOffset(Offset = "0x20")]
    private Color32 mCostHaveDefaultColor;
    [Token(Token = "0x400F425")]
    [FieldOffset(Offset = "0x24")]
    private Color32 mCostHaveMinusColor;

    [Token(Token = "0x17002010")]
    public bool Visible
    {
      [Token(Token = "0x600E5CE"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002011")]
    public string CostImagePath
    {
      [Token(Token = "0x600E5CF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002012")]
    public string CostValue
    {
      [Token(Token = "0x600E5D0"), Address(RVA = "0xABB560", Offset = "0xABA360", VA = "0x10ABB560")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002013")]
    public string CostHaveValue
    {
      [Token(Token = "0x600E5D1"), Address(RVA = "0xAC2F00", Offset = "0xAC1D00", VA = "0x10AC2F00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002014")]
    public Color32 CostHaveValueColor
    {
      [Token(Token = "0x600E5D2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new Color32();
      }
    }

    [Token(Token = "0x17002015")]
    public string CostValuePerHave
    {
      [Token(Token = "0x600E5D3"), Address(RVA = "0xAC30F0", Offset = "0xAC1EF0", VA = "0x10AC30F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002016")]
    public string CostColorCode
    {
      [Token(Token = "0x600E5D4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E5D5")]
    [Address(RVA = "0xAC2E30", Offset = "0xAC1C30", VA = "0x10AC2E30")]
    public void Initialize(
      string image_path,
      int value,
      int have_value,
      Color32 default_color,
      Color32 minus_color)
    {
    }

    [Token(Token = "0x600E5D6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDrawCostBlockModel()
    {
    }
  }
}
