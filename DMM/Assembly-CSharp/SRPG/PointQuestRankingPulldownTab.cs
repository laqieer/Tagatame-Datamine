// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingPulldownTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200282F")]
  public class PointQuestRankingPulldownTab : GuildTrainingPullDown
  {
    [Token(Token = "0x400BF89")]
    [FieldOffset(Offset = "0xF8")]
    [HeaderBar("▼テキストスクロールの設定")]
    [SerializeField]
    private bool IsOpenResetScrollText;
    [Token(Token = "0x400BF8A")]
    [FieldOffset(Offset = "0xFC")]
    private List<PointQuestRankingTabModel> mModels;

    [Token(Token = "0x600B55D")]
    [Address(RVA = "0x7BC7C0", Offset = "0x7BB5C0", VA = "0x107BC7C0")]
    public PointQuestRankingTabModel GetTabModel() => (PointQuestRankingTabModel) null;

    [Token(Token = "0x600B55E")]
    [Address(RVA = "0x7BCA80", Offset = "0x7BB880", VA = "0x107BCA80")]
    public void SetData(List<PointQuestRankingTabModel> models)
    {
    }

    [Token(Token = "0x600B55F")]
    [Address(RVA = "0x7BC810", Offset = "0x7BB610", VA = "0x107BC810", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B560")]
    [Address(RVA = "0x7BC860", Offset = "0x7BB660", VA = "0x107BC860")]
    public void ResetScrollText()
    {
    }

    [Token(Token = "0x600B561")]
    [Address(RVA = "0x7BCB20", Offset = "0x7BB920", VA = "0x107BCB20")]
    public PointQuestRankingPulldownTab()
    {
    }
  }
}
