// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChatStampParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002162")]
  public class JSON_ChatStampParam
  {
    [Token(Token = "0x40091A9")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x40091AA")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ChatStampParam.Fields fields;

    [Token(Token = "0x6008C57")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChatStampParam()
    {
    }

    [Token(Token = "0x2002163")]
    public class Fields
    {
      [Token(Token = "0x40091AB")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x40091AC")]
      [FieldOffset(Offset = "0xC")]
      public string img_id;
      [Token(Token = "0x40091AD")]
      [FieldOffset(Offset = "0x10")]
      public string iname;
      [Token(Token = "0x40091AE")]
      [FieldOffset(Offset = "0x14")]
      public int is_private;

      [Token(Token = "0x6008C58")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
