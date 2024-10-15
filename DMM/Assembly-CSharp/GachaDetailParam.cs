// Decompiled with JetBrains decompiler
// Type: GachaDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20002AA")]
public class GachaDetailParam
{
  [Token(Token = "0x4000B0E")]
  [FieldOffset(Offset = "0x8")]
  public int id;
  [Token(Token = "0x4000B0F")]
  [FieldOffset(Offset = "0xC")]
  public string gname;
  [Token(Token = "0x4000B10")]
  [FieldOffset(Offset = "0x10")]
  public int type;
  [Token(Token = "0x4000B11")]
  [FieldOffset(Offset = "0x14")]
  public string text;
  [Token(Token = "0x4000B12")]
  [FieldOffset(Offset = "0x18")]
  public string image;
  [Token(Token = "0x4000B13")]
  [FieldOffset(Offset = "0x1C")]
  public int width;
  [Token(Token = "0x4000B14")]
  [FieldOffset(Offset = "0x20")]
  public int height;

  [Token(Token = "0x6000E22")]
  [Address(RVA = "0x11D0600", Offset = "0x11CF400", VA = "0x111D0600")]
  public bool Deserialize(JSON_GachaDetailParam json) => new bool();

  [Token(Token = "0x6000E23")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public GachaDetailParam()
  {
  }

  [Token(Token = "0x20002AB")]
  public enum DetailType
  {
    [Token(Token = "0x4000B16")] none,
    [Token(Token = "0x4000B17")] text,
    [Token(Token = "0x4000B18")] image,
    [Token(Token = "0x4000B19")] all,
  }
}
