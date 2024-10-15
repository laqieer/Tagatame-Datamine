// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D4D")]
  [FlowNode.Pin(1, "ボス選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ボス設定完了", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("UI/WorldRaid/WorldRaidBossIcon")]
  public class WorldRaidBossIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E1C7")]
    private const int PIN_INPUT_SELECT = 1;
    [Token(Token = "0x400E1C8")]
    private const int PIN_OUTPUT_SELECT = 2;
    [Token(Token = "0x400E1C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BossChallenge;
    [Token(Token = "0x400E1CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject BossClear;
    [Token(Token = "0x400E1CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private PolyImage ChallengeBossIcon;
    [Token(Token = "0x400E1CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PolyImage ClearBossIcon;
    [Token(Token = "0x400E1CD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private BitmapText HpText;
    [Token(Token = "0x400E1CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image LifeImage;
    [Token(Token = "0x400E1CF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject BossLifeBgZero;
    [Token(Token = "0x400E1D0")]
    [FieldOffset(Offset = "0x28")]
    [Description("割合の低い方からリストに追加をお願いします")]
    [SerializeField]
    private List<GameObject> BossLifeBgList;
    [Token(Token = "0x400E1D1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Image BossElementIcon;
    [Token(Token = "0x400E1D2")]
    [FieldOffset(Offset = "0x30")]
    private WorldRaidBossChallengedData mBossData;
    [Token(Token = "0x400E1D3")]
    [FieldOffset(Offset = "0x34")]
    private int mBossIndex;

    [Token(Token = "0x600D30D")]
    [Address(RVA = "0x9E2720", Offset = "0x9E1520", VA = "0x109E2720", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D30E")]
    [Address(RVA = "0x9E2780", Offset = "0x9E1580", VA = "0x109E2780")]
    public void SetUp(WorldRaidBossChallengedData _data)
    {
    }

    [Token(Token = "0x600D30F")]
    [Address(RVA = "0x9E2750", Offset = "0x9E1550", VA = "0x109E2750")]
    private void SelectBoss()
    {
    }

    [Token(Token = "0x600D310")]
    [Address(RVA = "0x9E2F00", Offset = "0x9E1D00", VA = "0x109E2F00")]
    public WorldRaidBossIcon()
    {
    }
  }
}
