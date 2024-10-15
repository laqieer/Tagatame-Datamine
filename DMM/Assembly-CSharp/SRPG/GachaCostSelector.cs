// Decompiled with JetBrains decompiler
// Type: SRPG.GachaCostSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002406")]
  [FlowNode.Pin(10, "+を選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "+Nを選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "-を選択", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(13, "-Nを選択", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(14, "MAXを選択", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(15, "N値変更", FlowNode.PinTypes.Input, 15)]
  [AddComponentMenu("UI/Gacha/GachaCostSelector")]
  public class GachaCostSelector : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A2CA")]
    private const int PIN_IN_CLICK_ADD = 10;
    [Token(Token = "0x400A2CB")]
    private const int PIN_IN_CLICK_ADD_EX = 11;
    [Token(Token = "0x400A2CC")]
    private const int PIN_IN_CLICK_SUB = 12;
    [Token(Token = "0x400A2CD")]
    private const int PIN_IN_CLICK_SUB_EX = 13;
    [Token(Token = "0x400A2CE")]
    private const int PIN_IN_CLICK_MAX = 14;
    [Token(Token = "0x400A2CF")]
    private const int PIN_IN_CLICK_CHANGE_VALUE = 15;
    [Token(Token = "0x400A2D0")]
    private const int SLIDER_SINGLE_VALUE = 1;
    [Token(Token = "0x400A2D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly int[] MULTI_VALUE_LIST;
    [Token(Token = "0x400A2D2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400A2D3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private BitmapText SelectValueText;
    [Token(Token = "0x400A2D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BitmapText ConsumeNumText;
    [Token(Token = "0x400A2D5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject CostInfoObj;
    [Token(Token = "0x400A2D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Slider CostSelectSlider;
    [Token(Token = "0x400A2D7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button AddButton;
    [Token(Token = "0x400A2D8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button SubButton;
    [Token(Token = "0x400A2D9")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button AddExButton;
    [Token(Token = "0x400A2DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text AddExText;
    [Token(Token = "0x400A2DB")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button SubExButton;
    [Token(Token = "0x400A2DC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button MaxButton;
    [Token(Token = "0x400A2DD")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text CostIndexText;
    [Token(Token = "0x400A2DE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text ConfirmText;
    [Token(Token = "0x400A2DF")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text CautionText;
    [Token(Token = "0x400A2E0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject SelectInfoObj;
    [Token(Token = "0x400A2E1")]
    [FieldOffset(Offset = "0x4C")]
    public GachaCostSelector.OnSelectValueUpdate SelectValueUpdate;
    [Token(Token = "0x400A2E2")]
    [FieldOffset(Offset = "0x50")]
    private GachaCostSelectorData mGachaCostSelectorData;
    [Token(Token = "0x400A2E3")]
    [FieldOffset(Offset = "0x54")]
    private int slider_multi_value;
    [Token(Token = "0x400A2E4")]
    [FieldOffset(Offset = "0x58")]
    private int multi_value_index;

    [Token(Token = "0x6009CB8")]
    [Address(RVA = "0x5FE5E0", Offset = "0x5FD3E0", VA = "0x105FE5E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009CB9")]
    [Address(RVA = "0x5FF6C0", Offset = "0x5FE4C0", VA = "0x105FF6C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009CBA")]
    [Address(RVA = "0x5FEA40", Offset = "0x5FD840", VA = "0x105FEA40")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6009CBB")]
    [Address(RVA = "0x5FE890", Offset = "0x5FD690", VA = "0x105FE890")]
    private GachaCostSelectorData InitalizeBoxGacha() => (GachaCostSelectorData) null;

    [Token(Token = "0x6009CBC")]
    [Address(RVA = "0x5FE7E0", Offset = "0x5FD5E0", VA = "0x105FE7E0")]
    private GachaCostSelectorData CreateDataForBoxGachaStatus() => (GachaCostSelectorData) null;

    [Token(Token = "0x6009CBD")]
    [Address(RVA = "0x5FF6D0", Offset = "0x5FE4D0", VA = "0x105FF6D0")]
    private void UpdateBoxGachaStatus()
    {
    }

    [Token(Token = "0x6009CBE")]
    [Address(RVA = "0x5FF090", Offset = "0x5FDE90", VA = "0x105FF090")]
    private void Refresh(GachaCostSelectorData cost_data)
    {
    }

    [Token(Token = "0x6009CBF")]
    [Address(RVA = "0x5FF810", Offset = "0x5FE610", VA = "0x105FF810")]
    private void UpdateButtonInteractable()
    {
    }

    [Token(Token = "0x6009CC0")]
    [Address(RVA = "0x5FEBE0", Offset = "0x5FD9E0", VA = "0x105FEBE0")]
    private void OnAddDefault()
    {
    }

    [Token(Token = "0x6009CC1")]
    [Address(RVA = "0x5FEC00", Offset = "0x5FDA00", VA = "0x105FEC00")]
    private void OnAddExtra()
    {
    }

    [Token(Token = "0x6009CC2")]
    [Address(RVA = "0x5FEC20", Offset = "0x5FDA20", VA = "0x105FEC20")]
    private void OnAdd(int value)
    {
    }

    [Token(Token = "0x6009CC3")]
    [Address(RVA = "0x5FED40", Offset = "0x5FDB40", VA = "0x105FED40")]
    private void OnSubDefault()
    {
    }

    [Token(Token = "0x6009CC4")]
    [Address(RVA = "0x5FED60", Offset = "0x5FDB60", VA = "0x105FED60")]
    private void OnSubExtra()
    {
    }

    [Token(Token = "0x6009CC5")]
    [Address(RVA = "0x5FED80", Offset = "0x5FDB80", VA = "0x105FED80")]
    private void OnSub(int value)
    {
    }

    [Token(Token = "0x6009CC6")]
    [Address(RVA = "0x5FECC0", Offset = "0x5FDAC0", VA = "0x105FECC0")]
    private void OnMax()
    {
    }

    [Token(Token = "0x6009CC7")]
    [Address(RVA = "0x5FEE40", Offset = "0x5FDC40", VA = "0x105FEE40")]
    private void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x6009CC8")]
    [Address(RVA = "0x5FF680", Offset = "0x5FE480", VA = "0x105FF680")]
    private void SetMultiValue()
    {
    }

    [Token(Token = "0x6009CC9")]
    [Address(RVA = "0x5FF5E0", Offset = "0x5FE3E0", VA = "0x105FF5E0")]
    private void SetMultiText()
    {
    }

    [Token(Token = "0x6009CCA")]
    [Address(RVA = "0x5FE7B0", Offset = "0x5FD5B0", VA = "0x105FE7B0")]
    private void AddValueIndex()
    {
    }

    [Token(Token = "0x6009CCB")]
    [Address(RVA = "0x5FF510", Offset = "0x5FE310", VA = "0x105FF510")]
    private void SetIsMax(bool isValue)
    {
    }

    [Token(Token = "0x6009CCC")]
    [Address(RVA = "0x5FFBA0", Offset = "0x5FE9A0", VA = "0x105FFBA0")]
    public GachaCostSelector()
    {
    }

    [Token(Token = "0x2002407")]
    public delegate void OnSelectValueUpdate();
  }
}
