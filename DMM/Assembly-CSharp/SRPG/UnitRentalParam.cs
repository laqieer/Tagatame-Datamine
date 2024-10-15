// Decompiled with JetBrains decompiler
// Type: SRPG.UnitRentalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E9A")]
  public class UnitRentalParam
  {
    [Token(Token = "0x4007FE9")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x4007FEA")]
    [FieldOffset(Offset = "0xC")]
    public string UnitId;
    [Token(Token = "0x4007FEB")]
    [FieldOffset(Offset = "0x10")]
    public DateTime BeginAt;
    [Token(Token = "0x4007FEC")]
    [FieldOffset(Offset = "0x18")]
    public DateTime EndAt;
    [Token(Token = "0x4007FED")]
    [FieldOffset(Offset = "0x20")]
    public OInt PtMax;
    [Token(Token = "0x4007FEE")]
    [FieldOffset(Offset = "0x34")]
    public OInt PtUpLv;
    [Token(Token = "0x4007FEF")]
    [FieldOffset(Offset = "0x48")]
    public OInt PtUpEvol;
    [Token(Token = "0x4007FF0")]
    [FieldOffset(Offset = "0x5C")]
    public OInt PtUpAwake;
    [Token(Token = "0x4007FF1")]
    [FieldOffset(Offset = "0x70")]
    public OInt PtUpJobLv;
    [Token(Token = "0x4007FF2")]
    [FieldOffset(Offset = "0x84")]
    public OInt PtUpAbilityLv;
    [Token(Token = "0x4007FF3")]
    [FieldOffset(Offset = "0x98")]
    public OInt PtUpQuestMain;
    [Token(Token = "0x4007FF4")]
    [FieldOffset(Offset = "0xAC")]
    public OInt PtUpQuestSub;
    [Token(Token = "0x4007FF5")]
    [FieldOffset(Offset = "0xC0")]
    public string NotificationId;
    [Token(Token = "0x4007FF6")]
    [FieldOffset(Offset = "0xC4")]
    public List<RentalQuestInfo> UnitQuestInfo;
    [Token(Token = "0x4007FF7")]
    [FieldOffset(Offset = "0xC8")]
    private UnitParam mUnit;
    [Token(Token = "0x4007FF8")]
    [FieldOffset(Offset = "0xCC")]
    private UnitRentalNotificationParam mNotification;
    [Token(Token = "0x4007FF9")]
    [FieldOffset(Offset = "0x0")]
    private static UnitData mGetUnitData;

    [Token(Token = "0x1700118A")]
    public UnitParam Unit
    {
      [Token(Token = "0x6007D7E"), Address(RVA = "0x3F6CB0", Offset = "0x3F5AB0", VA = "0x103F6CB0")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x1700118B")]
    private UnitRentalNotificationParam Notification
    {
      [Token(Token = "0x6007D7F"), Address(RVA = "0x3F6C60", Offset = "0x3F5A60", VA = "0x103F6C60")] get
      {
        return (UnitRentalNotificationParam) null;
      }
    }

    [Token(Token = "0x6007D80")]
    [Address(RVA = "0x3F5A10", Offset = "0x3F4810", VA = "0x103F5A10")]
    public void Deserialize(JSON_UnitRentalParam json)
    {
    }

    [Token(Token = "0x6007D81")]
    [Address(RVA = "0x3F6850", Offset = "0x3F5650", VA = "0x103F6850")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6007D82")]
    [Address(RVA = "0x3F6410", Offset = "0x3F5210", VA = "0x103F6410")]
    public List<QuestParam> GetLiberationQuests(int point) => (List<QuestParam>) null;

    [Token(Token = "0x6007D83")]
    [Address(RVA = "0x3F6510", Offset = "0x3F5310", VA = "0x103F6510")]
    public List<QuestParam> GetNewLiberationQuests(int old_point, int new_point)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6007D84")]
    [Address(RVA = "0x3F5DD0", Offset = "0x3F4BD0", VA = "0x103F5DD0")]
    public static void Deserialize(
      JSON_UnitRentalParam[] jsons,
      ref Dictionary<string, UnitRentalParam> refUnitRentalParams)
    {
    }

    [Token(Token = "0x6007D85")]
    [Address(RVA = "0x3F6650", Offset = "0x3F5450", VA = "0x103F6650")]
    public static UnitRentalParam GetParam(string key) => (UnitRentalParam) null;

    [Token(Token = "0x6007D86")]
    [Address(RVA = "0x3F6110", Offset = "0x3F4F10", VA = "0x103F6110")]
    public static UnitRentalParam GetActiveUnitRentalParam() => (UnitRentalParam) null;

    [Token(Token = "0x6007D87")]
    [Address(RVA = "0x3F6920", Offset = "0x3F5720", VA = "0x103F6920")]
    public static bool SendNotificationIsNeed(string unit_iname, int old_point, int new_point)
    {
      return new bool();
    }

    [Token(Token = "0x1700118C")]
    public static UnitData GetUnitData
    {
      [Token(Token = "0x6007D88"), Address(RVA = "0x3F6C30", Offset = "0x3F5A30", VA = "0x103F6C30")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x6007D89"), Address(RVA = "0x3F6D70", Offset = "0x3F5B70", VA = "0x103F6D70")] set
      {
      }
    }

    [Token(Token = "0x6007D8A")]
    [Address(RVA = "0x3F5F80", Offset = "0x3F4D80", VA = "0x103F5F80")]
    public static void EntryLeaveReturnItems(Json_Item[] return_items)
    {
    }

    [Token(Token = "0x6007D8B")]
    [Address(RVA = "0x3F59B0", Offset = "0x3F47B0", VA = "0x103F59B0")]
    public static void ClearLeaveReturnItems()
    {
    }

    [Token(Token = "0x6007D8C")]
    [Address(RVA = "0x3F6BB0", Offset = "0x3F59B0", VA = "0x103F6BB0")]
    public UnitRentalParam()
    {
    }
  }
}
