// Decompiled with JetBrains decompiler
// Type: SRPG.TwitterMessageDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DBF")]
  public class TwitterMessageDetailParam
  {
    [Token(Token = "0x4007672")]
    [FieldOffset(Offset = "0x8")]
    private string text;
    [Token(Token = "0x4007673")]
    [FieldOffset(Offset = "0xC")]
    private string[] hash_tag;
    [Token(Token = "0x4007674")]
    [FieldOffset(Offset = "0x10")]
    private string cnds_key;

    [Token(Token = "0x17001074")]
    public string Text
    {
      [Token(Token = "0x60079C0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001075")]
    public string[] HashTag
    {
      [Token(Token = "0x60079C1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17001076")]
    public string CndsKey
    {
      [Token(Token = "0x60079C2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60079C3")]
    [Address(RVA = "0x3C04F0", Offset = "0x3BF2F0", VA = "0x103C04F0")]
    public void Deserialize(JSON_TwitterMessageDetailParam json)
    {
    }

    [Token(Token = "0x60079C4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TwitterMessageDetailParam()
    {
    }
  }
}
