// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchUnitHideModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003356")]
  public class LeagueMatchUnitHideModel
  {
    [Token(Token = "0x400F252")]
    [FieldOffset(Offset = "0x8")]
    private LeagueMatchSettingParam _settingParam;

    [Token(Token = "0x17001E9C")]
    public bool UnitEditShow
    {
      [Token(Token = "0x600E34E"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E34F"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x17001E9D")]
    public bool UnitJobShow
    {
      [Token(Token = "0x600E350"), Address(RVA = "0xABA5F0", Offset = "0xAB93F0", VA = "0x10ABA5F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E9E")]
    public bool UnitLevelShow
    {
      [Token(Token = "0x600E351"), Address(RVA = "0xABA620", Offset = "0xAB9420", VA = "0x10ABA620")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E9F")]
    public bool UnitRarityShow
    {
      [Token(Token = "0x600E352"), Address(RVA = "0xABA650", Offset = "0xAB9450", VA = "0x10ABA650")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E353")]
    [Address(RVA = "0xABA3E0", Offset = "0xAB91E0", VA = "0x10ABA3E0")]
    public void Initialize(int index)
    {
    }

    [Token(Token = "0x600E354")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchUnitHideModel()
    {
    }
  }
}
