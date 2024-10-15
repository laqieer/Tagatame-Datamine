// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PlayNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200145C")]
  [FlowNode.NodeType("System/NewGame/PlayNew", 32741)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Reset to Title", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_PlayNew : FlowNode_Network
  {
    [Token(Token = "0x4004B4E")]
    [FieldOffset(Offset = "0x20")]
    public bool IsDebug;
    [Token(Token = "0x4004B4F")]
    [FieldOffset(Offset = "0x24")]
    public int debugItemHave;
    [Token(Token = "0x4004B50")]
    [FieldOffset(Offset = "0x28")]
    public int debugQuestClear;

    [Token(Token = "0x6005531")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void SetDebug(bool check)
    {
    }

    [Token(Token = "0x6005532")]
    [Address(RVA = "0x1298830", Offset = "0x1297630", VA = "0x11298830", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005533")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005534")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005535")]
    [Address(RVA = "0x1298950", Offset = "0x1297750", VA = "0x11298950", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005536")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PlayNew()
    {
    }

    [Token(Token = "0x200145D")]
    public enum DebugModeItemHaveType
    {
      [Token(Token = "0x4004B52")] NORMAL,
      [Token(Token = "0x4004B53")] DEBUG_ALL,
      [Token(Token = "0x4004B54")] DEBUG_HALF,
    }

    [Token(Token = "0x200145E")]
    public enum DebugModeQuestClearType
    {
      [Token(Token = "0x4004B56")] NORMAL,
      [Token(Token = "0x4004B57")] ALL_CLEAR,
    }

    [Token(Token = "0x200145F")]
    [MessagePackObject(true)]
    public class MP_PlayNew : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004B58")]
      [FieldOffset(Offset = "0x28")]
      public Json_PlayerDataAll body;

      [Token(Token = "0x6005537")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_PlayNew()
      {
      }
    }
  }
}
