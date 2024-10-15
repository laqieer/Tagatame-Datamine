// Decompiled with JetBrains decompiler
// Type: SRPG.DuelBonusUnitWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002308")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Duel/DuelBonusUnitWindow")]
  public class DuelBonusUnitWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009C55")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009C56")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private DuelBonusUnitContent mBonusUnitTemplate;

    [Token(Token = "0x60096C8")]
    [Address(RVA = "0x597400", Offset = "0x596200", VA = "0x10597400", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60096C9")]
    [Address(RVA = "0x597420", Offset = "0x596220", VA = "0x10597420")]
    private void Init()
    {
    }

    [Token(Token = "0x60096CA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelBonusUnitWindow()
    {
    }
  }
}
