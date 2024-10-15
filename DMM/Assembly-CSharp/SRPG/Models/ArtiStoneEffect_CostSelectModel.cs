// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtiStoneEffect_CostSelectModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003307")]
  public class ArtiStoneEffect_CostSelectModel
  {
    [Token(Token = "0x400F02A")]
    [FieldOffset(Offset = "0x8")]
    private ArtifactData mArtifactData;
    [Token(Token = "0x400F02B")]
    [FieldOffset(Offset = "0xC")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400F02C")]
    [FieldOffset(Offset = "0x10")]
    private List<ArtifactData> mCostArtifactDataList;
    [Token(Token = "0x400F02D")]
    [FieldOffset(Offset = "0x14")]
    private List<long> mCostArtifactIdList;
    [Token(Token = "0x400F02E")]
    [FieldOffset(Offset = "0x18")]
    private bool mCostButtonInteractable;
    [Token(Token = "0x400F02F")]
    [FieldOffset(Offset = "0x19")]
    private bool mOtherCostButtonInteractable;
    [Token(Token = "0x400F030")]
    [FieldOffset(Offset = "0x1C")]
    private int mOtherCostNum;
    [Token(Token = "0x400F031")]
    [FieldOffset(Offset = "0x20")]
    private Color32 mOtherCostNumColor;
    [Token(Token = "0x400F032")]
    [FieldOffset(Offset = "0x24")]
    private int mSelectNum;
    [Token(Token = "0x400F033")]
    [FieldOffset(Offset = "0x28")]
    private Color32 mSelectNumColor;
    [Token(Token = "0x400F034")]
    [FieldOffset(Offset = "0x2C")]
    private int mCostGoldNum;
    [Token(Token = "0x400F035")]
    [FieldOffset(Offset = "0x30")]
    private Color32 mCostGoldNumColor;
    [Token(Token = "0x400F036")]
    [FieldOffset(Offset = "0x34")]
    private int mNeedCost;
    [Token(Token = "0x400F037")]
    [FieldOffset(Offset = "0x38")]
    private int mNeedOtherCost;
    [Token(Token = "0x400F038")]
    [FieldOffset(Offset = "0x3C")]
    private string mOtherCostIconPath;
    [Token(Token = "0x400F039")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsHaveNeedGold;
    [Token(Token = "0x400F03A")]
    [FieldOffset(Offset = "0x41")]
    private bool mIsOpenStone;
    [Token(Token = "0x400F03B")]
    [FieldOffset(Offset = "0x44")]
    private Color32 mDefaultColor;
    [Token(Token = "0x400F03C")]
    [FieldOffset(Offset = "0x48")]
    private Color32 mMinusColor;

    [Token(Token = "0x17001D32")]
    public ArtifactData ArtifactData
    {
      [Token(Token = "0x600E020"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ArtifactData) null;
      }
    }

    [Token(Token = "0x17001D33")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x600E021"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x17001D34")]
    public List<ArtifactData> CostArtifactDataList
    {
      [Token(Token = "0x600E022"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<ArtifactData>) null;
      }
    }

    [Token(Token = "0x17001D35")]
    public List<long> CostArtifactIdList
    {
      [Token(Token = "0x600E023"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001D36")]
    public bool CostButtonInteractable
    {
      [Token(Token = "0x600E024"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D37")]
    public bool OtherCostButtonInteractable
    {
      [Token(Token = "0x600E025"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D38")]
    public int OtherCostNum
    {
      [Token(Token = "0x600E026"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D39")]
    public Color32 OtherCostNumColor
    {
      [Token(Token = "0x600E027"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new Color32();
      }
    }

    [Token(Token = "0x17001D3A")]
    public int SelectNum
    {
      [Token(Token = "0x600E028"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D3B")]
    public int NeedCost
    {
      [Token(Token = "0x600E029"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D3C")]
    public Color32 SelectNumColor
    {
      [Token(Token = "0x600E02A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new Color32();
      }
    }

    [Token(Token = "0x17001D3D")]
    public int CostGoldNum
    {
      [Token(Token = "0x600E02B"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D3E")]
    public Color32 CostGoldNumColor
    {
      [Token(Token = "0x600E02C"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new Color32();
      }
    }

    [Token(Token = "0x17001D3F")]
    public bool IsGoldCost
    {
      [Token(Token = "0x600E02D"), Address(RVA = "0xAA3900", Offset = "0xAA2700", VA = "0x10AA3900")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D40")]
    public bool IsClear
    {
      [Token(Token = "0x600E02E"), Address(RVA = "0xAA38F0", Offset = "0xAA26F0", VA = "0x10AA38F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D41")]
    public int NeedOtherCost
    {
      [Token(Token = "0x600E02F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D42")]
    public string OtherCostIconPath
    {
      [Token(Token = "0x600E030"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E031")]
    [Address(RVA = "0xAA3890", Offset = "0xAA2690", VA = "0x10AA3890")]
    public ArtiStoneEffect_CostSelectModel(Color32 defaultColor, Color32 minusColor)
    {
    }

    [Token(Token = "0x600E032")]
    [Address(RVA = "0xAA2E90", Offset = "0xAA1C90", VA = "0x10AA2E90")]
    public void Initialize(ArtifactData artifact)
    {
    }

    [Token(Token = "0x600E033")]
    [Address(RVA = "0xAA3500", Offset = "0xAA2300", VA = "0x10AA3500")]
    private void SetCost()
    {
    }

    [Token(Token = "0x600E034")]
    [Address(RVA = "0xAA34A0", Offset = "0xAA22A0", VA = "0x10AA34A0")]
    private void SetCostButtonInteractable()
    {
    }

    [Token(Token = "0x600E035")]
    [Address(RVA = "0xAA37D0", Offset = "0xAA25D0", VA = "0x10AA37D0")]
    private void SetOtherCostButtonInteractable()
    {
    }

    [Token(Token = "0x600E036")]
    [Address(RVA = "0xAA36C0", Offset = "0xAA24C0", VA = "0x10AA36C0")]
    private void SetGoldCost()
    {
    }

    [Token(Token = "0x600E037")]
    [Address(RVA = "0xAA3800", Offset = "0xAA2600", VA = "0x10AA3800")]
    private void SetOtherCostIcon(ItemParam param)
    {
    }

    [Token(Token = "0x600E038")]
    [Address(RVA = "0xAA3230", Offset = "0xAA2030", VA = "0x10AA3230")]
    public void RefreshCost(List<ArtifactData> artifacts)
    {
    }
  }
}
