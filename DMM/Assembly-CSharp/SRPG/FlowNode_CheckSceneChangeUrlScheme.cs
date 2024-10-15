// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckSceneChangeUrlScheme
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001386")]
  [FlowNode.Pin(100, "CheckFinished", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "MovieEndEvent", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "CheckStart", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Scene/CheckSceneChangeUrlScheme", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_CheckSceneChangeUrlScheme : FlowNodePersistent
  {
    [Token(Token = "0x400480B")]
    [FieldOffset(Offset = "0x18")]
    private FlowNode_CheckSceneChangeUrlScheme.CheckFlag m_checkFlag;
    [Token(Token = "0x400480C")]
    [FieldOffset(Offset = "0x1C")]
    private bool startCheck;

    [Token(Token = "0x60051E1")]
    [Address(RVA = "0x7E3D80", Offset = "0x7E2B80", VA = "0x107E3D80")]
    private void Start()
    {
    }

    [Token(Token = "0x60051E2")]
    [Address(RVA = "0x126C730", Offset = "0x126B530", VA = "0x1126C730", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051E3")]
    [Address(RVA = "0x126C7E0", Offset = "0x126B5E0", VA = "0x1126C7E0")]
    private void Update()
    {
    }

    [Token(Token = "0x60051E4")]
    [Address(RVA = "0x126C6E0", Offset = "0x126B4E0", VA = "0x1126C6E0")]
    private void Finished()
    {
    }

    [Token(Token = "0x60051E5")]
    [Address(RVA = "0x126C750", Offset = "0x126B550", VA = "0x1126C750")]
    private void PushMovieEndEvent()
    {
    }

    [Token(Token = "0x60051E6")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckSceneChangeUrlScheme()
    {
    }

    [Token(Token = "0x2001387")]
    private enum CheckFlag
    {
      [Token(Token = "0x400480E")] StartEndMovie = 1,
      [Token(Token = "0x400480F")] FinishEndMovie = 2,
      [Token(Token = "0x4004810")] FinishedCheck = 1024, // 0x00000400
    }
  }
}
