// Decompiled with JetBrains decompiler
// Type: MyLocalNotification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000257")]
public static class MyLocalNotification
{
  [Token(Token = "0x40009F1")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string CATEGORY_COMEBACK;
  [Token(Token = "0x40009F2")]
  [FieldOffset(Offset = "0x4")]
  private static List<LocalNotificationInfo> mLocalNotifications;
  [Token(Token = "0x40009F3")]
  private const string LocalNoficationParamPath = "Data/Localnotification";
  [Token(Token = "0x40009F4")]
  [FieldOffset(Offset = "0x8")]
  private static readonly string LOCAL_NOTIFICATION_CATEGORY_STAMINA;
  [Token(Token = "0x40009F5")]
  [FieldOffset(Offset = "0xC")]
  private static readonly string CATEGORY_AUTOREPEAT_QUEST;
  [Token(Token = "0x40009F6")]
  [FieldOffset(Offset = "0x10")]
  private static readonly string CATEGORY_ADVENTURE_QUEST;
  [Token(Token = "0x40009F7")]
  [FieldOffset(Offset = "0x14")]
  private static readonly string CATEGORY_GUILD_TRAINING;

  [Token(Token = "0x17000179")]
  public static List<LocalNotificationInfo> LocaloNotifications
  {
    [Token(Token = "0x6000C7E"), Address(RVA = "0x1085F00", Offset = "0x1084D00", VA = "0x11085F00")] get
    {
      return (List<LocalNotificationInfo>) null;
    }
  }

  [Token(Token = "0x6000C7F")]
  [Address(RVA = "0x1085AA0", Offset = "0x10848A0", VA = "0x11085AA0")]
  public static bool Setup(string path) => new bool();

  [Token(Token = "0x6000C80")]
  [Address(RVA = "0x1084C30", Offset = "0x1083A30", VA = "0x11084C30")]
  public static void Accept()
  {
  }

  [Token(Token = "0x6000C81")]
  [Address(RVA = "0x1084C40", Offset = "0x1083A40", VA = "0x11084C40")]
  public static void CancelStamina()
  {
  }

  [Token(Token = "0x6000C82")]
  [Address(RVA = "0x10858E0", Offset = "0x10846E0", VA = "0x110858E0")]
  public static void SetStamina(LocalNotificationParam param, PlayerData player)
  {
  }

  [Token(Token = "0x6000C83")]
  [Address(RVA = "0x1085780", Offset = "0x1084580", VA = "0x11085780")]
  public static void SetRegular(RegularLocalNotificationParam param, PlayerData player)
  {
  }

  [Token(Token = "0x6000C84")]
  [Address(RVA = "0x10851E0", Offset = "0x1083FE0", VA = "0x110851E0")]
  public static void SetComeBack(string message, long interval_sec)
  {
  }

  [Token(Token = "0x6000C85")]
  [Address(RVA = "0x1084D40", Offset = "0x1083B40", VA = "0x11084D40")]
  public static void ResetComeBack()
  {
  }

  [Token(Token = "0x6000C86")]
  [Address(RVA = "0x1084FF0", Offset = "0x1083DF0", VA = "0x11084FF0")]
  public static void SetAutoRepeatQuest(string message, DateTime date)
  {
  }

  [Token(Token = "0x6000C87")]
  [Address(RVA = "0x1084CF0", Offset = "0x1083AF0", VA = "0x11084CF0")]
  public static void ResetAutoRepeatQuest()
  {
  }

  [Token(Token = "0x6000C88")]
  [Address(RVA = "0x1084E00", Offset = "0x1083C00", VA = "0x11084E00")]
  public static void SetAdventureQuest(string _message, DateTime _date, string _area_name)
  {
  }

  [Token(Token = "0x6000C89")]
  [Address(RVA = "0x1084C90", Offset = "0x1083A90", VA = "0x11084C90")]
  public static void ResetAdventureQuest(string _area_name)
  {
  }

  [Token(Token = "0x6000C8A")]
  [Address(RVA = "0x1085260", Offset = "0x1084060", VA = "0x11085260")]
  public static void SetGuildTraining(string _message, DateTime _date, int slot_no)
  {
  }

  [Token(Token = "0x6000C8B")]
  [Address(RVA = "0x1084D90", Offset = "0x1083B90", VA = "0x11084D90")]
  public static void ResetGuildTraining(int slot_no)
  {
  }

  [Token(Token = "0x6000C8C")]
  [Address(RVA = "0x1085D90", Offset = "0x1084B90", VA = "0x11085D90")]
  static MyLocalNotification()
  {
  }
}
