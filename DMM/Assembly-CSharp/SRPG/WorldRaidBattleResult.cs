// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBattleResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D3D")]
  [FlowNode.Pin(21, "Start Reward", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(101, "Finish Attack Damage", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(102, "Finish Total Damage", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(103, "Finish Reward", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(12, "Skip Total Damage", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "Start Total Damage", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(41, "Finish All Effect", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(105, "Finish All Effect", FlowNode.PinTypes.Output, 42)]
  [AddComponentMenu("UI/WorldRaid/WorldRaidBattleResult")]
  [FlowNode.Pin(1, "Start Attack Damage", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Skip Attack Damage", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(22, "Skip Reward", FlowNode.PinTypes.Input, 22)]
  public class WorldRaidBattleResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E186")]
    private const int PIN_IN_START_ATTACK_DAMAGE = 1;
    [Token(Token = "0x400E187")]
    private const int PIN_IN_SKIP_ATTACK_DAMAGE = 2;
    [Token(Token = "0x400E188")]
    private const int PIN_IN_START_TOTAL_DAMAGE = 11;
    [Token(Token = "0x400E189")]
    private const int PIN_IN_SKIP_TOTAL_DAMAGE = 12;
    [Token(Token = "0x400E18A")]
    private const int PIN_IN_START_REWARD = 21;
    [Token(Token = "0x400E18B")]
    private const int PIN_IN_SKIP_REWARD = 22;
    [Token(Token = "0x400E18C")]
    private const int PIN_IN_FINISH_ALL_EFFECT = 41;
    [Token(Token = "0x400E18D")]
    private const int PIN_OUT_FINISH_ATTACK_DAMAGE = 101;
    [Token(Token = "0x400E18E")]
    private const int PIN_OUT_FINISH_TOTAL_DAMAGE = 102;
    [Token(Token = "0x400E18F")]
    private const int PIN_OUT_FINISH_REWARD = 103;
    [Token(Token = "0x400E190")]
    private const int PIN_OUT_FINISH_ALL_EFFECT = 105;
    [Token(Token = "0x400E191")]
    private const string ITEM_INAME_REWARD_EMPTY = "NONE";
    [Token(Token = "0x400E192")]
    private const string REWARD_ICON_PATH = "UI/RaidRewardIcon";
    [Token(Token = "0x400E193")]
    private const string REWARD_ICON_PARENT_NAME = "item";
    [Token(Token = "0x400E194")]
    private const string REWARD_ICON_LASTATTACK_BADGE = "lastattack";
    [Token(Token = "0x400E195")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼キャラクタイメージ")]
    [SerializeField]
    private GameObject CharacterImage;
    [Token(Token = "0x400E196")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼ダメージ表示")]
    [SerializeField]
    private GameObject AttackDamageParent;
    [Token(Token = "0x400E197")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text AttackDamageText01;
    [Token(Token = "0x400E198")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text AttackDamageText02;
    [Token(Token = "0x400E199")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text AttackDamageText03;
    [Token(Token = "0x400E19A")]
    [FieldOffset(Offset = "0x20")]
    [HeaderBar("▼トータルダメージ表示")]
    [SerializeField]
    private GameObject TotalDamageParent;
    [Token(Token = "0x400E19B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text TotalDamageText01;
    [Token(Token = "0x400E19C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text TotalDamageText02;
    [Token(Token = "0x400E19D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text TotalDamageText03;
    [Token(Token = "0x400E19E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HeaderBar("▼報酬")]
    private GameObject RewardParent;
    [Token(Token = "0x400E19F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject RewardIconBase;
    [Token(Token = "0x400E1A0")]
    [FieldOffset(Offset = "0x38")]
    [HeaderBar("▼SerializeValueBehaviour")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValueBehaviourData;
    [Token(Token = "0x400E1A1")]
    [FieldOffset(Offset = "0x3C")]
    private SRPG.StateMachine<WorldRaidBattleResult> StateMachine;
    [Token(Token = "0x400E1A2")]
    [FieldOffset(Offset = "0x40")]
    private GameObject RewardIconPrefab;

    [Token(Token = "0x600D2DB")]
    [Address(RVA = "0x9E1B50", Offset = "0x9E0950", VA = "0x109E1B50")]
    private void Start()
    {
    }

    [Token(Token = "0x600D2DC")]
    [Address(RVA = "0x9E1DD0", Offset = "0x9E0BD0", VA = "0x109E1DD0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D2DD")]
    [Address(RVA = "0x9E1A30", Offset = "0x9E0830", VA = "0x109E1A30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D2DE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidBattleResult()
    {
    }

    [Token(Token = "0x2002D3E")]
    private class State_Idle : State<WorldRaidBattleResult>
    {
      [Token(Token = "0x600D2DF")]
      [Address(RVA = "0x9E0480", Offset = "0x9DF280", VA = "0x109E0480")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x2002D3F")]
    private abstract class State_DisplayDamage : State<WorldRaidBattleResult>
    {
      [Token(Token = "0x400E1A3")]
      protected const float NEXT_NUMBER_SECOND = 0.5f;
      [Token(Token = "0x400E1A4")]
      protected const string DECIDE_NUMBER_SE = "SE_1075";
      [Token(Token = "0x400E1A5")]
      protected const string FINISH_DECIDE_NUMBER_SE = "SE_1076";
      [Token(Token = "0x400E1A6")]
      protected const string EFFECT_TEXT_NAME = "count_font_add";
      [Token(Token = "0x400E1A7")]
      protected const float LAST_DIGIT_SCALE = 1f;
      [Token(Token = "0x400E1A8")]
      private const int CHANGE_COLOR_DIGITS_NUM_01 = 6;
      [Token(Token = "0x400E1A9")]
      private const int CHANGE_COLOR_DIGITS_NUM_02 = 9;
      [Token(Token = "0x400E1AA")]
      [FieldOffset(Offset = "0xC")]
      private List<WorldRaidBattleResult.State_DisplayDamage.DamageText> DamageTextList;
      [Token(Token = "0x400E1AB")]
      [FieldOffset(Offset = "0x10")]
      private int CountupDigitsNum;
      [Token(Token = "0x400E1AC")]
      [FieldOffset(Offset = "0x14")]
      private float CountupTime;

      [Token(Token = "0x600D2E0")]
      [Address(RVA = "0x9DEDC0", Offset = "0x9DDBC0", VA = "0x109DEDC0")]
      protected void Init(
        GameObject parent,
        GameObject hideTarget,
        Text text1,
        Text text2,
        Text text3,
        long damage)
      {
      }

      [Token(Token = "0x600D2E1")]
      [Address(RVA = "0x9DF490", Offset = "0x9DE290", VA = "0x109DF490", Slot = "5")]
      public override void Update(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2E2")]
      [Address(RVA = "0x9DED40", Offset = "0x9DDB40", VA = "0x109DED40", Slot = "7")]
      public override void Command(WorldRaidBattleResult self, string cmd)
      {
      }

      [Token(Token = "0x600D2E3")]
      [Address(RVA = "0x9DF0A0", Offset = "0x9DDEA0", VA = "0x109DF0A0")]
      protected bool Next() => new bool();

      [Token(Token = "0x600D2E4")]
      [Address(RVA = "0x9DF320", Offset = "0x9DE120", VA = "0x109DF320")]
      public void Skip()
      {
      }

      [Token(Token = "0x600D2E5")]
      [Address(RVA = "0x9DF4F0", Offset = "0x9DE2F0", VA = "0x109DF4F0")]
      protected State_DisplayDamage()
      {
      }

      [Token(Token = "0x2002D40")]
      protected struct DamageText
      {
        [Token(Token = "0x400E1AD")]
        [FieldOffset(Offset = "0x0")]
        public Text text;
        [Token(Token = "0x400E1AE")]
        [FieldOffset(Offset = "0x4")]
        public int num;

        [Token(Token = "0x600D2E6")]
        [Address(RVA = "0x7F2780", Offset = "0x7F1580", VA = "0x107F2780")]
        public DamageText(Text text, int num)
        {
        }
      }
    }

    [Token(Token = "0x2002D41")]
    private class State_AttackDamage : WorldRaidBattleResult.State_DisplayDamage
    {
      [Token(Token = "0x600D2E7")]
      [Address(RVA = "0x9DEAD0", Offset = "0x9DD8D0", VA = "0x109DEAD0", Slot = "4")]
      public override void Begin(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2E8")]
      [Address(RVA = "0x9DED10", Offset = "0x9DDB10", VA = "0x109DED10", Slot = "6")]
      public override void End(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2E9")]
      [Address(RVA = "0x9DED30", Offset = "0x9DDB30", VA = "0x109DED30")]
      public State_AttackDamage()
      {
      }
    }

    [Token(Token = "0x2002D43")]
    private class State_TotalDamage : WorldRaidBattleResult.State_DisplayDamage
    {
      [Token(Token = "0x600D2ED")]
      [Address(RVA = "0x9E04C0", Offset = "0x9DF2C0", VA = "0x109E04C0", Slot = "4")]
      public override void Begin(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2EE")]
      [Address(RVA = "0x9E0540", Offset = "0x9DF340", VA = "0x109E0540", Slot = "6")]
      public override void End(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2EF")]
      [Address(RVA = "0x9DED30", Offset = "0x9DDB30", VA = "0x109DED30")]
      public State_TotalDamage()
      {
      }
    }

    [Token(Token = "0x2002D44")]
    private class State_DisplayReward : State<WorldRaidBattleResult>
    {
      [Token(Token = "0x400E1B1")]
      protected const float NEXT_ITEM_SECOND = 0.2f;
      [Token(Token = "0x400E1B2")]
      [FieldOffset(Offset = "0xC")]
      private List<GameObject> RewardIconList;
      [Token(Token = "0x400E1B3")]
      [FieldOffset(Offset = "0x10")]
      private List<Coroutine> CoroutineList;
      [Token(Token = "0x400E1B4")]
      [FieldOffset(Offset = "0x14")]
      private List<RaidRewardIcon> RaidRewardIconList;
      [Token(Token = "0x400E1B5")]
      [FieldOffset(Offset = "0x18")]
      private float CountupTime;
      [Token(Token = "0x400E1B6")]
      [FieldOffset(Offset = "0x1C")]
      private int IconIndex;

      [Token(Token = "0x600D2F0")]
      [Address(RVA = "0x9DF5E0", Offset = "0x9DE3E0", VA = "0x109DF5E0", Slot = "4")]
      public override void Begin(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2F1")]
      [Address(RVA = "0x9E00D0", Offset = "0x9DEED0", VA = "0x109E00D0", Slot = "5")]
      public override void Update(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D2F2")]
      [Address(RVA = "0x9DFE50", Offset = "0x9DEC50", VA = "0x109DFE50", Slot = "7")]
      public override void Command(WorldRaidBattleResult self, string cmd)
      {
      }

      [Token(Token = "0x600D2F3")]
      [Address(RVA = "0x9DF570", Offset = "0x9DE370", VA = "0x109DF570")]
      private IEnumerator Anim(GameObject target) => (IEnumerator) null;

      [Token(Token = "0x600D2F4")]
      [Address(RVA = "0x9DFF00", Offset = "0x9DED00", VA = "0x109DFF00")]
      private void Skip()
      {
      }

      [Token(Token = "0x600D2F5")]
      [Address(RVA = "0x9DFEE0", Offset = "0x9DECE0", VA = "0x109DFEE0")]
      private void Finish()
      {
      }

      [Token(Token = "0x600D2F6")]
      [Address(RVA = "0x9E0290", Offset = "0x9DF090", VA = "0x109E0290")]
      public State_DisplayReward()
      {
      }
    }

    [Token(Token = "0x2002D47")]
    private class State_Finish : State<WorldRaidBattleResult>
    {
      [Token(Token = "0x600D2FF")]
      [Address(RVA = "0x9E03A0", Offset = "0x9DF1A0", VA = "0x109E03A0", Slot = "4")]
      public override void Begin(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D300")]
      [Address(RVA = "0x9E0420", Offset = "0x9DF220", VA = "0x109E0420", Slot = "6")]
      public override void End(WorldRaidBattleResult self)
      {
      }

      [Token(Token = "0x600D301")]
      [Address(RVA = "0x9E0440", Offset = "0x9DF240", VA = "0x109E0440")]
      public State_Finish()
      {
      }
    }
  }
}
