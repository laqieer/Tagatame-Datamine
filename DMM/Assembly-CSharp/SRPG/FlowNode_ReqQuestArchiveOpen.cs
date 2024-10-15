// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestArchiveOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200156A")]
  [FlowNode.NodeType("System/ReqQuest/ArchiveOpen", 32741)]
  [FlowNode.Pin(50, "クエストを開放する", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(200, "クエストを開放した", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(300, "クエストの開放に失敗した", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ReqQuestArchiveOpen : FlowNode_Network
  {
    [Token(Token = "0x4004E00")]
    public const int INPUT_REQUEST_GET_QUEST_ARCHIVE_OPEN = 50;
    [Token(Token = "0x4004E01")]
    public const int OUTPUT_REQUEST_QUEST_ARCHIVE_OPEN_OK = 200;
    [Token(Token = "0x4004E02")]
    public const int OUTPUT_REQUEST_QUEST_ARCHIVE_OPEN_FAIL = 300;

    [Token(Token = "0x6005879")]
    [Address(RVA = "0x12D74A0", Offset = "0x12D62A0", VA = "0x112D74A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600587A")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void Success()
    {
    }

    [Token(Token = "0x600587B")]
    [Address(RVA = "0x12D7470", Offset = "0x12D6270", VA = "0x112D7470")]
    private void Failure()
    {
    }

    [Token(Token = "0x600587C")]
    [Address(RVA = "0x12D7620", Offset = "0x12D6420", VA = "0x112D7620", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600587D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestArchiveOpen()
    {
    }

    [Token(Token = "0x200156B")]
    public class ReqQuestArchiveOpen : WebAPI
    {
      [Token(Token = "0x6005880")]
      [Address(RVA = "0x12DC260", Offset = "0x12DB060", VA = "0x112DC260")]
      public ReqQuestArchiveOpen(Network.ResponseCallback response)
      {
      }
    }
  }
}
