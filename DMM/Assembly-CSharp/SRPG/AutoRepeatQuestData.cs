// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001995")]
  public class AutoRepeatQuestData
  {
    [Token(Token = "0x4005DB2")]
    [FieldOffset(Offset = "0x8")]
    private string mQuestIname;
    [Token(Token = "0x4005DB3")]
    [FieldOffset(Offset = "0xC")]
    private long[] mUnits;
    [Token(Token = "0x4005DB4")]
    [FieldOffset(Offset = "0x10")]
    private int mTimePerLap;
    [Token(Token = "0x4005DB5")]
    [FieldOffset(Offset = "0x14")]
    private int mLapMax;
    [Token(Token = "0x4005DB6")]
    [FieldOffset(Offset = "0x18")]
    private int mLapMaxEx;
    [Token(Token = "0x4005DB7")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsBoxFull;
    [Token(Token = "0x4005DB8")]
    [FieldOffset(Offset = "0x20")]
    private AutoRepeatQuestData.EndType mStopReason;
    [Token(Token = "0x4005DB9")]
    [FieldOffset(Offset = "0x24")]
    private int mCurrentLap;
    [Token(Token = "0x4005DBA")]
    [FieldOffset(Offset = "0x28")]
    private int mGold;
    [Token(Token = "0x4005DBB")]
    [FieldOffset(Offset = "0x2C")]
    private AutoRepeatQuestData.DropItem[][] mDrops;
    [Token(Token = "0x4005DBC")]
    [FieldOffset(Offset = "0x30")]
    private DateTime mStartTime;
    [Token(Token = "0x4005DBD")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsInitialized;
    [Token(Token = "0x4005DBE")]
    [FieldOffset(Offset = "0x39")]
    private bool mIsMeasuring;

    [Token(Token = "0x17000ADC")]
    public string QuestIname
    {
      [Token(Token = "0x600684B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000ADD")]
    public long[] Units
    {
      [Token(Token = "0x600684C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x17000ADE")]
    public int TimePerLap
    {
      [Token(Token = "0x600684D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ADF")]
    public int LapMax
    {
      [Token(Token = "0x600684E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AE0")]
    public int CurrentLap
    {
      [Token(Token = "0x600684F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AE1")]
    public bool IsBoxFull
    {
      [Token(Token = "0x6006850"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AE2")]
    public int Gold
    {
      [Token(Token = "0x6006851"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AE3")]
    public AutoRepeatQuestData.DropItem[][] Drops
    {
      [Token(Token = "0x6006852"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (AutoRepeatQuestData.DropItem[][]) null;
      }
    }

    [Token(Token = "0x17000AE4")]
    public DateTime StartTime
    {
      [Token(Token = "0x6006853"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000AE5")]
    public bool IsInitialized
    {
      [Token(Token = "0x6006854"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AE6")]
    public bool IsMeasuring
    {
      [Token(Token = "0x6006855"), Address(RVA = "0x34AF90", Offset = "0x349D90", VA = "0x1034AF90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AE7")]
    public bool IsExistRecord
    {
      [Token(Token = "0x6006856"), Address(RVA = "0x34AEE0", Offset = "0x349CE0", VA = "0x1034AEE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AE8")]
    public AutoRepeatQuestData.EndType StopReason
    {
      [Token(Token = "0x6006857"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new AutoRepeatQuestData.EndType();
      }
    }

    [Token(Token = "0x6006858")]
    [Address(RVA = "0x34AB60", Offset = "0x349960", VA = "0x1034AB60")]
    public static void SetLocalNotification(AutoRepeatQuestData progress)
    {
    }

    [Token(Token = "0x17000AE9")]
    public DateTime EndTime
    {
      [Token(Token = "0x6006859"), Address(RVA = "0x34AE20", Offset = "0x349C20", VA = "0x1034AE20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000AEA")]
    public DateTime EndTimeEx
    {
      [Token(Token = "0x600685A"), Address(RVA = "0x34AD60", Offset = "0x349B60", VA = "0x1034AD60")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000AEB")]
    public AutoRepeatQuestData.eState State
    {
      [Token(Token = "0x600685B"), Address(RVA = "0x34AFA0", Offset = "0x349DA0", VA = "0x1034AFA0")] get
      {
        return new AutoRepeatQuestData.eState();
      }
    }

    [Token(Token = "0x17000AEC")]
    public int ElapsedTime
    {
      [Token(Token = "0x600685C"), Address(RVA = "0x34AC90", Offset = "0x349A90", VA = "0x1034AC90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600685D")]
    [Address(RVA = "0x349DC0", Offset = "0x348BC0", VA = "0x10349DC0")]
    public void Deserialize(Json_AutoRepeatQuestData json, bool override_drop = true)
    {
    }

    [Token(Token = "0x600685E")]
    [Address(RVA = "0x34AAA0", Offset = "0x3498A0", VA = "0x1034AAA0")]
    public void Reset()
    {
    }

    [Token(Token = "0x600685F")]
    [Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")]
    public void SetLapMax(int new_lap_max)
    {
    }

    [Token(Token = "0x6006860")]
    [Address(RVA = "0x34AA90", Offset = "0x349890", VA = "0x1034AA90")]
    public void ResetMeasuringFlag()
    {
    }

    [Token(Token = "0x6006861")]
    [Address(RVA = "0x34A330", Offset = "0x349130", VA = "0x1034A330")]
    private int GetCoolTime(int lap_max) => new int();

    [Token(Token = "0x6006862")]
    [Address(RVA = "0x34A510", Offset = "0x349310", VA = "0x1034A510")]
    public List<Unit.DropItem> GetDropItem() => (List<Unit.DropItem>) null;

    [Token(Token = "0x6006863")]
    [Address(RVA = "0x34A390", Offset = "0x349190", VA = "0x1034A390")]
    public List<QuestResult.DropItemData> GetDropItemData()
    {
      return (List<QuestResult.DropItemData>) null;
    }

    [Token(Token = "0x6006864")]
    [Address(RVA = "0x34A990", Offset = "0x349790", VA = "0x1034A990")]
    public List<UnitData> GetUnitDatas() => (List<UnitData>) null;

    [Token(Token = "0x6006865")]
    [Address(RVA = "0x34A160", Offset = "0x348F60", VA = "0x1034A160")]
    public List<QuestParam> GetCharacterQuestParams() => (List<QuestParam>) null;

    [Token(Token = "0x6006866")]
    [Address(RVA = "0x349D40", Offset = "0x348B40", VA = "0x10349D40")]
    private AutoRepeatQuestData.DropItem[][] AppendDropItems(
      AutoRepeatQuestData.DropItem[][] a,
      AutoRepeatQuestData.DropItem[][] b)
    {
      return (AutoRepeatQuestData.DropItem[][]) null;
    }

    [Token(Token = "0x6006867")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRepeatQuestData()
    {
    }

    [Token(Token = "0x2001996")]
    public enum eState
    {
      [Token(Token = "0x4005DC0")] IDLE,
      [Token(Token = "0x4005DC1")] AUTO_REPEAT_NOW,
      [Token(Token = "0x4005DC2")] AUTO_REPEAT_END,
    }

    [Token(Token = "0x2001997")]
    public enum EndType
    {
      [Token(Token = "0x4005DC4")] COMPLETE,
      [Token(Token = "0x4005DC5")] AP_LACK,
      [Token(Token = "0x4005DC6")] BOX_FULL,
      [Token(Token = "0x4005DC7")] SUSPEND,
      [Token(Token = "0x4005DC8")] EXPIRED,
      [Token(Token = "0x4005DC9")] CHALLENGE_LIMIT,
      [Token(Token = "0x4005DCA")] LAP_LIMIT,
    }

    [Token(Token = "0x2001998")]
    [Serializable]
    public class DropItem
    {
      [Token(Token = "0x4005DCB")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4005DCC")]
      [FieldOffset(Offset = "0xC")]
      public EBattleRewardType type;
      [Token(Token = "0x4005DCD")]
      [FieldOffset(Offset = "0x10")]
      public int num;
      [Token(Token = "0x4005DCE")]
      [FieldOffset(Offset = "0x14")]
      public int secret;

      [Token(Token = "0x6006868")]
      [Address(RVA = "0x358630", Offset = "0x357430", VA = "0x10358630")]
      public DropItem(BattleCore.Json_BtlDrop json)
      {
      }
    }
  }
}
