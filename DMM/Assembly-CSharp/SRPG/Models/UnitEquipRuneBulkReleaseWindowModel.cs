// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitEquipRuneBulkReleaseWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033A8")]
  public class UnitEquipRuneBulkReleaseWindowModel
  {
    [Token(Token = "0x400F467")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsToggle;
    [Token(Token = "0x400F468")]
    [FieldOffset(Offset = "0x9")]
    private bool mIsInteractable;

    [Token(Token = "0x17002037")]
    public bool IsToggle
    {
      [Token(Token = "0x600E67C"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002038")]
    public bool IsInteractable
    {
      [Token(Token = "0x600E67D"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E67E")]
    [Address(RVA = "0xACFD70", Offset = "0xACEB70", VA = "0x10ACFD70")]
    public void Initialize(bool isSave)
    {
    }

    [Token(Token = "0x600E67F")]
    [Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")]
    public void SetToggle(bool isflag)
    {
    }

    [Token(Token = "0x600E680")]
    [Address(RVA = "0x3FA400", Offset = "0x3F9200", VA = "0x103FA400")]
    public void SetInteractable(bool isflag)
    {
    }

    [Token(Token = "0x600E681")]
    [Address(RVA = "0xACFDF0", Offset = "0xACEBF0", VA = "0x10ACFDF0")]
    public void LoadToggle()
    {
    }

    [Token(Token = "0x600E682")]
    [Address(RVA = "0xACFE50", Offset = "0xACEC50", VA = "0x10ACFE50")]
    public void SaveToggle()
    {
    }

    [Token(Token = "0x600E683")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitEquipRuneBulkReleaseWindowModel()
    {
    }
  }
}
