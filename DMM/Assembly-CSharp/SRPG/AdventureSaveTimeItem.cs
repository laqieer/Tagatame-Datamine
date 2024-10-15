// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureSaveTimeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FAC")]
  [AddComponentMenu("UI/Adventure/AdventureSaveTimeItem")]
  [FlowNode.Pin(101, "アイテム選択完了時", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "MAXボタン選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "確認画面へ", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "CLEARボタン選択", FlowNode.PinTypes.Input, 2)]
  public class AdventureSaveTimeItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008611")]
    private const string KEY_ITEM_AMOUNT = "KEY_ITEM_AMOUNT";
    [Token(Token = "0x4008612")]
    private const int PIN_INPUT_SELECT_MAX_BTN = 1;
    [Token(Token = "0x4008613")]
    private const int PIN_INPUT_SELECT_CLEAR_BTN = 2;
    [Token(Token = "0x4008614")]
    private const int PIN_INPUT_CONRFRM_OPNE = 3;
    [Token(Token = "0x4008615")]
    private const int PIN_OUTPUT_CONNECT_START = 101;
    [Token(Token = "0x4008616")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text AdventureTimeText;
    [Token(Token = "0x4008617")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private AdventureTimeItem TimeItemTempleate;
    [Token(Token = "0x4008618")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text UseItemValueText;
    [Token(Token = "0x4008619")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button DecideBtn;
    [Token(Token = "0x400861A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text ConfirmAdventureTimeText;
    [Token(Token = "0x400861B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ConfirmWindow;
    [Token(Token = "0x400861C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SerializeValueBehaviour ConfirmItemIcon;
    [Token(Token = "0x400861D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text ConfirmUseItemValueText;
    [Token(Token = "0x400861E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SRPG_Button MaxBtn;
    [Token(Token = "0x400861F")]
    [FieldOffset(Offset = "0x30")]
    private AdventureManager mManager;
    [Token(Token = "0x4008620")]
    [FieldOffset(Offset = "0x34")]
    private AdventureData mData;
    [Token(Token = "0x4008621")]
    [FieldOffset(Offset = "0x38")]
    private Coroutine mTimeUpdate;
    [Token(Token = "0x4008622")]
    [FieldOffset(Offset = "0x3C")]
    private List<AdventureSaveTimeItem.UseItemData> mUseItemDatas;
    [Token(Token = "0x4008623")]
    [FieldOffset(Offset = "0x40")]
    private TimeSpan SelectTotalItemDate;
    [Token(Token = "0x4008624")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> ConfirmItemIconList;

    [Token(Token = "0x6008265")]
    [Address(RVA = "0x42FFE0", Offset = "0x42EDE0", VA = "0x1042FFE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008266")]
    [Address(RVA = "0x4307F0", Offset = "0x42F5F0", VA = "0x104307F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008267")]
    [Address(RVA = "0x432170", Offset = "0x430F70", VA = "0x10432170")]
    private void Start()
    {
    }

    [Token(Token = "0x6008268")]
    [Address(RVA = "0x431A10", Offset = "0x430810", VA = "0x10431A10")]
    private IEnumerator RemainTimeUpdate(Text target_text) => (IEnumerator) null;

    [Token(Token = "0x6008269")]
    [Address(RVA = "0x430B20", Offset = "0x42F920", VA = "0x10430B20")]
    private void OnSelectClear()
    {
    }

    [Token(Token = "0x600826A")]
    [Address(RVA = "0x430C80", Offset = "0x42FA80", VA = "0x10430C80")]
    private void OnSelectMax(bool is_ceiling = false)
    {
    }

    [Token(Token = "0x600826B")]
    [Address(RVA = "0x430030", Offset = "0x42EE30", VA = "0x10430030")]
    private void InitSlider()
    {
    }

    [Token(Token = "0x600826C")]
    [Address(RVA = "0x430770", Offset = "0x42F570", VA = "0x10430770")]
    private void OnAddNum(AdventureSaveTimeItem.UseItemData useItemData)
    {
    }

    [Token(Token = "0x600826D")]
    [Address(RVA = "0x430AA0", Offset = "0x42F8A0", VA = "0x10430AA0")]
    private void OnRemoveNum(AdventureSaveTimeItem.UseItemData useItemData)
    {
    }

    [Token(Token = "0x600826E")]
    [Address(RVA = "0x431870", Offset = "0x430670", VA = "0x10431870")]
    public void OnSelectUseNumChanged(AdventureSaveTimeItem.UseItemData useItemData, float value)
    {
    }

    [Token(Token = "0x600826F")]
    [Address(RVA = "0x432720", Offset = "0x431520", VA = "0x10432720")]
    private void UpdateViewAndBtn()
    {
    }

    [Token(Token = "0x6008270")]
    [Address(RVA = "0x431A80", Offset = "0x430880", VA = "0x10431A80")]
    private void SetupConfirm()
    {
    }

    [Token(Token = "0x6008271")]
    [Address(RVA = "0x432C70", Offset = "0x431A70", VA = "0x10432C70")]
    public AdventureSaveTimeItem()
    {
    }

    [Token(Token = "0x2001FAD")]
    public class UseItemData
    {
      [Token(Token = "0x4008625")]
      [FieldOffset(Offset = "0x8")]
      public AdventureTimeItem Content;
      [Token(Token = "0x4008626")]
      [FieldOffset(Offset = "0xC")]
      public ItemData Item;
      [Token(Token = "0x4008627")]
      [FieldOffset(Offset = "0x10")]
      public Slider SliderData;
      [Token(Token = "0x4008628")]
      [FieldOffset(Offset = "0x14")]
      public SRPG_Button PlusBtn;
      [Token(Token = "0x4008629")]
      [FieldOffset(Offset = "0x18")]
      public SRPG_Button MinusBtn;
      [Token(Token = "0x400862A")]
      [FieldOffset(Offset = "0x1C")]
      public Toggle MaxCheckToggle;

      [Token(Token = "0x170012BE")]
      public int SelectNum
      {
        [Token(Token = "0x6008273"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
        [Token(Token = "0x6008274"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
        {
        }
      }

      [Token(Token = "0x170012BF")]
      public TimeSpan TotalSpan
      {
        [Token(Token = "0x6008275"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
        {
          return new TimeSpan();
        }
        [Token(Token = "0x6008276"), Address(RVA = "0x305820", Offset = "0x304620", VA = "0x10305820")] private set
        {
        }
      }

      [Token(Token = "0x170012C0")]
      public TimeSpan ReduceMin
      {
        [Token(Token = "0x6008277"), Address(RVA = "0x445550", Offset = "0x444350", VA = "0x10445550")] get
        {
          return new TimeSpan();
        }
      }

      [Token(Token = "0x6008278")]
      [Address(RVA = "0x445450", Offset = "0x444250", VA = "0x10445450")]
      public void SetUseItemNum(int use_num)
      {
      }

      [Token(Token = "0x6008279")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UseItemData()
      {
      }
    }
  }
}
