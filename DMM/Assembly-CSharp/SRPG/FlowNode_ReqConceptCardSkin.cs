// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardSkin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014DE")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "スキン付き真理念装を取得した", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "スキン付き真理念装を取得", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/ReqConceptCardSkin", 32741)]
  public class FlowNode_ReqConceptCardSkin : FlowNode_Network
  {
    [Token(Token = "0x4004C87")]
    private const int PIN_INPUT_CONCEPTCARD_SKIN_GET = 1;
    [Token(Token = "0x4004C88")]
    private const int PIN_OUTPUT_CONCEPTCARD_SKIN_GOT = 101;

    [Token(Token = "0x60056D5")]
    [Address(RVA = "0x12C49E0", Offset = "0x12C37E0", VA = "0x112C49E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056D6")]
    [Address(RVA = "0x12C4AE0", Offset = "0x12C38E0", VA = "0x112C4AE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056D7")]
    [Address(RVA = "0x12C4970", Offset = "0x12C3770", VA = "0x112C4970")]
    private IEnumerator DownloadAssetsAndOutputPin() => (IEnumerator) null;

    [Token(Token = "0x60056D8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardSkin()
    {
    }

    [Token(Token = "0x20014DF")]
    public class Json_ConceptCardSkinList
    {
      [Token(Token = "0x4004C89")]
      [FieldOffset(Offset = "0x8")]
      public string[] cards;

      [Token(Token = "0x60056D9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardSkinList()
      {
      }
    }
  }
}
