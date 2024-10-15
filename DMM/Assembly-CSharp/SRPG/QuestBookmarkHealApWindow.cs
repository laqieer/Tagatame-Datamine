// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkHealApWindow
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
  [Token(Token = "0x20020E4")]
  [AddComponentMenu("UI/Bookmark/QuestBookmarkHealApWindow")]
  [FlowNode.Pin(201, "予期せぬエラー検知", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(2, "一括スキップ", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "アイテムを使用せずに一括スキップ", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "実行", FlowNode.PinTypes.Output, 101)]
  public class QuestBookmarkHealApWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008E1C")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008E1D")]
    private const int PIN_INPUT_BULK_SKIP = 2;
    [Token(Token = "0x4008E1E")]
    private const int PIN_INPUT_ITEM_NOT_USE_BULK_SKIP = 3;
    [Token(Token = "0x4008E1F")]
    private const int PIN_OUTPUT_BULK_SKIP_EXE = 101;
    [Token(Token = "0x4008E20")]
    private const int PIN_OUTPUT_ERROR = 201;
    [Token(Token = "0x4008E21")]
    private const string SVB_NAME_SLIDER = "slider";
    [Token(Token = "0x4008E22")]
    private const string SVB_NAME_BTN_PLUS = "btn_plus";
    [Token(Token = "0x4008E23")]
    private const string SVB_NAME_BTN_MINUS = "btn_minus";
    [Token(Token = "0x4008E24")]
    private const string SVB_NAME_TXT_AP = "ap_text";
    [Token(Token = "0x4008E25")]
    private const string SVB_NAME_TXT_USE_NUM = "user_num_text";
    [Token(Token = "0x4008E26")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mNeedApText;
    [Token(Token = "0x4008E27")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x4008E28")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour mTemplete;
    [Token(Token = "0x4008E29")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mBtnBulkQuestSkip;
    [Token(Token = "0x4008E2A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button mBtnItemNotUseSkip;
    [Token(Token = "0x4008E2B")]
    [FieldOffset(Offset = "0x20")]
    private PlayerData mPlayer;
    [Token(Token = "0x4008E2C")]
    [FieldOffset(Offset = "0x24")]
    private int mNeedApNum;
    [Token(Token = "0x4008E2D")]
    [FieldOffset(Offset = "0x28")]
    private List<QuestBookmarkHealApWindow.BulkApData> mBulkApDataList;

    [Token(Token = "0x6008949")]
    [Address(RVA = "0x4B3320", Offset = "0x4B2120", VA = "0x104B3320")]
    private void Awake()
    {
    }

    [Token(Token = "0x600894A")]
    [Address(RVA = "0x4B31A0", Offset = "0x4B1FA0", VA = "0x104B31A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600894B")]
    [Address(RVA = "0x4B37C0", Offset = "0x4B25C0", VA = "0x104B37C0")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600894C")]
    [Address(RVA = "0x4B3CF0", Offset = "0x4B2AF0", VA = "0x104B3CF0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600894D")]
    [Address(RVA = "0x4B3370", Offset = "0x4B2170", VA = "0x104B3370")]
    private void ExecuteBulkSkip()
    {
    }

    [Token(Token = "0x600894E")]
    [Address(RVA = "0x4B3600", Offset = "0x4B2400", VA = "0x104B3600")]
    private int GetApTotal(string exclusion_item_id = null) => new int();

    [Token(Token = "0x600894F")]
    [Address(RVA = "0x4B46E0", Offset = "0x4B34E0", VA = "0x104B46E0")]
    private void SetNeedApText()
    {
    }

    [Token(Token = "0x6008950")]
    [Address(RVA = "0x4B40A0", Offset = "0x4B2EA0", VA = "0x104B40A0")]
    private void SetBtnInteractable()
    {
    }

    [Token(Token = "0x6008951")]
    [Address(RVA = "0x4B42A0", Offset = "0x4B30A0", VA = "0x104B42A0")]
    private void SetListData(QuestBookmarkHealApWindow.BulkApData bulkApData, string[] max_checks)
    {
    }

    [Token(Token = "0x6008952")]
    [Address(RVA = "0x4B3A50", Offset = "0x4B2850", VA = "0x104B3A50")]
    private void OnSelectUseNumChanged(QuestBookmarkHealApWindow.BulkApData bulkApData, float value)
    {
    }

    [Token(Token = "0x6008953")]
    [Address(RVA = "0x4B3950", Offset = "0x4B2750", VA = "0x104B3950")]
    private void OnAddNum(QuestBookmarkHealApWindow.BulkApData bulkApData)
    {
    }

    [Token(Token = "0x6008954")]
    [Address(RVA = "0x4B39D0", Offset = "0x4B27D0", VA = "0x104B39D0")]
    private void OnRemoveNum(QuestBookmarkHealApWindow.BulkApData bulkApData)
    {
    }

    [Token(Token = "0x6008955")]
    [Address(RVA = "0x4B4770", Offset = "0x4B3570", VA = "0x104B4770")]
    public QuestBookmarkHealApWindow()
    {
    }

    [Token(Token = "0x20020E5")]
    private class BulkApData
    {
      [Token(Token = "0x1700135F")]
      public ItemData mItem
      {
        [Token(Token = "0x6008956"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ItemData) null;
        }
        [Token(Token = "0x6008957"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x17001360")]
      public Slider mSlider
      {
        [Token(Token = "0x6008958"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (Slider) null;
        }
        [Token(Token = "0x6008959"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x17001361")]
      public Button mPlusBtn
      {
        [Token(Token = "0x600895A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x600895B"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x17001362")]
      public Button mMinusBtn
      {
        [Token(Token = "0x600895C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x600895D"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
        {
        }
      }

      [Token(Token = "0x17001363")]
      public Text mApTxt
      {
        [Token(Token = "0x600895E"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600895F"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
        {
        }
      }

      [Token(Token = "0x17001364")]
      public Text mUseNumTxt
      {
        [Token(Token = "0x6008960"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x6008961"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
        {
        }
      }

      [Token(Token = "0x17001365")]
      public int mUseNum
      {
        [Token(Token = "0x6008962"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
        [Token(Token = "0x6008963"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
        {
        }
      }

      [Token(Token = "0x6008964")]
      [Address(RVA = "0x4AA450", Offset = "0x4A9250", VA = "0x104AA450")]
      public BulkApData(SerializeValueBehaviour svb, ItemData item)
      {
      }

      [Token(Token = "0x6008965")]
      [Address(RVA = "0x4AA320", Offset = "0x4A9120", VA = "0x104AA320")]
      public void SetUseItemNum(int use_num, int need_ap_num)
      {
      }

      [Token(Token = "0x6008966")]
      [Address(RVA = "0x4AA2F0", Offset = "0x4A90F0", VA = "0x104AA2F0")]
      public int GetItemApTotal() => new int();
    }
  }
}
