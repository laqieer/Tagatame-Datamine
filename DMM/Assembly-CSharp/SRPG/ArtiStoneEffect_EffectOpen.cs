// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_EffectOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF0")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  public class ArtiStoneEffect_EffectOpen : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087CB")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x40087CC")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x40087CD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x40087CE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40087CF")]
    [FieldOffset(Offset = "0x14")]
    private ArtifactStoneEffectModel mModel;

    [Token(Token = "0x60083D3")]
    [Address(RVA = "0x4467B0", Offset = "0x4455B0", VA = "0x104467B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083D4")]
    [Address(RVA = "0x4467D0", Offset = "0x4455D0", VA = "0x104467D0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60083D5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_EffectOpen()
    {
    }
  }
}
