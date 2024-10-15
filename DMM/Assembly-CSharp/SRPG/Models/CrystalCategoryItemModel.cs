// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalCategoryItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003318")]
  public class CrystalCategoryItemModel
  {
    [Token(Token = "0x17001DA8")]
    public bool DispTitle
    {
      [Token(Token = "0x600E111"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E112"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17001DA9")]
    public string TitleText
    {
      [Token(Token = "0x600E113"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E114"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001DAA")]
    public bool DispSub
    {
      [Token(Token = "0x600E115"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E116"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x17001DAB")]
    public string SubText
    {
      [Token(Token = "0x600E117"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E118"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x600E119")]
    [Address(RVA = "0xAAD460", Offset = "0xAAC260", VA = "0x10AAD460")]
    public void Initialize(string _title_text, string _sub_text, bool _is_disp_title)
    {
    }

    [Token(Token = "0x600E11A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalCategoryItemModel()
    {
    }
  }
}
