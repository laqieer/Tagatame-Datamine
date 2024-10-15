// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalIconModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200331B")]
  public class CrystalIconModel
  {
    [Token(Token = "0x400F110")]
    [FieldOffset(Offset = "0x20")]
    private CrystalData mData;
    [Token(Token = "0x400F111")]
    [FieldOffset(Offset = "0x24")]
    private CrystalParam mParam;
    [Token(Token = "0x400F112")]
    [FieldOffset(Offset = "0x28")]
    private CrystalIconModel.CystalIconAdditionalData mAddData;

    [Token(Token = "0x17001DAE")]
    public string IconImagePath
    {
      [Token(Token = "0x600E123"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E124"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001DAF")]
    public bool RankDisp
    {
      [Token(Token = "0x600E125"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E126"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x17001DB0")]
    public int RankIndex
    {
      [Token(Token = "0x600E127"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E128"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB1")]
    public bool PlusDisp
    {
      [Token(Token = "0x600E129"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E12A"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17001DB2")]
    public int PlusNum
    {
      [Token(Token = "0x600E12B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600E12C"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17001DB3")]
    public bool IsNoHavingMaskDisp
    {
      [Token(Token = "0x600E12D"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E12E"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB4")]
    public bool RankFrameDisp
    {
      [Token(Token = "0x600E12F"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E130"), Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB5")]
    public bool FrameDispDummy
    {
      [Token(Token = "0x600E131"), Address(RVA = "0x2AA810", Offset = "0x2A9610", VA = "0x102AA810")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E132"), Address(RVA = "0x2AA830", Offset = "0x2A9630", VA = "0x102AA830")] private set
      {
      }
    }

    [Token(Token = "0x600E133")]
    [Address(RVA = "0xAAE190", Offset = "0xAACF90", VA = "0x10AAE190")]
    public void SetData(
      CrystalData _data,
      CrystalParam _param,
      CrystalIconModel.CystalIconAdditionalData _add_data)
    {
    }

    [Token(Token = "0x600E134")]
    [Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")]
    public void ForceDispMask(bool is_mask)
    {
    }

    [Token(Token = "0x600E135")]
    [Address(RVA = "0xAAE500", Offset = "0xAAD300", VA = "0x10AAE500")]
    private void SetIconImagePath()
    {
    }

    [Token(Token = "0x600E136")]
    [Address(RVA = "0xAAE5D0", Offset = "0xAAD3D0", VA = "0x10AAE5D0")]
    private void SetRankDisp()
    {
    }

    [Token(Token = "0x600E137")]
    [Address(RVA = "0xAAE5A0", Offset = "0xAAD3A0", VA = "0x10AAE5A0")]
    private void SetPlusDisp()
    {
    }

    [Token(Token = "0x600E138")]
    [Address(RVA = "0xAAE3E0", Offset = "0xAAD1E0", VA = "0x10AAE3E0")]
    private void SetHavingMask()
    {
    }

    [Token(Token = "0x600E139")]
    [Address(RVA = "0xAAE610", Offset = "0xAAD410", VA = "0x10AAE610")]
    private void SetRankFrameDisp()
    {
    }

    [Token(Token = "0x600E13A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalIconModel()
    {
    }

    [Token(Token = "0x200331C")]
    public struct CystalIconAdditionalData
    {
      [Token(Token = "0x400F113")]
      [FieldOffset(Offset = "0x0")]
      public bool mIsNoHavingMaskDisp;
      [Token(Token = "0x400F114")]
      [FieldOffset(Offset = "0x1")]
      public bool mIsRankDisp;
      [Token(Token = "0x400F115")]
      [FieldOffset(Offset = "0x2")]
      public bool mIsPlusDisp;
      [Token(Token = "0x400F116")]
      [FieldOffset(Offset = "0x3")]
      public bool mIsRankFrameDisp;
    }
  }
}
