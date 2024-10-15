// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalDisassembleWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200332D")]
  public class CrystalDisassembleWindowModel
  {
    [Token(Token = "0x400F18F")]
    [FieldOffset(Offset = "0x8")]
    private CrystalData mData;
    [Token(Token = "0x400F190")]
    [FieldOffset(Offset = "0xC")]
    private string mCrystalName;
    [Token(Token = "0x400F191")]
    [FieldOffset(Offset = "0x10")]
    private Sprite mRankSprite;

    [Token(Token = "0x17001E08")]
    public string CrystalName
    {
      [Token(Token = "0x600E1FB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E09")]
    public CrystalData BaseCrystal
    {
      [Token(Token = "0x600E1FC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (CrystalData) null;
      }
    }

    [Token(Token = "0x17001E0A")]
    public Sprite RankSprite
    {
      [Token(Token = "0x600E1FD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x600E1FE")]
    [Address(RVA = "0xAAD950", Offset = "0xAAC750", VA = "0x10AAD950")]
    public void SetData(CrystalData _data)
    {
    }

    [Token(Token = "0x600E1FF")]
    [Address(RVA = "0xAADA60", Offset = "0xAAC860", VA = "0x10AADA60")]
    private void SetName()
    {
    }

    [Token(Token = "0x600E200")]
    [Address(RVA = "0xAADAB0", Offset = "0xAAC8B0", VA = "0x10AADAB0")]
    private void SetRankSprite()
    {
    }

    [Token(Token = "0x600E201")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalDisassembleWindowModel()
    {
    }
  }
}
