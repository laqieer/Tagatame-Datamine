// Decompiled with JetBrains decompiler
// Type: SRPG.RaidGuildRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028DB")]
  [AddComponentMenu("UI/Raid/RaidGuildRankingWindow")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class RaidGuildRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C433")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C434")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mBeatItem;
    [Token(Token = "0x400C435")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mBeatParent;
    [Token(Token = "0x400C436")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mBeatSelf;
    [Token(Token = "0x400C437")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRescueItem;
    [Token(Token = "0x400C438")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mRescueParent;
    [Token(Token = "0x400C439")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRescueSelf;
    [Token(Token = "0x400C43A")]
    [FieldOffset(Offset = "0x0")]
    private static RaidGuildRankingWindow mInstance;
    [Token(Token = "0x400C43B")]
    [FieldOffset(Offset = "0x24")]
    private RaidRankingGuildList mRankingBeat;
    [Token(Token = "0x400C43C")]
    [FieldOffset(Offset = "0x28")]
    private RaidRankingGuildList mRankingRescue;
    [Token(Token = "0x400C43D")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> mBeatList;
    [Token(Token = "0x400C43E")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mRescueList;
    [Token(Token = "0x400C43F")]
    [FieldOffset(Offset = "0x34")]
    private GuildEmblemParam[] mEmblems;

    [Token(Token = "0x1700193B")]
    public static RaidGuildRankingWindow Instance
    {
      [Token(Token = "0x600B8B3"), Address(RVA = "0x7FBE60", Offset = "0x7FAC60", VA = "0x107FBE60")] get
      {
        return (RaidGuildRankingWindow) null;
      }
    }

    [Token(Token = "0x600B8B4")]
    [Address(RVA = "0x7FB740", Offset = "0x7FA540", VA = "0x107FB740")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B8B5")]
    [Address(RVA = "0x7FB6F0", Offset = "0x7FA4F0", VA = "0x107FB6F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B8B6")]
    [Address(RVA = "0x7FBCF0", Offset = "0x7FAAF0", VA = "0x107FBCF0")]
    public void Setup(ReqRaidRankingGuild.Response json)
    {
    }

    [Token(Token = "0x600B8B7")]
    [Address(RVA = "0x7FBCB0", Offset = "0x7FAAB0", VA = "0x107FBCB0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B8B8")]
    [Address(RVA = "0x7FB7F0", Offset = "0x7FA5F0", VA = "0x107FB7F0")]
    private void Init_List(
      RaidRankingGuildList rankingList,
      List<GameObject> currentList,
      GameObject item,
      Transform parent,
      GameObject self)
    {
    }

    [Token(Token = "0x600B8B9")]
    [Address(RVA = "0x7FBDC0", Offset = "0x7FABC0", VA = "0x107FBDC0")]
    public RaidGuildRankingWindow()
    {
    }
  }
}
