// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestArchivesList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200156C")]
  [FlowNode.Pin(300, "書庫内の開放中のクエスト一覧の取得に失敗した", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(200, "書庫内の開放中のクエスト一覧を取得した", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(50, "書庫内の開放中のクエスト一覧を取得する", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqQuest/ArchivesList", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqQuestArchivesList : FlowNode_Network
  {
    [Token(Token = "0x4004E03")]
    public const int INPUT_REQUEST_GET_QUEST_ARCHIVES_LIST = 50;
    [Token(Token = "0x4004E04")]
    public const int OUTPUT_REQUEST_QUEST_ARCHIVES_LIST_OK = 200;
    [Token(Token = "0x4004E05")]
    public const int OUTPUT_REQUEST_QUEST_ARCHIVES_LIST_FAIL = 300;

    [Token(Token = "0x6005881")]
    [Address(RVA = "0x12D7940", Offset = "0x12D6740", VA = "0x112D7940", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005882")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void Success()
    {
    }

    [Token(Token = "0x6005883")]
    [Address(RVA = "0x12D7470", Offset = "0x12D6270", VA = "0x112D7470")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005884")]
    [Address(RVA = "0x12D7A70", Offset = "0x12D6870", VA = "0x112D7A70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005885")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestArchivesList()
    {
    }

    [Token(Token = "0x200156D")]
    public class ReqQuestArchivesList : WebAPI
    {
      [Token(Token = "0x6005886")]
      [Address(RVA = "0x12DC340", Offset = "0x12DB140", VA = "0x112DC340")]
      public ReqQuestArchivesList(Network.ResponseCallback response)
      {
      }
    }
  }
}
