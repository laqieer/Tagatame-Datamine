// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceEffectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200294A")]
  [FlowNode.Pin(100, "共鳴再生", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "解除再生", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Resonance/ResonanceEffectView")]
  public class ResonanceEffectView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C6ED")]
    private const int PIN_OUT_RESONANCE_PLAY = 100;
    [Token(Token = "0x400C6EE")]
    private const int PIN_OUT_RESET_PLAY = 101;
    [Token(Token = "0x400C6EF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList baseUnitExhibit;
    [Token(Token = "0x400C6F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList resonanceUnitExhibit;
    [Token(Token = "0x400C6F1")]
    [FieldOffset(Offset = "0x14")]
    private UnitData unitData;
    [Token(Token = "0x400C6F2")]
    [FieldOffset(Offset = "0x18")]
    private UnitData resonanceUnitData;

    [Token(Token = "0x600BAC1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAC2")]
    [Address(RVA = "0x822FF0", Offset = "0x821DF0", VA = "0x10822FF0")]
    public void Setup(long parentUniqueID, long childUniqueID, bool isResonance)
    {
    }

    [Token(Token = "0x600BAC3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ResonanceEffectView()
    {
    }
  }
}
