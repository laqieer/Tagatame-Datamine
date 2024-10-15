// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneEquip
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
  [Token(Token = "0x2001847")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Rune/Req/Equip", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqRuneEquip : FlowNode_Network
  {
    [Token(Token = "0x400571E")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400571F")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005720")]
    [FieldOffset(Offset = "0x0")]
    private static UnitData mTargetUnit;
    [Token(Token = "0x4005721")]
    [FieldOffset(Offset = "0x4")]
    private static List<BindRuneData> mTargetList;
    [Token(Token = "0x4005722")]
    [FieldOffset(Offset = "0x8")]
    private static BindRuneData[] mTargetEquipRune;

    [Token(Token = "0x60061FA")]
    [Address(RVA = "0x1367E80", Offset = "0x1366C80", VA = "0x11367E80")]
    public static void SetEquip(BindRuneData rune_data, List<BindRuneData> list, UnitData unit)
    {
    }

    [Token(Token = "0x60061FB")]
    [Address(RVA = "0x1368100", Offset = "0x1366F00", VA = "0x11368100")]
    public static void SetUnequip(BindRuneData rune_data, List<BindRuneData> list, UnitData unit)
    {
    }

    [Token(Token = "0x60061FC")]
    [Address(RVA = "0x1367FD0", Offset = "0x1366DD0", VA = "0x11367FD0")]
    public static void SetUnequipAll(List<BindRuneData> list, UnitData unit)
    {
    }

    [Token(Token = "0x60061FD")]
    [Address(RVA = "0x1367570", Offset = "0x1366370", VA = "0x11367570")]
    public static void Clear()
    {
    }

    [Token(Token = "0x60061FE")]
    [Address(RVA = "0x1367670", Offset = "0x1366470", VA = "0x11367670")]
    private static void CloneUnitsCurrentEquipment()
    {
    }

    [Token(Token = "0x60061FF")]
    [Address(RVA = "0x1367890", Offset = "0x1366690", VA = "0x11367890")]
    public ReqRuneEquip.RequestParam CreateReqRuneEquip() => (ReqRuneEquip.RequestParam) null;

    [Token(Token = "0x6006200")]
    [Address(RVA = "0x1367A80", Offset = "0x1366880", VA = "0x11367A80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006201")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006202")]
    [Address(RVA = "0x1367DC0", Offset = "0x1366BC0", VA = "0x11367DC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006203")]
    [Address(RVA = "0x1368560", Offset = "0x1367360", VA = "0x11368560")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x6006204")]
    [Address(RVA = "0x1368200", Offset = "0x1367000", VA = "0x11368200")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x6006205")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneEquip()
    {
    }

    [Token(Token = "0x6006206")]
    [Address(RVA = "0x13688A0", Offset = "0x13676A0", VA = "0x113688A0")]
    static FlowNode_ReqRuneEquip()
    {
    }

    [Token(Token = "0x2001848")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005723")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneEquip.Response body;

      [Token(Token = "0x6006207")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }

    [Token(Token = "0x2001849")]
    [MessagePackObject(true)]
    public class MP_Response_OverWrite : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005724")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneEquip_OverWrite.Response body;

      [Token(Token = "0x6006208")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_OverWrite()
      {
      }
    }
  }
}
