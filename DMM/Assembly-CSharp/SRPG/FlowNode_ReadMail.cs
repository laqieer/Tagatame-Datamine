// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReadMail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001470")]
  [FlowNode.Pin(22, "いくつか受け取れなかった", FlowNode.PinTypes.Output, 22)]
  [AddComponentMenu("")]
  [FlowNode.Pin(23, "何も受け取れなかった", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(21, "全件受け取り完了", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "全件既読", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "一件既読", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("Mail/ReadMail", 32741)]
  [FlowNode.Pin(20, "一件受け取り完了", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_ReadMail : FlowNode_Network
  {
    [Token(Token = "0x4004B95")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReadMail.RecieveStatus mRecieveStatus;
    [Token(Token = "0x4004B96")]
    [FieldOffset(Offset = "0x24")]
    private Dictionary<GiftTypes, int> currentNums;

    [Token(Token = "0x600556C")]
    [Address(RVA = "0x129DB70", Offset = "0x129C970", VA = "0x1129DB70")]
    private int CalcConvertedGold(MailData mail) => new int();

    [Token(Token = "0x600556D")]
    [Address(RVA = "0x129E680", Offset = "0x129D480", VA = "0x1129E680")]
    private void OnOverItemAmount(long mailid, int period)
    {
    }

    [Token(Token = "0x600556E")]
    [Address(RVA = "0x129E540", Offset = "0x129D340", VA = "0x1129E540")]
    private void OnOverItemAmount(long[] mailids, int[] periods)
    {
    }

    [Token(Token = "0x600556F")]
    [Address(RVA = "0x129DE00", Offset = "0x129CC00", VA = "0x1129DE00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005570")]
    [Address(RVA = "0x129EBD0", Offset = "0x129D9D0", VA = "0x1129EBD0")]
    private void RefreshCurrentNums()
    {
    }

    [Token(Token = "0x6005571")]
    [Address(RVA = "0x129DAA0", Offset = "0x129C8A0", VA = "0x1129DAA0")]
    private void AddCurrentNum(MailData mailData)
    {
    }

    [Token(Token = "0x6005572")]
    [Address(RVA = "0x129DCC0", Offset = "0x129CAC0", VA = "0x1129DCC0")]
    private bool CheckRecievable(MailData mailData) => new bool();

    [Token(Token = "0x6005573")]
    [Address(RVA = "0x129DA50", Offset = "0x129C850", VA = "0x1129DA50")]
    private void Success()
    {
    }

    [Token(Token = "0x6005574")]
    [Address(RVA = "0x129E840", Offset = "0x129D640", VA = "0x1129E840", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005575")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ReadMail()
    {
    }

    [Token(Token = "0x2001471")]
    private enum RecieveStatus
    {
      [Token(Token = "0x4004B98")] Recieve,
      [Token(Token = "0x4004B99")] NotRecieveAll,
      [Token(Token = "0x4004B9A")] NotRecieveSome,
    }
  }
}
