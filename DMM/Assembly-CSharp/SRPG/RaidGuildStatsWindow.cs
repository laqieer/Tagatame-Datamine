// Decompiled with JetBrains decompiler
// Type: SRPG.RaidGuildStatsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028DE")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Raid/RaidGuildStatsWindow")]
  public class RaidGuildStatsWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C443")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C444")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mListItem;
    [Token(Token = "0x400C445")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mListParent;
    [Token(Token = "0x400C446")]
    [FieldOffset(Offset = "0x0")]
    private static RaidGuildStatsWindow mInstance;
    [Token(Token = "0x400C447")]
    [FieldOffset(Offset = "0x14")]
    private RaidGuildInfo mRaidGuildInfo;
    [Token(Token = "0x400C448")]
    [FieldOffset(Offset = "0x18")]
    private List<RaidGuildMemberData> mRaidGuildMemberList;

    [Token(Token = "0x1700193C")]
    public static RaidGuildStatsWindow Instance
    {
      [Token(Token = "0x600B8BE"), Address(RVA = "0x7FC370", Offset = "0x7FB170", VA = "0x107FC370")] get
      {
        return (RaidGuildStatsWindow) null;
      }
    }

    [Token(Token = "0x600B8BF")]
    [Address(RVA = "0x7FBEB0", Offset = "0x7FACB0", VA = "0x107FBEB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B8C0")]
    [Address(RVA = "0x7FBE90", Offset = "0x7FAC90", VA = "0x107FBE90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B8C1")]
    [Address(RVA = "0x7FC1F0", Offset = "0x7FAFF0", VA = "0x107FC1F0")]
    public void Setup(ReqRaidGuildStats.Response json)
    {
    }

    [Token(Token = "0x600B8C2")]
    [Address(RVA = "0x7FBF10", Offset = "0x7FAD10", VA = "0x107FBF10")]
    private void Init()
    {
    }

    [Token(Token = "0x600B8C3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidGuildStatsWindow()
    {
    }
  }
}
