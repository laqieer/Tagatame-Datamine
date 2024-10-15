// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEquipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A1")]
  [FlowNode.Pin(11, "装備", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "装備解除", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(16, "一括解除", FlowNode.PinTypes.Input, 16)]
  [FlowNode.Pin(21, "専用化画面遷移", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(15, "専用化", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(26, "一括解除画面へ遷移", FlowNode.PinTypes.Output, 26)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(13, "覚醒", FlowNode.PinTypes.Input, 13)]
  [AddComponentMenu("UI/Rune/RuneEquipWindow")]
  [FlowNode.Pin(101, "お気に入り通信完了後の描画更新", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(10, "強化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(14, "ステータス変更", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(100, "装備通信完了後の描画更新", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(20, "装備通信開始", FlowNode.PinTypes.Output, 20)]
  public class RuneEquipWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C967")]
    private const int INPUT_RUNE_ENHANCE = 10;
    [Token(Token = "0x400C968")]
    private const int INPUT_RUNE_EQUIP = 11;
    [Token(Token = "0x400C969")]
    private const int INPUT_RUNE_UNEQUIP = 12;
    [Token(Token = "0x400C96A")]
    private const int INPUT_RUNE_EVO = 13;
    [Token(Token = "0x400C96B")]
    private const int INPUT_STATUS_RESET = 14;
    [Token(Token = "0x400C96C")]
    private const int INPUT_RUNE_DEDICATED = 15;
    [Token(Token = "0x400C96D")]
    private const int INPUT_RUNE_BULK_RELEASE = 16;
    [Token(Token = "0x400C96E")]
    private const int OUTPUT_REQ_EQUIP = 20;
    [Token(Token = "0x400C96F")]
    private const int OUTPUT_RUNE_DEDICATED = 21;
    [Token(Token = "0x400C970")]
    private const int OUTPUT_RUNE_BULK_RELEASE = 26;
    [Token(Token = "0x400C971")]
    private const int INPUT_FINISH_EQUIP = 100;
    [Token(Token = "0x400C972")]
    private const int INPUT_FINISH_FAVORITE = 101;
    [Token(Token = "0x400C973")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C974")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneDrawInfo mRuneDrawInfo;
    [Token(Token = "0x400C975")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C976")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseState;
    [Token(Token = "0x400C977")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawEvoState mRuneDrawEvoState;
    [Token(Token = "0x400C978")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawSetEff mRuneDrawSetEff;
    [Token(Token = "0x400C979")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawDedicated mRuneDrawDedicated;
    [Token(Token = "0x400C97A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button mEnhanceButton;
    [Token(Token = "0x400C97B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button mEvoButton;
    [Token(Token = "0x400C97C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button mEquipButton;
    [Token(Token = "0x400C97D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button mUnEquipButton;
    [Token(Token = "0x400C97E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button mFavorite;
    [Token(Token = "0x400C97F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mDedicatedButton;
    [Token(Token = "0x400C980")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mBulkRelease;
    [Token(Token = "0x400C981")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button mBulkReleaseButton;
    [Token(Token = "0x400C982")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private FlowNode_ReqRuneFavorite mReqFavoriteNode;
    [Token(Token = "0x400C983")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<GameObject> mDisableButtonList;
    [Token(Token = "0x400C984")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private bool mIsEnableDedicated;
    [Token(Token = "0x400C985")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400C986")]
    [FieldOffset(Offset = "0x54")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C987")]
    [FieldOffset(Offset = "0x58")]
    private UnitData mUnit;
    [Token(Token = "0x400C989")]
    [FieldOffset(Offset = "0x60")]
    private RuneManager.RuneEquip mIsEquipWindow;

    [Token(Token = "0x1700198C")]
    public BindRuneData mRuneData
    {
      [Token(Token = "0x600BCD5"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (BindRuneData) null;
      }
      [Token(Token = "0x600BCD6"), Address(RVA = "0x525C30", Offset = "0x524A30", VA = "0x10525C30")] private set
      {
      }
    }

    [Token(Token = "0x600BCD7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BCD8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BCD9")]
    [Address(RVA = "0x848730", Offset = "0x847530", VA = "0x10848730")]
    private void RuneEquip()
    {
    }

    [Token(Token = "0x600BCDA")]
    [Address(RVA = "0x848840", Offset = "0x847640", VA = "0x10848840")]
    private void RuneUnequip()
    {
    }

    [Token(Token = "0x600BCDB")]
    [Address(RVA = "0x8486C0", Offset = "0x8474C0", VA = "0x108486C0")]
    private void RuneDedicated()
    {
    }

    [Token(Token = "0x600BCDC")]
    [Address(RVA = "0x848520", Offset = "0x847320", VA = "0x10848520")]
    private void RuneBulkRelease()
    {
    }

    [Token(Token = "0x600BCDD")]
    [Address(RVA = "0x8475A0", Offset = "0x8463A0", VA = "0x108475A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BCDE")]
    [Address(RVA = "0x848C50", Offset = "0x847A50", VA = "0x10848C50")]
    private void StartEquipEffect()
    {
    }

    [Token(Token = "0x600BCDF")]
    [Address(RVA = "0x848950", Offset = "0x847750", VA = "0x10848950")]
    public void Setup(
      RuneManager manager,
      UnitData unit,
      BindRuneData rune_data,
      RuneManager.RuneEquip rune_equip)
    {
    }

    [Token(Token = "0x600BCE0")]
    [Address(RVA = "0x848350", Offset = "0x847150", VA = "0x10848350")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BCE1")]
    [Address(RVA = "0x8480D0", Offset = "0x846ED0", VA = "0x108480D0")]
    private void RefreshDedicatedButton(bool is_force_disable = false)
    {
    }

    [Token(Token = "0x600BCE2")]
    [Address(RVA = "0x847BD0", Offset = "0x8469D0", VA = "0x10847BD0")]
    public void RefreshButton()
    {
    }

    [Token(Token = "0x600BCE3")]
    [Address(RVA = "0x8481B0", Offset = "0x846FB0", VA = "0x108481B0")]
    public void RefreshNonEquipButton()
    {
    }

    [Token(Token = "0x600BCE4")]
    [Address(RVA = "0x7AB9E0", Offset = "0x7AA7E0", VA = "0x107AB9E0")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600BCE5")]
    [Address(RVA = "0x848DC0", Offset = "0x847BC0", VA = "0x10848DC0")]
    public RuneEquipWindow()
    {
    }
  }
}
