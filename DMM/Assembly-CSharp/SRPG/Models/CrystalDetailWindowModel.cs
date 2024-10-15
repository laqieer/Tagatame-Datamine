// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalDetailWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200332A")]
  public class CrystalDetailWindowModel
  {
    [Token(Token = "0x400F174")]
    [FieldOffset(Offset = "0x28")]
    private CrystalData mData;
    [Token(Token = "0x400F175")]
    [FieldOffset(Offset = "0x2C")]
    private CrystalDetailWindowModel.CystalIconAdditionalData mAddData;

    [Token(Token = "0x17001DE9")]
    public bool IsFrameDisp
    {
      [Token(Token = "0x600E1BD"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1BE"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17001DEA")]
    public string CrystalName
    {
      [Token(Token = "0x600E1BF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E1C0"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001DEB")]
    public string CrystalImagePath
    {
      [Token(Token = "0x600E1C1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E1C2"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DEC")]
    public bool RankObj
    {
      [Token(Token = "0x600E1C3"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1C4"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17001DED")]
    public Sprite RankSprite
    {
      [Token(Token = "0x600E1C5"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E1C6"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001DEE")]
    public bool PlusObj
    {
      [Token(Token = "0x600E1C7"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1C8"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17001DEF")]
    public int PlusNum
    {
      [Token(Token = "0x600E1C9"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1CA"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
      {
      }
    }

    [Token(Token = "0x17001DF0")]
    public bool IsMaskDisp
    {
      [Token(Token = "0x600E1CB"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1CC"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] private set
      {
      }
    }

    [Token(Token = "0x17001DF1")]
    public bool IsDummy
    {
      [Token(Token = "0x600E1CD"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1CE"), Address(RVA = "0x6E63C0", Offset = "0x6E51C0", VA = "0x106E63C0")] private set
      {
      }
    }

    [Token(Token = "0x17001DF2")]
    public bool IsFavoriteDisp
    {
      [Token(Token = "0x600E1CF"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF3")]
    public bool IsFavoriteInteractable
    {
      [Token(Token = "0x600E1D0"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF4")]
    public bool IsDisassembleDisp
    {
      [Token(Token = "0x600E1D1"), Address(RVA = "0x972890", Offset = "0x971690", VA = "0x10972890")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF5")]
    public bool IsDisassembleInteractable
    {
      [Token(Token = "0x600E1D2"), Address(RVA = "0xAAD900", Offset = "0xAAC700", VA = "0x10AAD900")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF6")]
    public bool IsSetBonusDisp
    {
      [Token(Token = "0x600E1D3"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF7")]
    public bool IsSetBonusInteractable
    {
      [Token(Token = "0x600E1D4"), Address(RVA = "0x8E4B70", Offset = "0x8E3970", VA = "0x108E4B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF8")]
    public bool IsGradeUpDisp
    {
      [Token(Token = "0x600E1D5"), Address(RVA = "0xAAD910", Offset = "0xAAC710", VA = "0x10AAD910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DF9")]
    public bool IsGradeUpInteractable
    {
      [Token(Token = "0x600E1D6"), Address(RVA = "0x761750", Offset = "0x760550", VA = "0x10761750")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DFA")]
    public bool IsGradeUpAvailable
    {
      [Token(Token = "0x600E1D7"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DFB")]
    public bool IsAllUnequipDisp
    {
      [Token(Token = "0x600E1D8"), Address(RVA = "0x34AF90", Offset = "0x349D90", VA = "0x1034AF90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DFC")]
    public bool IsAllUnequipInteractable
    {
      [Token(Token = "0x600E1D9"), Address(RVA = "0xAAD8F0", Offset = "0xAAC6F0", VA = "0x10AAD8F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DFD")]
    public bool IsUsedPvEorGvG
    {
      [Token(Token = "0x600E1DA"), Address(RVA = "0xAAD940", Offset = "0xAAC740", VA = "0x10AAD940")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DFE")]
    public long IsID
    {
      [Token(Token = "0x600E1DB"), Address(RVA = "0xAAD920", Offset = "0xAAC720", VA = "0x10AAD920")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x600E1DC")]
    [Address(RVA = "0xAAD630", Offset = "0xAAC430", VA = "0x10AAD630")]
    public void SetData(
      CrystalData _data,
      CrystalDetailWindowModel.CystalIconAdditionalData _add_data)
    {
    }

    [Token(Token = "0x600E1DD")]
    [Address(RVA = "0xAAD4C0", Offset = "0xAAC2C0", VA = "0x10AAD4C0")]
    private void SetAdditionalDataSetting()
    {
    }

    [Token(Token = "0x600E1DE")]
    [Address(RVA = "0xAAD590", Offset = "0xAAC390", VA = "0x10AAD590")]
    private void SetCrystalName()
    {
    }

    [Token(Token = "0x600E1DF")]
    [Address(RVA = "0xAAD4D0", Offset = "0xAAC2D0", VA = "0x10AAD4D0")]
    private void SetCrystalImagePath()
    {
    }

    [Token(Token = "0x600E1E0")]
    [Address(RVA = "0xAAD870", Offset = "0xAAC670", VA = "0x10AAD870")]
    private void SetRankSprite()
    {
    }

    [Token(Token = "0x600E1E1")]
    [Address(RVA = "0xAAD830", Offset = "0xAAC630", VA = "0x10AAD830")]
    private void SetPlusText()
    {
    }

    [Token(Token = "0x600E1E2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalDetailWindowModel()
    {
    }

    [Token(Token = "0x200332B")]
    public struct CystalIconAdditionalData
    {
      [Token(Token = "0x400F176")]
      [FieldOffset(Offset = "0x0")]
      public bool mIsFrameDisp;
      [Token(Token = "0x400F177")]
      [FieldOffset(Offset = "0x1")]
      public bool mIsHaving;
      [Token(Token = "0x400F178")]
      [FieldOffset(Offset = "0x2")]
      public bool mIsRankDisp;
      [Token(Token = "0x400F179")]
      [FieldOffset(Offset = "0x3")]
      public bool mIsPlusDisp;
      [Token(Token = "0x400F17A")]
      [FieldOffset(Offset = "0x4")]
      public bool mIsFavoriteDisp;
      [Token(Token = "0x400F17B")]
      [FieldOffset(Offset = "0x5")]
      public bool mIsFavoriteInteractable;
      [Token(Token = "0x400F17C")]
      [FieldOffset(Offset = "0x6")]
      public bool mIsDisassembleDisp;
      [Token(Token = "0x400F17D")]
      [FieldOffset(Offset = "0x7")]
      public bool mIsDisassembleInteractable;
      [Token(Token = "0x400F17E")]
      [FieldOffset(Offset = "0x8")]
      public bool mIsSetBonusDisp;
      [Token(Token = "0x400F17F")]
      [FieldOffset(Offset = "0x9")]
      public bool mIsSetBonusInteractable;
      [Token(Token = "0x400F180")]
      [FieldOffset(Offset = "0xA")]
      public bool mIsGradeUpDisp;
      [Token(Token = "0x400F181")]
      [FieldOffset(Offset = "0xB")]
      public bool mIsGradeUpInteractable;
      [Token(Token = "0x400F182")]
      [FieldOffset(Offset = "0xC")]
      public bool mIsGradeUpAvailable;
      [Token(Token = "0x400F183")]
      [FieldOffset(Offset = "0xD")]
      public bool mIsAllUnequipDisp;
      [Token(Token = "0x400F184")]
      [FieldOffset(Offset = "0xE")]
      public bool mIsAllUnequipInteractable;
      [Token(Token = "0x400F185")]
      [FieldOffset(Offset = "0xF")]
      public bool mIsUsedPvEorGvG;
    }
  }
}
