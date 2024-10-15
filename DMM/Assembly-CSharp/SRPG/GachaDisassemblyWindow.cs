// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDisassemblyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002409")]
  [FlowNode.Pin(1, "Setup", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Gacha/GachaDisassemblyWindow")]
  internal class GachaDisassemblyWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A2EF")]
    private const int PIN_IN_SETUP = 1;
    [Token(Token = "0x400A2F0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private BitmapText CoinText;
    [Token(Token = "0x400A2F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CurrencyBitmapText ZennyText;

    [Token(Token = "0x6009CE0")]
    [Address(RVA = "0x5FFC20", Offset = "0x5FEA20", VA = "0x105FFC20", Slot = "4")]
    public void Activated(int pinId)
    {
    }

    [Token(Token = "0x6009CE1")]
    [Address(RVA = "0x5FFD70", Offset = "0x5FEB70", VA = "0x105FFD70")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009CE2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaDisassemblyWindow()
    {
    }
  }
}
