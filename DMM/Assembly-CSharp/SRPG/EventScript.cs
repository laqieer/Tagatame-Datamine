// Decompiled with JetBrains decompiler
// Type: SRPG.EventScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200125F")]
  public class EventScript : ScriptableObject
  {
    [Token(Token = "0x40043A8")]
    public const string ScenePreviewName = "@EventScenePreview";
    [Token(Token = "0x40043A9")]
    public const string EventScriptDir = "Events/";
    [Token(Token = "0x40043AA")]
    public const int MAX_UNMANAGED_FILE = 10;
    [Token(Token = "0x40043AB")]
    [FieldOffset(Offset = "0x0")]
    private static Canvas mCanvas;
    [Token(Token = "0x40043AC")]
    [FieldOffset(Offset = "0x4")]
    private static RectTransform mEventRootTransform;
    [Token(Token = "0x40043AD")]
    [FieldOffset(Offset = "0x8")]
    private static Canvas mBackLogCanvas;
    [Token(Token = "0x40043AE")]
    [FieldOffset(Offset = "0xC")]
    private static GameObject mFrame;
    [Token(Token = "0x40043AF")]
    [FieldOffset(Offset = "0x10")]
    private static float mCurrMessageAutoTimer;
    [Token(Token = "0x40043B0")]
    [FieldOffset(Offset = "0x14")]
    private static bool mMessageAuto;
    [Token(Token = "0x40043B1")]
    [FieldOffset(Offset = "0x18")]
    public static EventScript.AutoFlagChange OnAutoFlagChanged;
    [Token(Token = "0x40043B2")]
    [FieldOffset(Offset = "0x1C")]
    public static EventScript.OnBackLogButtonClick OnBackLogButtonClicked;
    [Token(Token = "0x40043B3")]
    [FieldOffset(Offset = "0x20")]
    private static EventBackLog mBackLog;
    [Token(Token = "0x40043B4")]
    [FieldOffset(Offset = "0x24")]
    public static string[] StrCompTypeRestHP;
    [Token(Token = "0x40043B5")]
    [FieldOffset(Offset = "0x28")]
    public static string[] StrCalcTypeRestHP;
    [Token(Token = "0x40043B6")]
    [FieldOffset(Offset = "0x2C")]
    public static string[] StrSkillTiming;
    [Token(Token = "0x40043B7")]
    [FieldOffset(Offset = "0x30")]
    public static string[] StrShortSkillTiming;
    [Token(Token = "0x40043B8")]
    [FieldOffset(Offset = "0xC")]
    public string QuestID;
    [Token(Token = "0x40043B9")]
    [FieldOffset(Offset = "0x10")]
    public EventScript.ScriptSequence[] mSequences;
    [Token(Token = "0x40043BA")]
    [FieldOffset(Offset = "0x34")]
    private static GameObject mButtonLog;
    [Token(Token = "0x40043BB")]
    [FieldOffset(Offset = "0x38")]
    private static GameObject mButtonAuto;

    [Token(Token = "0x170008B8")]
    public static Canvas Canvas
    {
      [Token(Token = "0x6004DC9"), Address(RVA = "0x12365F0", Offset = "0x12353F0", VA = "0x112365F0")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x170008B9")]
    public static RectTransform EventRootTransform
    {
      [Token(Token = "0x6004DCA"), Address(RVA = "0x1236630", Offset = "0x1235430", VA = "0x11236630")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170008BA")]
    public static Canvas BackLogCanvas
    {
      [Token(Token = "0x6004DCB"), Address(RVA = "0x1235EE0", Offset = "0x1234CE0", VA = "0x11235EE0")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x170008BB")]
    public static bool IsMessageAuto
    {
      [Token(Token = "0x6004DCC"), Address(RVA = "0x1236670", Offset = "0x1235470", VA = "0x11236670")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004DCD"), Address(RVA = "0x1236760", Offset = "0x1235560", VA = "0x11236760")] set
      {
      }
    }

    [Token(Token = "0x6004DCE")]
    [Address(RVA = "0x1234150", Offset = "0x1232F50", VA = "0x11234150")]
    public static bool MessageAutoForward(float deltaTime) => new bool();

    [Token(Token = "0x170008BC")]
    public static EventBackLog BackLog
    {
      [Token(Token = "0x6004DCF"), Address(RVA = "0x1235F30", Offset = "0x1234D30", VA = "0x11235F30")] get
      {
        return (EventBackLog) null;
      }
    }

    [Token(Token = "0x170008BD")]
    public static bool BackLogCanOpen
    {
      [Token(Token = "0x6004DD0"), Address(RVA = "0x12366B0", Offset = "0x12354B0", VA = "0x112366B0")] set
      {
      }
      [Token(Token = "0x6004DD1"), Address(RVA = "0x1235E40", Offset = "0x1234C40", VA = "0x11235E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004DD2")]
    [Address(RVA = "0x1232C00", Offset = "0x1231A00", VA = "0x11232C00")]
    public static void AddBackLog(string name, string text)
    {
    }

    [Token(Token = "0x6004DD3")]
    [Address(RVA = "0x1234E80", Offset = "0x1233C80", VA = "0x11234E80")]
    public static void OpenBackLog()
    {
    }

    [Token(Token = "0x6004DD4")]
    [Address(RVA = "0x1232CB0", Offset = "0x1231AB0", VA = "0x11232CB0")]
    public static void CloseBackLog()
    {
    }

    [Token(Token = "0x6004DD5")]
    [Address(RVA = "0x1232D60", Offset = "0x1231B60", VA = "0x11232D60")]
    public static IntVector2 ConvToIntVector2Grid(string str_grid) => new IntVector2();

    [Token(Token = "0x6004DD6")]
    [Address(RVA = "0x1233020", Offset = "0x1231E20", VA = "0x11233020")]
    public static string ConvToStringGrid(IntVector2 iv_grid) => (string) null;

    [Token(Token = "0x6004DD7")]
    [Address(RVA = "0x1232DF0", Offset = "0x1231BF0", VA = "0x11232DF0")]
    public static EventScript.cRestHP ConvToObjectRestHP(string str_rest_hp)
    {
      return (EventScript.cRestHP) null;
    }

    [Token(Token = "0x6004DD8")]
    [Address(RVA = "0x12330A0", Offset = "0x1231EA0", VA = "0x112330A0")]
    public static string ConvToStringRestHP(EventScript.cRestHP rest_hp) => (string) null;

    [Token(Token = "0x6004DD9")]
    [Address(RVA = "0x1235170", Offset = "0x1233F70", VA = "0x11235170")]
    public void ResetTriggers()
    {
    }

    [Token(Token = "0x6004DDA")]
    [Address(RVA = "0x1233C70", Offset = "0x1232A70", VA = "0x11233C70")]
    public static void DestroyCanvas()
    {
    }

    [Token(Token = "0x6004DDB")]
    [Address(RVA = "0x1233BA0", Offset = "0x12329A0", VA = "0x11233BA0")]
    public static void DestroyBackLogCanvas()
    {
    }

    [Token(Token = "0x6004DDC")]
    [Address(RVA = "0x12335A0", Offset = "0x12323A0", VA = "0x112335A0")]
    private void CreateCanvas()
    {
    }

    [Token(Token = "0x170008BE")]
    private static GameObject ButtonLog
    {
      [Token(Token = "0x6004DDD"), Address(RVA = "0x1236400", Offset = "0x1235200", VA = "0x11236400")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170008BF")]
    private static GameObject ButtonAuto
    {
      [Token(Token = "0x6004DDE"), Address(RVA = "0x1236210", Offset = "0x1235010", VA = "0x11236210")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6004DDF")]
    [Address(RVA = "0x1232A90", Offset = "0x1231890", VA = "0x11232A90")]
    public static void ActiveButtons(bool enable)
    {
    }

    [Token(Token = "0x6004DE0")]
    [Address(RVA = "0x12351D0", Offset = "0x1233FD0", VA = "0x112351D0")]
    public static void SetButtonFront()
    {
    }

    [Token(Token = "0x6004DE1")]
    [Address(RVA = "0x12332E0", Offset = "0x12320E0", VA = "0x112332E0")]
    private void CreateBackLogCanvas()
    {
    }

    [Token(Token = "0x6004DE2")]
    [Address(RVA = "0x1233D80", Offset = "0x1232B80", VA = "0x11233D80")]
    public static void DestroyFrame()
    {
    }

    [Token(Token = "0x6004DE3")]
    [Address(RVA = "0x1234F30", Offset = "0x1233D30", VA = "0x11234F30")]
    public void PrepareAssets()
    {
    }

    [Token(Token = "0x6004DE4")]
    [Address(RVA = "0x1234FA0", Offset = "0x1233DA0", VA = "0x11234FA0")]
    public void PrepareUnmanagedAssets()
    {
    }

    [Token(Token = "0x6004DE5")]
    [Address(RVA = "0x12353A0", Offset = "0x12341A0", VA = "0x112353A0")]
    private EventScript.Sequence StartSequence(
      EventScript.TestCondition test,
      bool is_auto_forward = true,
      int startOffset = 0)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DE6")]
    [Address(RVA = "0x1234280", Offset = "0x1233080", VA = "0x11234280")]
    public EventScript.Sequence OnPostMapLoad() => (EventScript.Sequence) null;

    [Token(Token = "0x6004DE7")]
    [Address(RVA = "0x1234770", Offset = "0x1233570", VA = "0x11234770")]
    public EventScript.Sequence OnStart(int startOffset = 0, bool is_auto_forward = false)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DE8")]
    [Address(RVA = "0x1234440", Offset = "0x1233240", VA = "0x11234440")]
    public EventScript.Sequence OnQuestWin() => (EventScript.Sequence) null;

    [Token(Token = "0x6004DE9")]
    [Address(RVA = "0x1234850", Offset = "0x1233650", VA = "0x11234850")]
    public EventScript.Sequence OnTurnStart(int turnCount) => (EventScript.Sequence) null;

    [Token(Token = "0x6004DEA")]
    [Address(RVA = "0x1234BA0", Offset = "0x12339A0", VA = "0x11234BA0")]
    public EventScript.Sequence OnUnitStart(TacticsUnitController controller)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DEB")]
    [Address(RVA = "0x1234A50", Offset = "0x1233850", VA = "0x11234A50")]
    public EventScript.Sequence OnUnitHPChange(TacticsUnitController controller)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DEC")]
    [Address(RVA = "0x1234C40", Offset = "0x1233A40", VA = "0x11234C40")]
    public EventScript.Sequence OnUnitTurnStart(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DED")]
    [Address(RVA = "0x12348F0", Offset = "0x12336F0", VA = "0x112348F0")]
    public EventScript.Sequence OnUnitAppear(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DEE")]
    [Address(RVA = "0x12349A0", Offset = "0x12337A0", VA = "0x112349A0")]
    public EventScript.Sequence OnUnitDead(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DEF")]
    [Address(RVA = "0x12346B0", Offset = "0x12334B0", VA = "0x112346B0")]
    public EventScript.Sequence OnStandbyGrid(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF0")]
    [Address(RVA = "0x1234AF0", Offset = "0x12338F0", VA = "0x11234AF0")]
    public EventScript.Sequence OnUnitRestHP(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF1")]
    [Address(RVA = "0x1234DA0", Offset = "0x1233BA0", VA = "0x11234DA0")]
    public EventScript.Sequence OnUseSkill(
      EventScript.SkillTiming timing,
      TacticsUnitController controller,
      SkillData skill,
      List<TacticsUnitController> TargetLists,
      bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF2")]
    [Address(RVA = "0x1234CF0", Offset = "0x1233AF0", VA = "0x11234CF0")]
    public EventScript.Sequence OnUnitWithdraw(TacticsUnitController controller, bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF3")]
    [Address(RVA = "0x1234360", Offset = "0x1233160", VA = "0x11234360")]
    public EventScript.Sequence OnQuestLose() => (EventScript.Sequence) null;

    [Token(Token = "0x6004DF4")]
    [Address(RVA = "0x12345F0", Offset = "0x12333F0", VA = "0x112345F0")]
    public EventScript.Sequence OnRecvSkillElem(
      TacticsUnitController controller,
      EElement elem,
      bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF5")]
    [Address(RVA = "0x1234520", Offset = "0x1233320", VA = "0x11234520")]
    public EventScript.Sequence OnRecvSkillCond(
      TacticsUnitController controller,
      EUnitCondition cond,
      bool isFirstPlay)
    {
      return (EventScript.Sequence) null;
    }

    [Token(Token = "0x6004DF6")]
    [Address(RVA = "0x1233F60", Offset = "0x1232D60", VA = "0x11233F60")]
    private bool IsContainsUnit(
      string unit_name,
      TacticsUnitController self,
      TacticsUnitController opp = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004DF7")]
    [Address(RVA = "0x1233E70", Offset = "0x1232C70", VA = "0x11233E70")]
    private bool IsContainsSkill(string skill_name, SkillData skill) => new bool();

    [Token(Token = "0x6004DF8")]
    [Address(RVA = "0x1235DF0", Offset = "0x1234BF0", VA = "0x11235DF0")]
    public EventScript()
    {
    }

    [Token(Token = "0x6004DF9")]
    [Address(RVA = "0x1235720", Offset = "0x1234520", VA = "0x11235720")]
    static EventScript()
    {
    }

    [Token(Token = "0x2001260")]
    public delegate void AutoFlagChange(bool enable);

    [Token(Token = "0x2001261")]
    public delegate void OnBackLogButtonClick();

    [Token(Token = "0x2001262")]
    [Serializable]
    public class ScriptSequence
    {
      [Token(Token = "0x40043BC")]
      [FieldOffset(Offset = "0x8")]
      [StringIsActorID]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UnitStart, EventScript.ScriptSequence.StartConditions.HPBelowPercent, EventScript.ScriptSequence.StartConditions.UnitTurnStart, EventScript.ScriptSequence.StartConditions.UnitAppear, EventScript.ScriptSequence.StartConditions.UnitDead, EventScript.ScriptSequence.StartConditions.StandbyGrid, EventScript.ScriptSequence.StartConditions.RestHP, EventScript.ScriptSequence.StartConditions.UseSkill, EventScript.ScriptSequence.StartConditions.UnitWithdraw, EventScript.ScriptSequence.StartConditions.RecvSkillElem, EventScript.ScriptSequence.StartConditions.RecvSkillCond})]
      public string UnitName;
      [Token(Token = "0x40043BD")]
      [FieldOffset(Offset = "0xC")]
      [Range(0.0f, 99f)]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.HPBelowPercent})]
      public int Percentage;
      [Token(Token = "0x40043BE")]
      [FieldOffset(Offset = "0x10")]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UnitStart, EventScript.ScriptSequence.StartConditions.TurnStart, EventScript.ScriptSequence.StartConditions.UnitTurnStart})]
      public int Turn;
      [Token(Token = "0x40043BF")]
      [FieldOffset(Offset = "0x14")]
      [StringIsGrid]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.StandbyGrid})]
      public string GridXY;
      [Token(Token = "0x40043C0")]
      [FieldOffset(Offset = "0x18")]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.RestHP})]
      [StringIsRestHP]
      public string RestHP;
      [Token(Token = "0x40043C1")]
      [FieldOffset(Offset = "0x1C")]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UseSkill})]
      [IntIsSkillTiming]
      public int SkillTiming;
      [Token(Token = "0x40043C2")]
      [FieldOffset(Offset = "0x20")]
      [StringIsTargetSkill]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UseSkill})]
      public string TargetSkill;
      [Token(Token = "0x40043C3")]
      [FieldOffset(Offset = "0x24")]
      [StringIsTargetUnit]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UseSkill})]
      public string TargetUnit;
      [Token(Token = "0x40043C4")]
      [FieldOffset(Offset = "0x28")]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.UnitTurnStart, EventScript.ScriptSequence.StartConditions.UnitAppear, EventScript.ScriptSequence.StartConditions.UnitDead, EventScript.ScriptSequence.StartConditions.StandbyGrid, EventScript.ScriptSequence.StartConditions.RestHP, EventScript.ScriptSequence.StartConditions.UseSkill, EventScript.ScriptSequence.StartConditions.UnitWithdraw})]
      public bool IsFirstOnly;
      [Token(Token = "0x40043C5")]
      [FieldOffset(Offset = "0x2C")]
      [IntIsSkillElem]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.RecvSkillElem})]
      public int SkillElem;
      [Token(Token = "0x40043C6")]
      [FieldOffset(Offset = "0x30")]
      [IntIsSkillCond]
      [EventScript.ScriptSequence.ConditionAttr(new EventScript.ScriptSequence.StartConditions[] {EventScript.ScriptSequence.StartConditions.RecvSkillCond})]
      public int SkillCond;
      [Token(Token = "0x40043C7")]
      [FieldOffset(Offset = "0x34")]
      public EventScript.ScriptSequence.StartConditions Trigger;
      [Token(Token = "0x40043C8")]
      [FieldOffset(Offset = "0x38")]
      public List<EventAction> Actions;
      [Token(Token = "0x40043C9")]
      [FieldOffset(Offset = "0x3C")]
      [NonSerialized]
      public bool Triggered;

      [Token(Token = "0x170008C0")]
      public bool IsSavePlayBgmID
      {
        [Token(Token = "0x6004E02"), Address(RVA = "0x1236890", Offset = "0x1235690", VA = "0x11236890")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6004E03")]
      [Address(RVA = "0x1236870", Offset = "0x1235670", VA = "0x11236870")]
      public ScriptSequence()
      {
      }

      [Token(Token = "0x2001263")]
      public class ConditionAttr : Attribute
      {
        [Token(Token = "0x40043CA")]
        [FieldOffset(Offset = "0x8")]
        public EventScript.ScriptSequence.StartConditions[] Conditions;

        [Token(Token = "0x6004E04")]
        [Address(RVA = "0x3010C0", Offset = "0x2FFEC0", VA = "0x103010C0")]
        public ConditionAttr(
          params EventScript.ScriptSequence.StartConditions[] conditions)
        {
        }

        [Token(Token = "0x6004E05")]
        [Address(RVA = "0x1227B80", Offset = "0x1226980", VA = "0x11227B80")]
        public bool Contains(
          EventScript.ScriptSequence.StartConditions condition)
        {
          return new bool();
        }
      }

      [Token(Token = "0x2001264")]
      public enum StartConditions
      {
        [Token(Token = "0x40043CC")] Auto,
        [Token(Token = "0x40043CD")] UnitStart,
        [Token(Token = "0x40043CE")] HPBelowPercent,
        [Token(Token = "0x40043CF")] Win,
        [Token(Token = "0x40043D0")] TurnStart,
        [Token(Token = "0x40043D1")] PostMapLoad,
        [Token(Token = "0x40043D2")] UnitTurnStart,
        [Token(Token = "0x40043D3")] UnitAppear,
        [Token(Token = "0x40043D4")] UnitDead,
        [Token(Token = "0x40043D5")] StandbyGrid,
        [Token(Token = "0x40043D6")] RestHP,
        [Token(Token = "0x40043D7")] UseSkill,
        [Token(Token = "0x40043D8")] UnitWithdraw,
        [Token(Token = "0x40043D9")] Lose,
        [Token(Token = "0x40043DA")] RecvSkillElem,
        [Token(Token = "0x40043DB")] RecvSkillCond,
      }
    }

    [Token(Token = "0x2001265")]
    public class cRestHP
    {
      [Token(Token = "0x40043DC")]
      [FieldOffset(Offset = "0x8")]
      public List<EventScript.cRestHP.Cond> mCondLists;

      [Token(Token = "0x6004E06")]
      [Address(RVA = "0x123C680", Offset = "0x123B480", VA = "0x1123C680")]
      public cRestHP()
      {
      }

      [Token(Token = "0x2001266")]
      public class Cond
      {
        [Token(Token = "0x40043DD")]
        [FieldOffset(Offset = "0x8")]
        public EventScript.cRestHP.Cond.CompType mComp;
        [Token(Token = "0x40043DE")]
        [FieldOffset(Offset = "0xC")]
        public int mVal;
        [Token(Token = "0x40043DF")]
        [FieldOffset(Offset = "0x10")]
        public EventScript.cRestHP.Cond.CalcType mCalc;

        [Token(Token = "0x6004E07")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Cond()
        {
        }

        [Token(Token = "0x6004E08")]
        [Address(RVA = "0x1227B40", Offset = "0x1226940", VA = "0x11227B40")]
        public Cond(int comp, int val, int calc)
        {
        }

        [Token(Token = "0x2001267")]
        public enum CompType
        {
          [Token(Token = "0x40043E1")] EQUAL,
          [Token(Token = "0x40043E2")] NOT_EQUAL,
          [Token(Token = "0x40043E3")] GREATER,
          [Token(Token = "0x40043E4")] GREATER_EQUAL,
          [Token(Token = "0x40043E5")] LESS,
          [Token(Token = "0x40043E6")] LESS_EQUAL,
          [Token(Token = "0x40043E7")] MAX,
        }

        [Token(Token = "0x2001268")]
        public enum CalcType
        {
          [Token(Token = "0x40043E9")] SCALE,
          [Token(Token = "0x40043EA")] FIXED,
          [Token(Token = "0x40043EB")] MAX,
        }
      }
    }

    [Token(Token = "0x2001269")]
    public enum SkillTiming
    {
      [Token(Token = "0x40043ED")] BEFORE,
      [Token(Token = "0x40043EE")] AFTER,
      [Token(Token = "0x40043EF")] MAX,
    }

    [Token(Token = "0x200126A")]
    private delegate bool TestCondition(EventScript.ScriptSequence trigger);

    [Token(Token = "0x200126B")]
    public class Sequence : MonoBehaviour
    {
      [Token(Token = "0x40043F0")]
      [FieldOffset(Offset = "0xC")]
      public EventScript Script;
      [Token(Token = "0x40043F1")]
      [FieldOffset(Offset = "0x10")]
      public EventAction[] Actions;
      [Token(Token = "0x40043F2")]
      [FieldOffset(Offset = "0x14")]
      private bool mReady;
      [Token(Token = "0x40043F3")]
      [FieldOffset(Offset = "0x15")]
      private bool mForceSkip;
      [Token(Token = "0x40043F4")]
      [FieldOffset(Offset = "0x18")]
      private int mLastActionIndex;
      [Token(Token = "0x40043F5")]
      [FieldOffset(Offset = "0x1C")]
      private List<int> mForceSkipIndex;
      [Token(Token = "0x40043F6")]
      [FieldOffset(Offset = "0x20")]
      private UnityAction mClickAction;
      [Token(Token = "0x40043F7")]
      [FieldOffset(Offset = "0x24")]
      public bool IsAutoForward;
      [Token(Token = "0x40043F8")]
      [FieldOffset(Offset = "0x28")]
      private float mTimerAutoForward;
      [Token(Token = "0x40043F9")]
      [FieldOffset(Offset = "0x2C")]
      private int mCurIdxAutoForward;
      [Token(Token = "0x40043FA")]
      [FieldOffset(Offset = "0x30")]
      public EventScript.ScriptSequence ParentSequence;
      [Token(Token = "0x40043FB")]
      [FieldOffset(Offset = "0x34")]
      private GameObject mScene;
      [Token(Token = "0x40043FC")]
      [FieldOffset(Offset = "0x38")]
      public List<GameObject> SpawnedObjects;

      [Token(Token = "0x170008C1")]
      public GameObject Scene
      {
        [Token(Token = "0x6004E0D"), Address(RVA = "0x1237E10", Offset = "0x1236C10", VA = "0x11237E10")] set
        {
        }
        [Token(Token = "0x6004E0E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return (GameObject) null;
        }
      }

      [Token(Token = "0x6004E0F")]
      [Address(RVA = "0x12375D0", Offset = "0x12363D0", VA = "0x112375D0")]
      private void Start()
      {
      }

      [Token(Token = "0x6004E10")]
      [Address(RVA = "0x1236A30", Offset = "0x1235830", VA = "0x11236A30")]
      private void OnDestroy()
      {
      }

      [Token(Token = "0x6004E11")]
      [Address(RVA = "0x1237350", Offset = "0x1236150", VA = "0x11237350")]
      private IEnumerator PreloadAssetsAsync() => (IEnumerator) null;

      [Token(Token = "0x6004E12")]
      [Address(RVA = "0x1237440", Offset = "0x1236240", VA = "0x11237440")]
      private void StartActions()
      {
      }

      [Token(Token = "0x6004E13")]
      [Address(RVA = "0x1237760", Offset = "0x1236560", VA = "0x11237760")]
      private void Update()
      {
      }

      [Token(Token = "0x6004E14")]
      [Address(RVA = "0x1237500", Offset = "0x1236300", VA = "0x11237500")]
      private void StartForceSkip()
      {
      }

      [Token(Token = "0x170008C2")]
      public bool IsPlaying
      {
        [Token(Token = "0x6004E15"), Address(RVA = "0x1237DB0", Offset = "0x1236BB0", VA = "0x11237DB0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6004E16")]
      [Address(RVA = "0x12369C0", Offset = "0x12357C0", VA = "0x112369C0")]
      private void OnClick()
      {
      }

      [Token(Token = "0x6004E17")]
      [Address(RVA = "0x12368C0", Offset = "0x12356C0", VA = "0x112368C0")]
      public void GoToEndState()
      {
      }

      [Token(Token = "0x6004E18")]
      [Address(RVA = "0x1237040", Offset = "0x1235E40", VA = "0x11237040")]
      public void OnQuit()
      {
      }

      [Token(Token = "0x6004E19")]
      [Address(RVA = "0x1236F60", Offset = "0x1235D60", VA = "0x11236F60")]
      public void OnQuitImmediate()
      {
      }

      [Token(Token = "0x6004E1A")]
      [Address(RVA = "0x12373C0", Offset = "0x12361C0", VA = "0x112373C0")]
      public bool ReplaySkipButtonEnable() => new bool();

      [Token(Token = "0x6004E1B")]
      [Address(RVA = "0x1237CF0", Offset = "0x1236AF0", VA = "0x11237CF0")]
      public Sequence()
      {
      }
    }
  }
}
