// Decompiled with JetBrains decompiler
// Type: RegularLocalNotificationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000256")]
public class RegularLocalNotificationParam
{
  [Token(Token = "0x40009E9")]
  [FieldOffset(Offset = "0x0")]
  public static readonly string CATEGORY_MORNING;
  [Token(Token = "0x40009EA")]
  [FieldOffset(Offset = "0x4")]
  public static readonly string CATEGORY_NOON;
  [Token(Token = "0x40009EB")]
  [FieldOffset(Offset = "0x8")]
  public static readonly string CATEGORY_AFTERNOON;
  [Token(Token = "0x40009EC")]
  [FieldOffset(Offset = "0x8")]
  public string mMessage;
  [Token(Token = "0x40009ED")]
  [FieldOffset(Offset = "0xC")]
  public string mCategory;
  [Token(Token = "0x40009EE")]
  [FieldOffset(Offset = "0x10")]
  public int mHour;
  [Token(Token = "0x40009EF")]
  [FieldOffset(Offset = "0x14")]
  public int mMinute;
  [Token(Token = "0x40009F0")]
  [FieldOffset(Offset = "0x18")]
  public int mSecond;

  [Token(Token = "0x6000C7C")]
  [Address(RVA = "0x1089DD0", Offset = "0x1088BD0", VA = "0x11089DD0")]
  public RegularLocalNotificationParam(
    string message,
    string category,
    int hour,
    int min,
    int sec)
  {
  }

  [Token(Token = "0x6000C7D")]
  [Address(RVA = "0x1089D20", Offset = "0x1088B20", VA = "0x11089D20")]
  static RegularLocalNotificationParam()
  {
  }
}
