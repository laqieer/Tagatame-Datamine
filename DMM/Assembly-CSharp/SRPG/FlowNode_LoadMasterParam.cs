// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LoadMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Threading;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200141D")]
  [FlowNode.Pin(100, "Finished", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Master/LoadMasterParam", 16777215)]
  public class FlowNode_LoadMasterParam : FlowNode
  {
    [Token(Token = "0x4004A6D")]
    [FieldOffset(Offset = "0x18")]
    private Mutex mMutex;
    [Token(Token = "0x4004A6E")]
    [FieldOffset(Offset = "0x1C")]
    private GameManager.LoadMasterDataResult mResult;

    [Token(Token = "0x6005403")]
    [Address(RVA = "0x1287F90", Offset = "0x1286D90", VA = "0x11287F90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005404")]
    [Address(RVA = "0x1288310", Offset = "0x1287110", VA = "0x11288310", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005405")]
    [Address(RVA = "0x1288390", Offset = "0x1287190", VA = "0x11288390")]
    private void Update()
    {
    }

    [Token(Token = "0x6005406")]
    [Address(RVA = "0x1287CC0", Offset = "0x1286AC0", VA = "0x11287CC0")]
    private static void LoadMasterDataThread(object param)
    {
    }

    [Token(Token = "0x6005407")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LoadMasterParam()
    {
    }

    [Token(Token = "0x200141E")]
    private class ThreadStartParam
    {
      [Token(Token = "0x4004A6F")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_LoadMasterParam self;
      [Token(Token = "0x4004A70")]
      [FieldOffset(Offset = "0xC")]
      public GameManager GameManager;
      [Token(Token = "0x4004A71")]
      [FieldOffset(Offset = "0x10")]
      public bool IsUseSerialized;
      [Token(Token = "0x4004A72")]
      [FieldOffset(Offset = "0x11")]
      public bool IsUseEncryption;

      [Token(Token = "0x6005408")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ThreadStartParam()
      {
      }
    }
  }
}
