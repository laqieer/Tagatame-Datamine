// Decompiled with JetBrains decompiler
// Type: JSON_GachaDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20002A8")]
public class JSON_GachaDetailParam
{
  [Token(Token = "0x4000B05")]
  [FieldOffset(Offset = "0x8")]
  public int pk;
  [Token(Token = "0x4000B06")]
  [FieldOffset(Offset = "0xC")]
  public JSON_GachaDetailParam.Fileds fields;

  [Token(Token = "0x6000E20")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public JSON_GachaDetailParam()
  {
  }

  [Token(Token = "0x20002A9")]
  public class Fileds
  {
    [Token(Token = "0x4000B07")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4000B08")]
    [FieldOffset(Offset = "0xC")]
    public string gname;
    [Token(Token = "0x4000B09")]
    [FieldOffset(Offset = "0x10")]
    public int type;
    [Token(Token = "0x4000B0A")]
    [FieldOffset(Offset = "0x14")]
    public string text;
    [Token(Token = "0x4000B0B")]
    [FieldOffset(Offset = "0x18")]
    public string image;
    [Token(Token = "0x4000B0C")]
    [FieldOffset(Offset = "0x1C")]
    public int width;
    [Token(Token = "0x4000B0D")]
    [FieldOffset(Offset = "0x20")]
    public int height;

    [Token(Token = "0x6000E21")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Fileds()
    {
    }
  }
}
