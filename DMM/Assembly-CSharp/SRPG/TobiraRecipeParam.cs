// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D6E")]
  public class TobiraRecipeParam
  {
    [Token(Token = "0x40073F5")]
    [FieldOffset(Offset = "0x8")]
    private string mRecipeIname;
    [Token(Token = "0x40073F6")]
    [FieldOffset(Offset = "0xC")]
    private int mLevel;
    [Token(Token = "0x40073F7")]
    [FieldOffset(Offset = "0x10")]
    private int mCost;
    [Token(Token = "0x40073F8")]
    [FieldOffset(Offset = "0x14")]
    private int mUnitPieceNum;
    [Token(Token = "0x40073F9")]
    [FieldOffset(Offset = "0x18")]
    private int mElementNum;
    [Token(Token = "0x40073FA")]
    [FieldOffset(Offset = "0x1C")]
    private int mUnlockElementNum;
    [Token(Token = "0x40073FB")]
    [FieldOffset(Offset = "0x20")]
    private int mUnlockBirthNum;
    [Token(Token = "0x40073FC")]
    [FieldOffset(Offset = "0x24")]
    private List<TobiraRecipeMaterialParam> mMaterials;

    [Token(Token = "0x17001022")]
    public string RecipeIname
    {
      [Token(Token = "0x600787C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001023")]
    public int Level
    {
      [Token(Token = "0x600787D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001024")]
    public int Cost
    {
      [Token(Token = "0x600787E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001025")]
    public int UnitPieceNum
    {
      [Token(Token = "0x600787F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001026")]
    public int ElementNum
    {
      [Token(Token = "0x6007880"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001027")]
    public int UnlockElementNum
    {
      [Token(Token = "0x6007881"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001028")]
    public int UnlockBirthNum
    {
      [Token(Token = "0x6007882"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001029")]
    public TobiraRecipeMaterialParam[] Materials
    {
      [Token(Token = "0x6007883"), Address(RVA = "0x3A4D40", Offset = "0x3A3B40", VA = "0x103A4D40")] get
      {
        return (TobiraRecipeMaterialParam[]) null;
      }
    }

    [Token(Token = "0x6007884")]
    [Address(RVA = "0x3A4B70", Offset = "0x3A3970", VA = "0x103A4B70")]
    public void Deserialize(JSON_TobiraRecipeParam json)
    {
    }

    [Token(Token = "0x6007885")]
    [Address(RVA = "0x3A4CD0", Offset = "0x3A3AD0", VA = "0x103A4CD0")]
    public TobiraRecipeParam()
    {
    }
  }
}
