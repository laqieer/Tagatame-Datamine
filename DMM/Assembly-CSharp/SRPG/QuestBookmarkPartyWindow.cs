// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020E9")]
  [FlowNode.Pin(800, "一括スキップ", FlowNode.PinTypes.Output, 800)]
  [AddComponentMenu("UI/Bookmark/QuestBookmarkPartyWindow")]
  public class QuestBookmarkPartyWindow : PartyWindow2
  {
    [Token(Token = "0x4008E3A")]
    public const int PIN_OUTPUT_BULKSKIP = 800;

    [Token(Token = "0x6008970")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "6")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6008971")]
    [Address(RVA = "0x4B47E0", Offset = "0x4B35E0", VA = "0x104B47E0", Slot = "23")]
    protected override void PostForwardPressed()
    {
    }

    [Token(Token = "0x6008972")]
    [Address(RVA = "0x439930", Offset = "0x438730", VA = "0x10439930")]
    public QuestBookmarkPartyWindow()
    {
    }
  }
}
