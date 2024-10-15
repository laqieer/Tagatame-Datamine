// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalGradeUpWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003333")]
  public class CrystalGradeUpWindowModel
  {
    [Token(Token = "0x400F1A9")]
    [FieldOffset(Offset = "0x8")]
    private CrystalData mData;
    [Token(Token = "0x400F1AA")]
    [FieldOffset(Offset = "0xC")]
    private Sprite mRankSprite;
    [Token(Token = "0x400F1AB")]
    [FieldOffset(Offset = "0x10")]
    private Sprite mRankSpriteAfter;

    [Token(Token = "0x17001E1F")]
    public string CrystalName
    {
      [Token(Token = "0x600E232"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E233"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17001E20")]
    public string CrystalImagePath
    {
      [Token(Token = "0x600E234"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E235"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001E21")]
    public bool RankObj
    {
      [Token(Token = "0x600E236"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E237"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17001E22")]
    public Sprite RankSprite
    {
      [Token(Token = "0x600E238"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E23")]
    public Sprite RankSpriteAfter
    {
      [Token(Token = "0x600E239"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E24")]
    public CrystalData MaterialCrystal
    {
      [Token(Token = "0x600E23A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (CrystalData) null;
      }
      [Token(Token = "0x600E23B"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17001E25")]
    public CrystalData ResultCrystal
    {
      [Token(Token = "0x600E23C"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (CrystalData) null;
      }
      [Token(Token = "0x600E23D"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x17001E26")]
    public bool IsSelect
    {
      [Token(Token = "0x600E23E"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E23F"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x600E240")]
    [Address(RVA = "0xAAE050", Offset = "0xAACE50", VA = "0x10AAE050")]
    public void SetData(CrystalData _data)
    {
    }

    [Token(Token = "0x600E241")]
    [Address(RVA = "0xAAD220", Offset = "0xAAC020", VA = "0x10AAD220")]
    private void SetRankSprite(ref Sprite sprite, CrystalData data)
    {
    }

    [Token(Token = "0x600E242")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalGradeUpWindowModel()
    {
    }
  }
}
