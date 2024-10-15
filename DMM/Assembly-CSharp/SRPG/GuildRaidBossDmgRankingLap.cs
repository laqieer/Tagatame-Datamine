// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBossDmgRankingLap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002571")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidBossDmgRankingLap")]
  [FlowNode.Pin(100, "ダメージランキング読み込み", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "画面更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "リスト追加読み込み", FlowNode.PinTypes.Output, 101)]
  public class GuildRaidBossDmgRankingLap : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ACF6")]
    private const int PIN_INPUT_REFRESH = 10;
    [Token(Token = "0x400ACF7")]
    private const int PIN_OUTPUT_DETAIL = 100;
    [Token(Token = "0x400ACF8")]
    private const int PIN_OUTPUT_REQLAPLIST = 101;
    [Token(Token = "0x400ACF9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mBossTemplate;
    [Token(Token = "0x400ACFA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mLapTemplate;
    [Token(Token = "0x400ACFB")]
    [FieldOffset(Offset = "0x14")]
    private GameObject mSelectTab;
    [Token(Token = "0x400ACFC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x400ACFD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RectTransform ScrollContent;
    [Token(Token = "0x400ACFE")]
    [FieldOffset(Offset = "0x20")]
    private bool IsLoading;
    [Token(Token = "0x400ACFF")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> mCreateList;

    [Token(Token = "0x600A5C7")]
    [Address(RVA = "0x67BD80", Offset = "0x67AB80", VA = "0x1067BD80")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A5C8")]
    [Address(RVA = "0x67C340", Offset = "0x67B140", VA = "0x1067C340")]
    private void Update()
    {
    }

    [Token(Token = "0x600A5C9")]
    [Address(RVA = "0x67BD60", Offset = "0x67AB60", VA = "0x1067BD60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5CA")]
    [Address(RVA = "0x67BE80", Offset = "0x67AC80", VA = "0x1067BE80")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A5CB")]
    [Address(RVA = "0x67BDC0", Offset = "0x67ABC0", VA = "0x1067BDC0")]
    public void OnDetail(GameObject go)
    {
    }

    [Token(Token = "0x600A5CC")]
    [Address(RVA = "0x67C4B0", Offset = "0x67B2B0", VA = "0x1067C4B0")]
    public GuildRaidBossDmgRankingLap()
    {
    }
  }
}
