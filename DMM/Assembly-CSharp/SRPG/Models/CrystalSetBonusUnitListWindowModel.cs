// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalSetBonusUnitListWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003334")]
  public class CrystalSetBonusUnitListWindowModel
  {
    [Token(Token = "0x17001E27")]
    public CrystalParam CrystalParam
    {
      [Token(Token = "0x600E243"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (CrystalParam) null;
      }
      [Token(Token = "0x600E244"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001E28")]
    public bool IsSelect
    {
      [Token(Token = "0x600E245"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E246"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x600E247")]
    [Address(RVA = "0xAB0530", Offset = "0xAAF330", VA = "0x10AB0530")]
    public void Initialize(CrystalParam param, bool is_select)
    {
    }

    [Token(Token = "0x600E248")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSetBonusUnitListWindowModel()
    {
    }
  }
}
