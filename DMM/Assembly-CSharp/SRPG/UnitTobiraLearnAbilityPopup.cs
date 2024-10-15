// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraLearnAbilityPopup
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
  [Token(Token = "0x2002D1A")]
  [FlowNode.Pin(0, "次の表示はありますか？", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "次の表示はあります", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "次の表示はありません", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "次の表示へ切り替える", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(201, "次の表示へ切り替え中", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "次の表示へ切り替えた", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(300, "全ての表示完了", FlowNode.PinTypes.Output, 300)]
  [AddComponentMenu("UI/UnitTobiraLearnAbilityPopup")]
  public class UnitTobiraLearnAbilityPopup : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E095")]
    public const int PIN_INPUT_ASK_NEXT_VIEW = 0;
    [Token(Token = "0x400E096")]
    public const int PIN_OUTPUT_HAS_NEXT_VIEW = 100;
    [Token(Token = "0x400E097")]
    public const int PIN_OUTPUT_DONT_HAVE_NEXT_VIEW = 101;
    [Token(Token = "0x400E098")]
    public const int PIN_INPUT_CHANGE_NEXT_VIEW = 200;
    [Token(Token = "0x400E099")]
    public const int PIN_OUTPUT_CHANGING_NEXT_VIEW = 201;
    [Token(Token = "0x400E09A")]
    public const int PIN_OUTPUT_CHANGED_NEXT_VIEW = 202;
    [Token(Token = "0x400E09B")]
    public const int PIN_OUTPUT_COMPLETE = 300;
    [Token(Token = "0x400E09C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTitleText;
    [Token(Token = "0x400E09D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x400E09E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mDescText;
    [Token(Token = "0x400E09F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400E0A0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mAbilityDescWindow;
    [Token(Token = "0x400E0A1")]
    [FieldOffset(Offset = "0x20")]
    private Queue<UnitTobiraLearnAbilityPopup.ViewParam> mViewParams;
    [Token(Token = "0x400E0A2")]
    [FieldOffset(Offset = "0x24")]
    private UnitTobiraLearnAbilityPopup.ViewParam mCurrentViewParam;
    [Token(Token = "0x400E0A3")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine mChangeViewRoutine;

    [Token(Token = "0x17001B91")]
    private bool HasNextView
    {
      [Token(Token = "0x600D210"), Address(RVA = "0x9D1FE0", Offset = "0x9D0DE0", VA = "0x109D1FE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D211")]
    [Address(RVA = "0x9D16A0", Offset = "0x9D04A0", VA = "0x109D16A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D212")]
    [Address(RVA = "0x9D1820", Offset = "0x9D0620", VA = "0x109D1820")]
    private void ChangeNextView()
    {
    }

    [Token(Token = "0x600D213")]
    [Address(RVA = "0x9D18B0", Offset = "0x9D06B0", VA = "0x109D18B0")]
    private IEnumerator InternalChangeNextView() => (IEnumerator) null;

    [Token(Token = "0x600D214")]
    [Address(RVA = "0x9D1C90", Offset = "0x9D0A90", VA = "0x109D1C90")]
    public void Setup(UnitData unit, AbilityParam new_ability, AbilityParam old_ability)
    {
    }

    [Token(Token = "0x600D215")]
    [Address(RVA = "0x9D1DA0", Offset = "0x9D0BA0", VA = "0x109D1DA0")]
    public void Setup(UnitData unit, SkillParam skill)
    {
    }

    [Token(Token = "0x600D216")]
    [Address(RVA = "0x9D1E80", Offset = "0x9D0C80", VA = "0x109D1E80")]
    public void Setup(UnitData unit)
    {
    }

    [Token(Token = "0x600D217")]
    [Address(RVA = "0x9D1BA0", Offset = "0x9D09A0", VA = "0x109D1BA0")]
    public void SetupTruthEquipment(UnitData unit)
    {
    }

    [Token(Token = "0x600D218")]
    [Address(RVA = "0x9D1A10", Offset = "0x9D0810", VA = "0x109D1A10")]
    public void SetupNonDesc(UnitData unit)
    {
    }

    [Token(Token = "0x600D219")]
    [Address(RVA = "0x9D1780", Offset = "0x9D0580", VA = "0x109D1780")]
    private void AddViewParam(string title, string name, string desc)
    {
    }

    [Token(Token = "0x600D21A")]
    [Address(RVA = "0x9D1920", Offset = "0x9D0720", VA = "0x109D1920")]
    private void RefreshCurrentViewParam(bool isForceRefresh)
    {
    }

    [Token(Token = "0x600D21B")]
    [Address(RVA = "0x9D1F70", Offset = "0x9D0D70", VA = "0x109D1F70")]
    public UnitTobiraLearnAbilityPopup()
    {
    }

    [Token(Token = "0x2002D1B")]
    private class ViewParam
    {
      [Token(Token = "0x400E0A4")]
      [FieldOffset(Offset = "0x8")]
      public string mTitle;
      [Token(Token = "0x400E0A5")]
      [FieldOffset(Offset = "0xC")]
      public string mName;
      [Token(Token = "0x400E0A6")]
      [FieldOffset(Offset = "0x10")]
      public string mDesc;

      [Token(Token = "0x600D21C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewParam()
      {
      }
    }
  }
}
