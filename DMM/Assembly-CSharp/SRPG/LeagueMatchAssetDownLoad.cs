// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchAssetDownLoad
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002676")]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchAssetDownLoad")]
  [FlowNode.Pin(101, "終了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "アセットDL確認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("UI/LeagueMatch/LeagueMatchAssetDownLoad", 32741)]
  public class LeagueMatchAssetDownLoad : FlowNode
  {
    [Token(Token = "0x400B3B3")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B3B4")]
    private const int PIN_OUT_FIN = 101;
    [Token(Token = "0x400B3B5")]
    [FieldOffset(Offset = "0x18")]
    public SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B3B6")]
    [FieldOffset(Offset = "0x1C")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400B3B7")]
    [FieldOffset(Offset = "0x20")]
    private List<UnitData> mUnitDatas;

    [Token(Token = "0x600ABAD")]
    [Address(RVA = "0x6EC520", Offset = "0x6EB320", VA = "0x106EC520", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600ABAE")]
    [Address(RVA = "0x6EC090", Offset = "0x6EAE90", VA = "0x106EC090")]
    private void DownloadAssets()
    {
    }

    [Token(Token = "0x600ABAF")]
    [Address(RVA = "0x6EC020", Offset = "0x6EAE20", VA = "0x106EC020")]
    private IEnumerator DownloadAssetDatas() => (IEnumerator) null;

    [Token(Token = "0x600ABB0")]
    [Address(RVA = "0x6EBFB0", Offset = "0x6EADB0", VA = "0x106EBFB0")]
    private IEnumerator ConfirmDownloadAsync(Action onDownloadPopTimeout) => (IEnumerator) null;

    [Token(Token = "0x600ABB1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public LeagueMatchAssetDownLoad()
    {
    }
  }
}
