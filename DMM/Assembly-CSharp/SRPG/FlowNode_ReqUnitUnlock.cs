// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015DD")]
  [FlowNode.NodeType("System/Unit/ReqUnitUnlock", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Download Assets", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ReqUnitUnlock : FlowNode_Network
  {
    [Token(Token = "0x4004F69")]
    [FieldOffset(Offset = "0x20")]
    [StringIsResourcePath(typeof (GameObject))]
    public string ResultPrefabPath;
    [Token(Token = "0x4004F6A")]
    [FieldOffset(Offset = "0x24")]
    public string RarityIntName;
    [Token(Token = "0x4004F6B")]
    [FieldOffset(Offset = "0x28")]
    private LoadRequest mReq;
    [Token(Token = "0x4004F6C")]
    [FieldOffset(Offset = "0x2C")]
    private UnitParam mUnlockUnitParam;

    [Token(Token = "0x60059D7")]
    [Address(RVA = "0x12E5420", Offset = "0x12E4220", VA = "0x112E5420", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059D8")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059D9")]
    [Address(RVA = "0x12E55E0", Offset = "0x12E43E0", VA = "0x112E55E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059DA")]
    [Address(RVA = "0x12E5920", Offset = "0x12E4720", VA = "0x112E5920")]
    private IEnumerator WaitDownloadAsync() => (IEnumerator) null;

    [Token(Token = "0x60059DB")]
    [Address(RVA = "0x12E5990", Offset = "0x12E4790", VA = "0x112E5990")]
    public FlowNode_ReqUnitUnlock()
    {
    }
  }
}
