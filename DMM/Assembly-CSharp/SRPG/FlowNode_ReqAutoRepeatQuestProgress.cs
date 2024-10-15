// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012EF")]
  [FlowNode.Pin(110, "進捗取得終了", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "進捗取得開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("AutoRepeatQuest/ReqProgress", 32741)]
  public class FlowNode_ReqAutoRepeatQuestProgress : FlowNode_Network
  {
    [Token(Token = "0x4004675")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool isForceGet;
    [Token(Token = "0x4004676")]
    private const int PIN_INPUT_GET_PROGRESS_START = 10;
    [Token(Token = "0x4004677")]
    private const int PIN_OUTPUT_GET_PROGRESS_END = 110;

    [Token(Token = "0x6005019")]
    [Address(RVA = "0x1252A90", Offset = "0x1251890", VA = "0x11252A90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600501A")]
    [Address(RVA = "0x1252E40", Offset = "0x1251C40", VA = "0x11252E40")]
    private void RequestProgress()
    {
    }

    [Token(Token = "0x600501B")]
    [Address(RVA = "0x1252BC0", Offset = "0x12519C0", VA = "0x11252BC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600501C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestProgress()
    {
    }

    [Token(Token = "0x20012F0")]
    [MessagePackObject(true)]
    public class MP_AutoRepeatQuestProgressResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004678")]
      [FieldOffset(Offset = "0x28")]
      public ReqAutoRepeatQuestProgress.Response body;

      [Token(Token = "0x600501D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_AutoRepeatQuestProgressResponse()
      {
      }
    }
  }
}
