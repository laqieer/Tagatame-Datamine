// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAllUnitEquipRuneBulkRelease
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200183D")]
  [FlowNode.NodeType("Rune/Req/AllUnitEquipRuneBulkRelease", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqAllUnitEquipRuneBulkRelease : FlowNode_Network
  {
    [Token(Token = "0x40056EE")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056EF")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40056F0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60061CC")]
    [Address(RVA = "0x135BF50", Offset = "0x135AD50", VA = "0x1135BF50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061CD")]
    [Address(RVA = "0x135C4E0", Offset = "0x135B2E0", VA = "0x1135C4E0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061CE")]
    [Address(RVA = "0x135C120", Offset = "0x135AF20", VA = "0x1135C120", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061CF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAllUnitEquipRuneBulkRelease()
    {
    }

    [Token(Token = "0x200183E")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40056F1")]
      [FieldOffset(Offset = "0x28")]
      public ReqAllUnitRuneBulkRelease.Response body;

      [Token(Token = "0x60061D0")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
