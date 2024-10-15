// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtiStoneEffect_ExchangeConfirmModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003308")]
  public class ArtiStoneEffect_ExchangeConfirmModel
  {
    [Token(Token = "0x400F03D")]
    private const string RARITY_CHECK_CAUTION_TEXT = "sys.ARTI_RARITY_CHECK_CAUTION";
    [Token(Token = "0x400F03E")]
    [FieldOffset(Offset = "0x8")]
    private List<long> mArtifactIds;
    [Token(Token = "0x400F03F")]
    [FieldOffset(Offset = "0xC")]
    private List<ArtifactData> mArtifacts;
    [Token(Token = "0x400F040")]
    [FieldOffset(Offset = "0x10")]
    private List<ArtifactIconBlockContentNodeModel> mArtifactModels;
    [Token(Token = "0x400F041")]
    [FieldOffset(Offset = "0x14")]
    private List<ArtifactIconBlockContentNodeModel> mRarityCheckArtifactModels;
    [Token(Token = "0x400F042")]
    [FieldOffset(Offset = "0x18")]
    private int mHaveExchangeItemNum;
    [Token(Token = "0x400F043")]
    [FieldOffset(Offset = "0x1C")]
    private int mAfterHaveExchangeItemNum;
    [Token(Token = "0x400F044")]
    [FieldOffset(Offset = "0x20")]
    private int mSelectNum;
    [Token(Token = "0x400F045")]
    [FieldOffset(Offset = "0x24")]
    private int mExchangeItemNum;
    [Token(Token = "0x400F046")]
    private const int CheckRarityLine = 3;
    [Token(Token = "0x400F047")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsArtifactCheck;
    [Token(Token = "0x400F048")]
    [FieldOffset(Offset = "0x29")]
    private bool mIsRarityCheck;
    [Token(Token = "0x400F049")]
    [FieldOffset(Offset = "0x2A")]
    private bool mIsRarityCheckArtifact;
    [Token(Token = "0x400F04A")]
    [FieldOffset(Offset = "0x2C")]
    private string mRarityCheckCautionText;

    [Token(Token = "0x17001D43")]
    public List<long> ArtifactIds
    {
      [Token(Token = "0x600E039"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001D44")]
    public List<ArtifactData> Artifacts
    {
      [Token(Token = "0x600E03A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ArtifactData>) null;
      }
    }

    [Token(Token = "0x17001D45")]
    public List<ArtifactIconBlockContentNodeModel> ArtifactModels
    {
      [Token(Token = "0x600E03B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<ArtifactIconBlockContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001D46")]
    public List<ArtifactIconBlockContentNodeModel> RarityCheckArtifactModels
    {
      [Token(Token = "0x600E03C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<ArtifactIconBlockContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001D47")]
    public int HaveExchangeItemNum
    {
      [Token(Token = "0x600E03D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D48")]
    public int AfterHaveExchangeItemNum
    {
      [Token(Token = "0x600E03E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D49")]
    public int SelectNum
    {
      [Token(Token = "0x600E03F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D4A")]
    public int ExchangeItemNum
    {
      [Token(Token = "0x600E040"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D4B")]
    public bool IsArtifactCheck
    {
      [Token(Token = "0x600E041"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D4C")]
    public bool IsRarityCheck
    {
      [Token(Token = "0x600E042"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D4D")]
    public bool IsRarityCheckArtifact
    {
      [Token(Token = "0x600E043"), Address(RVA = "0x51AB90", Offset = "0x519990", VA = "0x1051AB90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D4E")]
    public string RarityCheckCautionText
    {
      [Token(Token = "0x600E044"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E045")]
    [Address(RVA = "0xAA3930", Offset = "0xAA2730", VA = "0x10AA3930")]
    public void Initialize(List<ArtifactData> artifacts)
    {
    }

    [Token(Token = "0x600E046")]
    [Address(RVA = "0xAA3970", Offset = "0xAA2770", VA = "0x10AA3970")]
    private void SetData()
    {
    }

    [Token(Token = "0x600E047")]
    [Address(RVA = "0xAA3910", Offset = "0xAA2710", VA = "0x10AA3910")]
    public void ChangeWindow(bool is_artifact)
    {
    }

    [Token(Token = "0x600E048")]
    [Address(RVA = "0xAA3F10", Offset = "0xAA2D10", VA = "0x10AA3F10")]
    public void SetIds()
    {
    }

    [Token(Token = "0x600E049")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtiStoneEffect_ExchangeConfirmModel()
    {
    }
  }
}
