// Decompiled with JetBrains decompiler
// Type: SRPG.Models.NamePlateModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003371")]
  public class NamePlateModel
  {
    [Token(Token = "0x400F31A")]
    private const string DEFAULT_NAME = "sys.UNITTOOLTIPEX_DEFAULT_NAME";
    [Token(Token = "0x400F31B")]
    [FieldOffset(Offset = "0x8")]
    private Sprite mElementSprite;
    [Token(Token = "0x400F31C")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x400F31D")]
    [FieldOffset(Offset = "0x10")]
    private int mBirthId;
    [Token(Token = "0x400F31E")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsHideElement;
    [Token(Token = "0x400F31F")]
    [FieldOffset(Offset = "0x15")]
    private bool mIsHideName;
    [Token(Token = "0x400F320")]
    [FieldOffset(Offset = "0x16")]
    private bool mIsHideBirth;

    [Token(Token = "0x17001F3F")]
    public Sprite ElementSprite
    {
      [Token(Token = "0x600E45C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001F40")]
    public string Name
    {
      [Token(Token = "0x600E45D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F41")]
    public int BirthId
    {
      [Token(Token = "0x600E45E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F42")]
    public string BirthIdKey
    {
      [Token(Token = "0x600E45F"), Address(RVA = "0xABB560", Offset = "0xABA360", VA = "0x10ABB560")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F43")]
    public bool IsHideElement
    {
      [Token(Token = "0x600E460"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F44")]
    public bool IsHideName
    {
      [Token(Token = "0x600E461"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F45")]
    public bool IsHideBirth
    {
      [Token(Token = "0x600E462"), Address(RVA = "0x7B1D20", Offset = "0x7B0B20", VA = "0x107B1D20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E463")]
    [Address(RVA = "0xABB530", Offset = "0xABA330", VA = "0x10ABB530")]
    public NamePlateModel(bool isHideElement = false, bool isHideName = false, bool isHideBirth = false)
    {
    }

    [Token(Token = "0x600E464")]
    [Address(RVA = "0xABB380", Offset = "0xABA180", VA = "0x10ABB380")]
    public void Initialize(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E465")]
    [Address(RVA = "0xABB380", Offset = "0xABA180", VA = "0x10ABB380")]
    public void SetupParam(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E466")]
    [Address(RVA = "0xABB4A0", Offset = "0xABA2A0", VA = "0x10ABB4A0")]
    private void SetElement(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E467")]
    [Address(RVA = "0xABB500", Offset = "0xABA300", VA = "0x10ABB500")]
    private void SetName(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E468")]
    [Address(RVA = "0xABB470", Offset = "0xABA270", VA = "0x10ABB470")]
    private void SetBirth(UnitData unitdata)
    {
    }
  }
}
