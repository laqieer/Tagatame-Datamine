// Decompiled with JetBrains decompiler
// Type: LocalNotificationInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000255")]
public class LocalNotificationInfo
{
  [Token(Token = "0x40009E5")]
  [FieldOffset(Offset = "0x8")]
  public int id;
  [Token(Token = "0x40009E6")]
  [FieldOffset(Offset = "0xC")]
  public int push_flg;
  [Token(Token = "0x40009E7")]
  [FieldOffset(Offset = "0x10")]
  public string trophy_iname;
  [Token(Token = "0x40009E8")]
  [FieldOffset(Offset = "0x14")]
  public string push_word;

  [Token(Token = "0x6000C7A")]
  [Address(RVA = "0x1081E80", Offset = "0x1080C80", VA = "0x11081E80")]
  public bool Deserialize(JSON_LocalNotificationInfo json) => new bool();

  [Token(Token = "0x6000C7B")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public LocalNotificationInfo()
  {
  }
}
