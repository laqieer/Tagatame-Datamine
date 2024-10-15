// Decompiled with JetBrains decompiler
// Type: JSON_LocalNotificationInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000253")]
public class JSON_LocalNotificationInfo
{
  [Token(Token = "0x40009DF")]
  [FieldOffset(Offset = "0x8")]
  public int pk;
  [Token(Token = "0x40009E0")]
  [FieldOffset(Offset = "0xC")]
  public JSON_LocalNotificationInfo.Fields fields;

  [Token(Token = "0x6000C78")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public JSON_LocalNotificationInfo()
  {
  }

  [Token(Token = "0x2000254")]
  public class Fields
  {
    [Token(Token = "0x40009E1")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40009E2")]
    [FieldOffset(Offset = "0xC")]
    public string trophy_iname;
    [Token(Token = "0x40009E3")]
    [FieldOffset(Offset = "0x10")]
    public int push_flg;
    [Token(Token = "0x40009E4")]
    [FieldOffset(Offset = "0x14")]
    public string push_word;

    [Token(Token = "0x6000C79")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Fields()
    {
    }
  }
}
