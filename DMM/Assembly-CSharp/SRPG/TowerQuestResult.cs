// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B54")]
  [AddComponentMenu("UI/TowerQuestResult")]
  [FlowNode.Pin(201, "ミッション不達成（敵が復活した）", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "ミッション不達成", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(32, "クリア演出終了", FlowNode.PinTypes.Output, 32)]
  [FlowNode.Pin(11, "クリア演出開始", FlowNode.PinTypes.Input, 11)]
  public class TowerQuestResult : QuestResult
  {
    [Token(Token = "0x400D3FB")]
    private const int INPUT_START_EFFECT = 11;
    [Token(Token = "0x400D3FC")]
    private const int OUTPUT_END_EFFECT = 32;
    [Token(Token = "0x400D3FD")]
    private const int OUTPUT_MISSION_FAILURE = 200;
    [Token(Token = "0x400D3FE")]
    private const int OUTPUT_MISSION_FAILURE_RESET = 201;
    [Token(Token = "0x400D3FF")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    [Description("塔報酬画面用入手アイテムのゲームオブジェクト")]
    [HeaderBar("▼ヴェーダ用")]
    private GameObject TowerTreasureListItem;
    [Token(Token = "0x400D400")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    private GameObject m_RewardPanel;
    [Token(Token = "0x400D401")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    [Description("クリア条件の星にトリガーを送る間隔 (秒数)")]
    private float TowerItem_TriggerInterval;
    [Token(Token = "0x400D402")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    private float DeadAlpha;
    [Token(Token = "0x400D403")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private TowerClear TowerClear;
    [Token(Token = "0x400D404")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400D405")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private string PreRewardAnimationTrigger;
    [Token(Token = "0x400D406")]
    [FieldOffset(Offset = "0x17C")]
    [SerializeField]
    private string PostRewardAnimationTrigger;
    [Token(Token = "0x400D407")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private float PreRewardAnimationDelay;
    [Token(Token = "0x400D408")]
    [FieldOffset(Offset = "0x184")]
    [SerializeField]
    private float PostRewardAnimationDelay;
    [Token(Token = "0x400D409")]
    [FieldOffset(Offset = "0x188")]
    private List<GameObject> mTowerListItems;
    [Token(Token = "0x400D40A")]
    [FieldOffset(Offset = "0x18C")]
    private List<HpBarSlider> mHpBar;
    [Token(Token = "0x400D40B")]
    [FieldOffset(Offset = "0x190")]
    private List<TowerUnitIsDead> canvas_group;
    [Token(Token = "0x400D40C")]
    [FieldOffset(Offset = "0x194")]
    private bool mContinueTowerItemAnimation;
    [Token(Token = "0x400D40D")]
    [FieldOffset(Offset = "0x195")]
    private bool mContinueTowerItem;
    [Token(Token = "0x400D40E")]
    [FieldOffset(Offset = "0x198")]
    private BattleCore.Record m_QuestRecord;
    [Token(Token = "0x400D40F")]
    [FieldOffset(Offset = "0x19C")]
    private TowerQuestResult.eTowerResultFlags m_TowerResultFlags;

    [Token(Token = "0x17001A48")]
    private bool IsEnableMission
    {
      [Token(Token = "0x600C667"), Address(RVA = "0x8F10F0", Offset = "0x8EFEF0", VA = "0x108F10F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A49")]
    private bool IsUnlockNextFloor
    {
      [Token(Token = "0x600C668"), Address(RVA = "0x8F1130", Offset = "0x8EFF30", VA = "0x108F1130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A4A")]
    private bool IsEnemyReset
    {
      [Token(Token = "0x600C669"), Address(RVA = "0x8F1110", Offset = "0x8EFF10", VA = "0x108F1110")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C66A")]
    [Address(RVA = "0x8EFB20", Offset = "0x8EE920", VA = "0x108EFB20", Slot = "7")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C66B")]
    [Address(RVA = "0x8F0DA0", Offset = "0x8EFBA0", VA = "0x108F0DA0")]
    private void UpdateResultFlags()
    {
    }

    [Token(Token = "0x600C66C")]
    [Address(RVA = "0x8F09D0", Offset = "0x8EF7D0", VA = "0x108F09D0")]
    public void EndTowerClear()
    {
    }

    [Token(Token = "0x600C66D")]
    [Address(RVA = "0x8F0B10", Offset = "0x8EF910", VA = "0x108F0B10")]
    private IEnumerator RecvHealAnimation() => (IEnumerator) null;

    [Token(Token = "0x600C66E")]
    [Address(RVA = "0x8F09F0", Offset = "0x8EF7F0", VA = "0x108F09F0")]
    private bool IsHealEnd(List<TowerQuestResult.HealParanm> param) => new bool();

    [Token(Token = "0x600C66F")]
    [Address(RVA = "0x8F0680", Offset = "0x8EF480", VA = "0x108F0680", Slot = "5")]
    public override void CreateItemObject(List<QuestResult.DropItemData> items, Transform parent)
    {
    }

    [Token(Token = "0x600C670")]
    [Address(RVA = "0x8F08F0", Offset = "0x8EF6F0", VA = "0x108F08F0")]
    private GameObject CreateRewardObject() => (GameObject) null;

    [Token(Token = "0x600C671")]
    [Address(RVA = "0x8F03D0", Offset = "0x8EF1D0", VA = "0x108F03D0")]
    private void BindData(GameObject obj, TowerRewardItem reward, int rewardIndex)
    {
    }

    [Token(Token = "0x600C672")]
    [Address(RVA = "0x8EFCB0", Offset = "0x8EEAB0", VA = "0x108EFCB0", Slot = "6")]
    public override void AddExpPlayer()
    {
    }

    [Token(Token = "0x600C673")]
    [Address(RVA = "0x8F0360", Offset = "0x8EF160", VA = "0x108F0360", Slot = "9")]
    public override IEnumerator AddExp() => (IEnumerator) null;

    [Token(Token = "0x600C674")]
    [Address(RVA = "0x8F0C30", Offset = "0x8EFA30", VA = "0x108F0C30")]
    private void SetAnimationBool(string name, bool value)
    {
    }

    [Token(Token = "0x600C675")]
    [Address(RVA = "0x8F0AA0", Offset = "0x8EF8A0", VA = "0x108F0AA0", Slot = "8")]
    public override IEnumerator PlayAnimationAsync() => (IEnumerator) null;

    [Token(Token = "0x600C676")]
    [Address(RVA = "0x8F0CC0", Offset = "0x8EFAC0", VA = "0x108F0CC0")]
    public IEnumerator StartTowerTreasureAnimation() => (IEnumerator) null;

    [Token(Token = "0x600C677")]
    [Address(RVA = "0x8F0D30", Offset = "0x8EFB30", VA = "0x108F0D30")]
    protected IEnumerator TowerTreasureAnimation(List<GameObject> ListItems) => (IEnumerator) null;

    [Token(Token = "0x600C678")]
    [Address(RVA = "0x8F0A80", Offset = "0x8EF880", VA = "0x108F0A80")]
    public void OnTowerItemAnimationEnd()
    {
    }

    [Token(Token = "0x600C679")]
    [Address(RVA = "0x8F0A90", Offset = "0x8EF890", VA = "0x108F0A90")]
    public void OnTowerItemEnd()
    {
    }

    [Token(Token = "0x600C67A")]
    [Address(RVA = "0x8F0BA0", Offset = "0x8EF9A0", VA = "0x108F0BA0")]
    private bool ResultFlags_IsOn(TowerQuestResult.eTowerResultFlags flags) => new bool();

    [Token(Token = "0x600C67B")]
    [Address(RVA = "0x8F0B80", Offset = "0x8EF980", VA = "0x108F0B80")]
    private bool ResultFlags_IsOff(TowerQuestResult.eTowerResultFlags flags) => new bool();

    [Token(Token = "0x600C67C")]
    [Address(RVA = "0x8F0BE0", Offset = "0x8EF9E0", VA = "0x108F0BE0")]
    private void ResultFlags_SetOn(TowerQuestResult.eTowerResultFlags flags)
    {
    }

    [Token(Token = "0x600C67D")]
    [Address(RVA = "0x8F0BC0", Offset = "0x8EF9C0", VA = "0x108F0BC0")]
    private void ResultFlags_SetOff(TowerQuestResult.eTowerResultFlags flags)
    {
    }

    [Token(Token = "0x600C67E")]
    [Address(RVA = "0x8F0C00", Offset = "0x8EFA00", VA = "0x108F0C00")]
    private void ResultFlags_Set(TowerQuestResult.eTowerResultFlags flags, bool value)
    {
    }

    [Token(Token = "0x600C67F")]
    [Address(RVA = "0x8F0FD0", Offset = "0x8EFDD0", VA = "0x108F0FD0")]
    public TowerQuestResult()
    {
    }

    [Token(Token = "0x2002B55")]
    [Flags]
    private enum eTowerResultFlags
    {
      [Token(Token = "0x400D411")] Win = 1,
      [Token(Token = "0x400D412")] Lose = 2,
      [Token(Token = "0x400D413")] Clear = 4,
      [Token(Token = "0x400D414")] ShowRank = 8,
      [Token(Token = "0x400D415")] MissionFailure = 16, // 0x00000010
      [Token(Token = "0x400D416")] MissionComplete = 32, // 0x00000020
    }

    [Token(Token = "0x2002B56")]
    private class HealParanm
    {
      [Token(Token = "0x400D417")]
      [FieldOffset(Offset = "0x8")]
      public Unit unit;
      [Token(Token = "0x400D418")]
      [FieldOffset(Offset = "0xC")]
      public int hp;
      [Token(Token = "0x400D419")]
      [FieldOffset(Offset = "0x10")]
      public int hp_heal;
      [Token(Token = "0x400D41A")]
      [FieldOffset(Offset = "0x14")]
      public float hp_gainRate;
      [Token(Token = "0x400D41B")]
      [FieldOffset(Offset = "0x18")]
      public int hpGained;
      [Token(Token = "0x400D41C")]
      [FieldOffset(Offset = "0x1C")]
      public float hpAccumulator;
      [Token(Token = "0x400D41D")]
      [FieldOffset(Offset = "0x20")]
      public HpBarSlider hp_bar;

      [Token(Token = "0x600C680")]
      [Address(RVA = "0x8E31F0", Offset = "0x8E1FF0", VA = "0x108E31F0")]
      public HealParanm(
        Unit unit,
        TowerFloorParam FloorParam,
        HpBarSlider hp_bar,
        float GainRate,
        float GainTimeMax)
      {
      }

      [Token(Token = "0x600C681")]
      [Address(RVA = "0x8E3030", Offset = "0x8E1E30", VA = "0x108E3030")]
      public void Update()
      {
      }
    }
  }
}
