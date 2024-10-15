// Decompiled with JetBrains decompiler
// Type: SRPG.ProductPremium
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002854")]
  [FlowNode.Pin(0, "表示", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("Payment/ProductPremium")]
  [FlowNode.Pin(100, "選択された", FlowNode.PinTypes.Output, 0)]
  public class ProductPremium : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C083")]
    [FieldOffset(Offset = "0xC")]
    [Description("ボタンとして使用するゲームオブジェクト")]
    public Button PremiumButton;

    [Token(Token = "0x600B60A")]
    [Address(RVA = "0x7C7ED0", Offset = "0x7C6CD0", VA = "0x107C7ED0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B60B")]
    [Address(RVA = "0x7C7EF0", Offset = "0x7C6CF0", VA = "0x107C7EF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B60C")]
    [Address(RVA = "0x7C8380", Offset = "0x7C7180", VA = "0x107C8380")]
    private void Start()
    {
    }

    [Token(Token = "0x600B60D")]
    [Address(RVA = "0x7C80E0", Offset = "0x7C6EE0", VA = "0x107C80E0")]
    private void RefreshItems(bool is_start)
    {
    }

    [Token(Token = "0x600B60E")]
    [Address(RVA = "0x7C7FB0", Offset = "0x7C6DB0", VA = "0x107C7FB0")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600B60F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B610")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ProductPremium()
    {
    }
  }
}
