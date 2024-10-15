// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardGetUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A0")]
  [FlowNode.Pin(10, "終了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "開始", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("ConceptCard/ConceptCardGetUnit")]
  public class FlowNode_ConceptCardGetUnit : FlowNode
  {
    [Token(Token = "0x4004872")]
    [FieldOffset(Offset = "0x0")]
    private static List<ConceptCardData> s_ConceptCards;

    [Token(Token = "0x6005233")]
    [Address(RVA = "0x126F0F0", Offset = "0x126DEF0", VA = "0x1126F0F0")]
    public static void AddConceptCardData(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x6005234")]
    [Address(RVA = "0x126F320", Offset = "0x126E120", VA = "0x1126F320")]
    private IEnumerator StartEffects() => (IEnumerator) null;

    [Token(Token = "0x6005235")]
    [Address(RVA = "0x126F160", Offset = "0x126DF60", VA = "0x1126F160")]
    private IEnumerator DownloadRoutine() => (IEnumerator) null;

    [Token(Token = "0x6005236")]
    [Address(RVA = "0x126F1B0", Offset = "0x126DFB0", VA = "0x1126F1B0")]
    private IEnumerator EffectRoutine(ConceptCardData conceptCardData) => (IEnumerator) null;

    [Token(Token = "0x6005237")]
    [Address(RVA = "0x126F220", Offset = "0x126E020", VA = "0x1126F220", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005238")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardGetUnit()
    {
    }

    [Token(Token = "0x6005239")]
    [Address(RVA = "0x126F390", Offset = "0x126E190", VA = "0x1126F390")]
    static FlowNode_ConceptCardGetUnit()
    {
    }
  }
}
