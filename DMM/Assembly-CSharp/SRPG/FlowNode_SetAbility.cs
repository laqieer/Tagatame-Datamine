// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200160D")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/Unit/SetAbility", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_SetAbility : FlowNode_Network
  {
    [Token(Token = "0x4004FFA")]
    [FieldOffset(Offset = "0x20")]
    private long mUnitUniqueID;
    [Token(Token = "0x4004FFB")]
    [FieldOffset(Offset = "0x28")]
    private Queue<long> mJobs;
    [Token(Token = "0x4004FFC")]
    [FieldOffset(Offset = "0x2C")]
    private Queue<long> mAbilities;

    [Token(Token = "0x6005AC6")]
    [Address(RVA = "0x12F80D0", Offset = "0x12F6ED0", VA = "0x112F80D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AC7")]
    [Address(RVA = "0x12F8920", Offset = "0x12F7720", VA = "0x112F8920")]
    private void UpdateAbilities()
    {
    }

    [Token(Token = "0x6005AC8")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005AC9")]
    [Address(RVA = "0x12F82E0", Offset = "0x12F70E0", VA = "0x112F82E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005ACA")]
    [Address(RVA = "0x12F86E0", Offset = "0x12F74E0", VA = "0x112F86E0")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x6005ACB")]
    [Address(RVA = "0x12F8420", Offset = "0x12F7220", VA = "0x112F8420")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x6005ACC")]
    [Address(RVA = "0x12F8C20", Offset = "0x12F7A20", VA = "0x112F8C20")]
    public FlowNode_SetAbility()
    {
    }

    [Token(Token = "0x200160E")]
    [MessagePackObject(true)]
    public class MP_JobAbilityt_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004FFD")]
      [FieldOffset(Offset = "0x28")]
      public ReqJobAbility_OverWrite.Response body;

      [Token(Token = "0x6005ACD")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_JobAbilityt_OverWriteResponse()
      {
      }
    }
  }
}
