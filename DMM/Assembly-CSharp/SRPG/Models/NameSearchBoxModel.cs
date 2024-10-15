// Decompiled with JetBrains decompiler
// Type: SRPG.Models.NameSearchBoxModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003372")]
  public class NameSearchBoxModel
  {
    [Token(Token = "0x400F321")]
    [FieldOffset(Offset = "0x8")]
    private string mInputString;
    [Token(Token = "0x400F322")]
    [FieldOffset(Offset = "0xC")]
    private SearchUtility.CONDITIONS mSearchType;
    [Token(Token = "0x400F323")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsOpen;
    [Token(Token = "0x400F324")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsInputFieldFocus;

    [Token(Token = "0x17001F46")]
    public string InputString
    {
      [Token(Token = "0x600E469"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
      [Token(Token = "0x600E46A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F47")]
    public bool IsInputString
    {
      [Token(Token = "0x600E46B"), Address(RVA = "0xABB5E0", Offset = "0xABA3E0", VA = "0x10ABB5E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F48")]
    public SearchUtility.CONDITIONS SearchType
    {
      [Token(Token = "0x600E46C"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
      {
      }
      [Token(Token = "0x600E46D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new SearchUtility.CONDITIONS();
      }
    }

    [Token(Token = "0x17001F49")]
    public bool IsOpen
    {
      [Token(Token = "0x600E46E"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
      {
      }
      [Token(Token = "0x600E46F"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F4A")]
    public bool IsInputFieldFocus
    {
      [Token(Token = "0x600E470"), Address(RVA = "0xAB3920", Offset = "0xAB2720", VA = "0x10AB3920")] set
      {
      }
      [Token(Token = "0x600E471"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F4B")]
    public int GetButtonType
    {
      [Token(Token = "0x600E472"), Address(RVA = "0xABB5C0", Offset = "0xABA3C0", VA = "0x10ABB5C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E473")]
    [Address(RVA = "0xABB580", Offset = "0xABA380", VA = "0x10ABB580")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E474")]
    [Address(RVA = "0xABB580", Offset = "0xABA380", VA = "0x10ABB580")]
    public void ResetInputString()
    {
    }

    [Token(Token = "0x600E475")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public NameSearchBoxModel()
    {
    }

    [Token(Token = "0x2003373")]
    public enum ButtonType
    {
      [Token(Token = "0x400F326")] NONE,
      [Token(Token = "0x400F327")] SET,
    }
  }
}
