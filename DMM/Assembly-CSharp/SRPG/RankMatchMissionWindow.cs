// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchMissionWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200291F")]
  [FlowNode.Pin(10, "Receive", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/RankMatchMissionWindow")]
  public class RankMatchMissionWindow : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400C607")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankMatchMissionItem ListItem;
    [Token(Token = "0x400C608")]
    [FieldOffset(Offset = "0x24")]
    private RankMatchMissionWindow.APIType mAPIType;

    [Token(Token = "0x600BA15")]
    [Address(RVA = "0x811D50", Offset = "0x810B50", VA = "0x10811D50", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600BA16")]
    [Address(RVA = "0x811380", Offset = "0x810180", VA = "0x10811380", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA17")]
    [Address(RVA = "0x8113A0", Offset = "0x8101A0", VA = "0x108113A0")]
    public void ReceiveReward(VersusRankMissionParam mission)
    {
    }

    [Token(Token = "0x600BA18")]
    [Address(RVA = "0x8115F0", Offset = "0x8103F0", VA = "0x108115F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BA19")]
    [Address(RVA = "0x811710", Offset = "0x810510", VA = "0x10811710")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600BA1A")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchMissionWindow()
    {
    }

    [Token(Token = "0x2002920")]
    private enum APIType
    {
      [Token(Token = "0x400C60A")] MISSION,
      [Token(Token = "0x400C60B")] MISSION_EXEC,
    }
  }
}
