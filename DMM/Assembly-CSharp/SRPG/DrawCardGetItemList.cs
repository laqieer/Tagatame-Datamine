// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardGetItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022FC")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/DrawCard/DrawCardGetItemList")]
  public class DrawCardGetItemList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009C21")]
    private const int INPUT_PIN_INIT = 1;
    [Token(Token = "0x4009C22")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mItemIconTemplate;

    [Token(Token = "0x6009672")]
    [Address(RVA = "0x5932B0", Offset = "0x5920B0", VA = "0x105932B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009673")]
    [Address(RVA = "0x5932D0", Offset = "0x5920D0", VA = "0x105932D0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6009674")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DrawCardGetItemList()
    {
    }
  }
}
