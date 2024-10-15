// Decompiled with JetBrains decompiler
// Type: SRPG.Models.AllUnitEquipBulkReleaseConfirmWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003339")]
  public class AllUnitEquipBulkReleaseConfirmWindowModel
  {
    [Token(Token = "0x400F1C7")]
    private const string TARGET_RUNE = "sys.COMMON_RUNE";
    [Token(Token = "0x400F1C8")]
    private const string TARGET_CRYSTAL = "sys.COMMON_CRYSTAL";
    [Token(Token = "0x400F1C9")]
    private const string TITLE_TEXT = "sys.ALL_UNIT_EQUIP_BULK_RELEASE_CONFIRM_TITLE";
    [Token(Token = "0x400F1CA")]
    private const string MAIN_TEXT = "sys.EQUIP_BULK_RELEASE_CONFIRM_TEXT";
    [Token(Token = "0x400F1CB")]
    private const string MAIN_ALL_TARGET_TEXT = "sys.ALL_UNIT_EQUIP_BULK_RELEASE_CONFIRM_TEXT";
    [Token(Token = "0x400F1CC")]
    [FieldOffset(Offset = "0x8")]
    private BulkReleaseWindow.Type mType;
    [Token(Token = "0x400F1CD")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsIntaractable;
    [Token(Token = "0x400F1CE")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsAll;
    [Token(Token = "0x400F1CF")]
    [FieldOffset(Offset = "0x10")]
    private string mTargetText;
    [Token(Token = "0x400F1D0")]
    [FieldOffset(Offset = "0x14")]
    private string mTitleText;
    [Token(Token = "0x400F1D1")]
    [FieldOffset(Offset = "0x18")]
    private string mMainText;
    [Token(Token = "0x400F1D2")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsSubText;

    [Token(Token = "0x17001E37")]
    public BulkReleaseWindow.Type Type
    {
      [Token(Token = "0x600E26C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new BulkReleaseWindow.Type();
      }
    }

    [Token(Token = "0x17001E38")]
    public bool IsIntaractable
    {
      [Token(Token = "0x600E26D"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E39")]
    public string TitleText
    {
      [Token(Token = "0x600E26E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E3A")]
    public string MainText
    {
      [Token(Token = "0x600E26F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E3B")]
    public bool IsSubText
    {
      [Token(Token = "0x600E270"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E271")]
    [Address(RVA = "0xAA26D0", Offset = "0xAA14D0", VA = "0x10AA26D0")]
    public void Initialize(BulkReleaseWindow.Type type, long id, bool isLeaguMatchPeriod)
    {
    }

    [Token(Token = "0x600E272")]
    [Address(RVA = "0xAA27C0", Offset = "0xAA15C0", VA = "0x10AA27C0")]
    public void SetTargetText()
    {
    }

    [Token(Token = "0x600E273")]
    [Address(RVA = "0xAA2880", Offset = "0xAA1680", VA = "0x10AA2880")]
    public void SetText()
    {
    }

    [Token(Token = "0x600E274")]
    [Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")]
    public void SetIntaractable(bool intaractable)
    {
    }

    [Token(Token = "0x600E275")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AllUnitEquipBulkReleaseConfirmWindowModel()
    {
    }
  }
}
