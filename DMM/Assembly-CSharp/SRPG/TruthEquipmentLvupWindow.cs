// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentLvupWindow
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
  [Token(Token = "0x2002B8F")]
  [FlowNode.Pin(101, "更新完了（強化不能）", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/TruthEquipment/TruthEquipmentLvupWindow")]
  [FlowNode.Pin(100, "更新完了（強化可能）", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(50, "強化実行", FlowNode.PinTypes.Input, 50)]
  public class TruthEquipmentLvupWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D5BD")]
    public const int PIN_IN_ENHANCE_BUTTON_CLICKED = 50;
    [Token(Token = "0x400D5BE")]
    public const int PIN_OUT_CAN_LV_UP = 100;
    [Token(Token = "0x400D5BF")]
    public const int PIN_OUT_CAN_NOT_LV_UP = 101;
    [Token(Token = "0x400D5C0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform m_ListItemParent;
    [Token(Token = "0x400D5C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_ListItemTemplate;
    [Token(Token = "0x400D5C2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_Zenny;
    [Token(Token = "0x400D5C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_CautionZenny;
    [Token(Token = "0x400D5C4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_CautionItem;
    [Token(Token = "0x400D5C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button m_LvupButton;
    [Token(Token = "0x400D5C6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject m_NeedZennyObj;
    [Token(Token = "0x400D5C7")]
    [FieldOffset(Offset = "0x28")]
    public TruthEquipmentLvupWindow.CallbackEvent OnCallback;
    [Token(Token = "0x400D5C8")]
    [FieldOffset(Offset = "0x2C")]
    protected UnitData m_CurrentUnit;
    [Token(Token = "0x400D5C9")]
    [FieldOffset(Offset = "0x30")]
    protected TruthEquipmentData m_CurrentTruthEquipmentData;
    [Token(Token = "0x400D5CA")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> m_ListItems;
    [Token(Token = "0x400D5CB")]
    [FieldOffset(Offset = "0x38")]
    protected TruthEquipmentLvupWindow.eVerifyCanLvupResult m_VerifyCanLvupResult;

    [Token(Token = "0x600C7F8")]
    [Address(RVA = "0x90EF10", Offset = "0x90DD10", VA = "0x1090EF10", Slot = "5")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x600C7F9")]
    [Address(RVA = "0x90E9B0", Offset = "0x90D7B0", VA = "0x1090E9B0")]
    public void Initialize(UnitData unit)
    {
    }

    [Token(Token = "0x600C7FA")]
    [Address(RVA = "0x90E580", Offset = "0x90D380", VA = "0x1090E580", Slot = "6")]
    public virtual void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C7FB")]
    [Address(RVA = "0x90EB00", Offset = "0x90D900", VA = "0x1090EB00")]
    protected void Refresh(int _add_level = 1)
    {
    }

    [Token(Token = "0x600C7FC")]
    [Address(RVA = "0x90EA80", Offset = "0x90D880", VA = "0x1090EA80")]
    private void RefreshLvupButtonInteractable()
    {
    }

    [Token(Token = "0x600C7FD")]
    [Address(RVA = "0x90E9F0", Offset = "0x90D7F0", VA = "0x1090E9F0", Slot = "7")]
    protected virtual void RefreshCautionEnable()
    {
    }

    [Token(Token = "0x600C7FE")]
    [Address(RVA = "0x90E750", Offset = "0x90D550", VA = "0x1090E750")]
    private void CreateListItems(Dictionary<string, int> items)
    {
    }

    [Token(Token = "0x600C7FF")]
    [Address(RVA = "0x90E5B0", Offset = "0x90D3B0", VA = "0x1090E5B0")]
    private void CreateListItem(ItemParam item, int itemNum)
    {
    }

    [Token(Token = "0x600C800")]
    [Address(RVA = "0x90E8D0", Offset = "0x90D6D0", VA = "0x1090E8D0")]
    protected void DestroyListItems()
    {
    }

    [Token(Token = "0x600C801")]
    [Address(RVA = "0x90EF70", Offset = "0x90DD70", VA = "0x1090EF70")]
    private void VerifyCanLvup(int _add_level)
    {
    }

    [Token(Token = "0x600C802")]
    [Address(RVA = "0x90E510", Offset = "0x90D310", VA = "0x1090E510")]
    public TruthEquipmentLvupWindow()
    {
    }

    [Token(Token = "0x2002B90")]
    public delegate void CallbackEvent(int _add_level);

    [Token(Token = "0x2002B91")]
    protected enum eVerifyCanLvupResult
    {
      [Token(Token = "0x400D5CD")] OK,
      [Token(Token = "0x400D5CE")] NotEnoughZenny,
      [Token(Token = "0x400D5CF")] NotEnoughItem,
      [Token(Token = "0x400D5D0")] OtherError,
    }

    [Token(Token = "0x2002B92")]
    public class CostData
    {
      [Token(Token = "0x400D5D1")]
      [FieldOffset(Offset = "0x8")]
      public long m_NeedNum;
      [Token(Token = "0x400D5D2")]
      [FieldOffset(Offset = "0x10")]
      public long m_HaveNum;

      [Token(Token = "0x17001A85")]
      public bool HaveEnougthItems
      {
        [Token(Token = "0x600C807"), Address(RVA = "0x90BDC0", Offset = "0x90ABC0", VA = "0x1090BDC0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C808")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CostData()
      {
      }
    }
  }
}
