// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckGachaData
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
  [Token(Token = "0x200137E")]
  [FlowNode.NodeType("System/Check/CheckGachaData", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(99, "エラー発生", FlowNode.PinTypes.Output, 99)]
  [FlowNode.Pin(10, "ダウンロード開始", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "確認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "ダウンロード完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "キャンセル", FlowNode.PinTypes.Output, 12)]
  public class FlowNode_CheckGachaData : FlowNode
  {
    [Token(Token = "0x40047EF")]
    public const int PINID_IN = 0;
    [Token(Token = "0x40047F0")]
    [FieldOffset(Offset = "0x18")]
    public List<string> DownloadUnits;
    [Token(Token = "0x40047F1")]
    [FieldOffset(Offset = "0x1C")]
    public List<ArtifactParam> DownloadArtifacts;
    [Token(Token = "0x40047F2")]
    [FieldOffset(Offset = "0x20")]
    private List<AssetList.Item> mQueue;

    [Token(Token = "0x60051C0")]
    [Address(RVA = "0x126B780", Offset = "0x126A580", VA = "0x1126B780", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051C1")]
    [Address(RVA = "0x126B710", Offset = "0x126A510", VA = "0x1126B710")]
    private IEnumerator AsyncWork(bool confirm) => (IEnumerator) null;

    [Token(Token = "0x60051C2")]
    [Address(RVA = "0x126BC00", Offset = "0x126AA00", VA = "0x1126BC00")]
    public FlowNode_CheckGachaData()
    {
    }
  }
}
