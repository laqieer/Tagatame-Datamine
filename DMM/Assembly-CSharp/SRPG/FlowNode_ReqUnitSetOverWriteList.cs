// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitSetOverWriteList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015DA")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("FlowNode_ReqUnitSetOverWriteList", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqUnitSetOverWriteList : FlowNode_Network
  {
    [Token(Token = "0x4004F63")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004F64")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4004F65")]
    public const string KEY_UNIT_SETOVERWRITE_LIST_UNITS = "KEY_UNIT_SETOVERWRITE_LIST_UNITS";
    [Token(Token = "0x4004F66")]
    public const string KEY_UNIT_SETOVERWRITE_LIST_OVERWRITE_PTYPE = "KEY_UNIT_SETOVERWRITE_LIST_OVERWRITE_PTYPE";

    [Token(Token = "0x60059CD")]
    [Address(RVA = "0x12E4530", Offset = "0x12E3330", VA = "0x112E4530", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60059CE")]
    [Address(RVA = "0x12E53B0", Offset = "0x12E41B0", VA = "0x112E53B0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059CF")]
    [Address(RVA = "0x12E5090", Offset = "0x12E3E90", VA = "0x112E5090", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059D0")]
    [Address(RVA = "0x12E4020", Offset = "0x12E2E20", VA = "0x112E4020")]
    private Dictionary<long, ReqOverWriteSetList.RequestSetUnitList> AllOverWriteSetList(
      UnitData[] units,
      Dictionary<long, ReqOverWriteSetList.RequestSetUnitList> set_list)
    {
      return (Dictionary<long, ReqOverWriteSetList.RequestSetUnitList>) null;
    }

    [Token(Token = "0x60059D1")]
    [Address(RVA = "0x12E3B30", Offset = "0x12E2930", VA = "0x112E3B30")]
    private Dictionary<long, ReqOverWriteSetList.RequestSetUnitBaseList> AllOverWriteSetList(
      UnitData[] units,
      Dictionary<long, ReqOverWriteSetList.RequestSetUnitBaseList> set_list)
    {
      return (Dictionary<long, ReqOverWriteSetList.RequestSetUnitBaseList>) null;
    }

    [Token(Token = "0x60059D2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitSetOverWriteList()
    {
    }
  }
}
