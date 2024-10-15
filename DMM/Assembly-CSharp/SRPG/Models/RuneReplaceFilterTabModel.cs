// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceFilterTabModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200339B")]
  public class RuneReplaceFilterTabModel
  {
    [Token(Token = "0x400F440")]
    [FieldOffset(Offset = "0x8")]
    private string mDefaultTextKey;
    [Token(Token = "0x400F441")]
    [FieldOffset(Offset = "0xC")]
    private string mTabText;
    [Token(Token = "0x400F442")]
    [FieldOffset(Offset = "0x10")]
    private string mTabKey;
    [Token(Token = "0x400F443")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsFiltered;

    [Token(Token = "0x17002023")]
    public string TabText
    {
      [Token(Token = "0x600E614"), Address(RVA = "0xAC87E0", Offset = "0xAC75E0", VA = "0x10AC87E0")] set
      {
      }
      [Token(Token = "0x600E615"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002024")]
    public string TabKey
    {
      [Token(Token = "0x600E616"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
      [Token(Token = "0x600E617"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002025")]
    public bool IsFiltered
    {
      [Token(Token = "0x600E618"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] set
      {
      }
      [Token(Token = "0x600E619"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E61A")]
    [Address(RVA = "0xAC87A0", Offset = "0xAC75A0", VA = "0x10AC87A0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E61B")]
    [Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")]
    public void Initialize(string defaultTextKey)
    {
    }

    [Token(Token = "0x600E61C")]
    [Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")]
    public void SetDefaultTextKey(string defaultTextKey)
    {
    }

    [Token(Token = "0x600E61D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneReplaceFilterTabModel()
    {
    }
  }
}
