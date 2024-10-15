// Decompiled with JetBrains decompiler
// Type: SRPG.ShopExchangeConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A98")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ShopExchangeConfirmWindow")]
  public class ShopExchangeConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CF96")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400CF97")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text ResultText;
    [Token(Token = "0x400CF98")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemIcon;

    [Token(Token = "0x600C287")]
    [Address(RVA = "0x8AC1A0", Offset = "0x8AAFA0", VA = "0x108AC1A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C288")]
    [Address(RVA = "0x8AC1C0", Offset = "0x8AAFC0", VA = "0x108AC1C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C289")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopExchangeConfirmWindow()
    {
    }
  }
}
