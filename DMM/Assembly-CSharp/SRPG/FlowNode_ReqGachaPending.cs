// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaPending
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
  [Token(Token = "0x20014FA")]
  [FlowNode.NodeType("Gacha/ReqGachaPending", 32741)]
  [FlowNode.Pin(0, "Request(リクエスト)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Request2(リクエスト2)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Success(リクエスト成功)", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failued(リクエスト失敗)", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "NoPending(保留中の引き直し召喚がない)", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGachaPending : FlowNode_Network
  {
    [Token(Token = "0x4004CCD")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004CCE")]
    private const int PIN_IN_REQUEST_FORCE = 1;
    [Token(Token = "0x4004CCF")]
    private const int PIN_OT_SUCCESS = 10;
    [Token(Token = "0x4004CD0")]
    private const int PIN_OT_FAILUED = 11;
    [Token(Token = "0x4004CD1")]
    private const int PIN_OT_NO_PENDING = 12;
    [Token(Token = "0x4004CD2")]
    [FieldOffset(Offset = "0x20")]
    private List<string> DownloadUnits;
    [Token(Token = "0x4004CD3")]
    [FieldOffset(Offset = "0x24")]
    private List<string> DownloadArtifacts;
    [Token(Token = "0x4004CD4")]
    [FieldOffset(Offset = "0x28")]
    private List<string> DownloadConceptCard;

    [Token(Token = "0x6005737")]
    [Address(RVA = "0x12CDCC0", Offset = "0x12CCAC0", VA = "0x112CDCC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005738")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005739")]
    [Address(RVA = "0x127E1B0", Offset = "0x127CFB0", VA = "0x1127E1B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x600573A")]
    [Address(RVA = "0x12CDD60", Offset = "0x12CCB60", VA = "0x112CDD60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600573B")]
    [Address(RVA = "0x12CDC10", Offset = "0x12CCA10", VA = "0x112CDC10")]
    private void ExecGacha(string _gname)
    {
    }

    [Token(Token = "0x600573C")]
    [Address(RVA = "0x12CDBA0", Offset = "0x12CC9A0", VA = "0x112CDBA0")]
    private IEnumerator AsyncGachaResultData(List<GachaDropData> drops) => (IEnumerator) null;

    [Token(Token = "0x600573D")]
    [Address(RVA = "0x12CE360", Offset = "0x12CD160", VA = "0x112CE360")]
    public FlowNode_ReqGachaPending()
    {
    }
  }
}
