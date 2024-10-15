// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDisassemblyResultView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002971")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class RuneDisassemblyResultView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C7C3")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C7C4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400C7C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject templateItem;
    [Token(Token = "0x400C7C6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform parentItem;
    [Token(Token = "0x400C7C7")]
    [FieldOffset(Offset = "0x18")]
    private List<RuneDisassemblyResultModel> _models;
    [Token(Token = "0x400C7C8")]
    [FieldOffset(Offset = "0x1C")]
    private List<ExhibitList> _exhibitList;

    [Token(Token = "0x600BB89")]
    [Address(RVA = "0x834EC0", Offset = "0x833CC0", VA = "0x10834EC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BB8A")]
    [Address(RVA = "0x835380", Offset = "0x834180", VA = "0x10835380")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB8B")]
    [Address(RVA = "0x834EE0", Offset = "0x833CE0", VA = "0x10834EE0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BB8C")]
    [Address(RVA = "0x8352C0", Offset = "0x8340C0", VA = "0x108352C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BB8D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDisassemblyResultView()
    {
    }
  }
}
