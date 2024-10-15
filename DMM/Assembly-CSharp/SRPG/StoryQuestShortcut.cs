// Decompiled with JetBrains decompiler
// Type: SRPG.StoryQuestShortcut
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B09")]
  [FlowNode.Pin(100, "イベントページへ", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "ノーマルクエスト", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "キークエスト", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "塔クエスト", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/StoryQuestShortcut")]
  public class StoryQuestShortcut : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D208")]
    [FieldOffset(Offset = "0xC")]
    public Button EventQuestButton;
    [Token(Token = "0x400D209")]
    [FieldOffset(Offset = "0x10")]
    public Button KeyQuestButton;
    [Token(Token = "0x400D20A")]
    [FieldOffset(Offset = "0x14")]
    public Button TowerQuestButton;
    [Token(Token = "0x400D20B")]
    [FieldOffset(Offset = "0x18")]
    public GameObject KeyQuestOpenEffect;

    [Token(Token = "0x600C4FA")]
    [Address(RVA = "0x8D94C0", Offset = "0x8D82C0", VA = "0x108D94C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C4FB")]
    [Address(RVA = "0x8D91C0", Offset = "0x8D7FC0", VA = "0x108D91C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C4FC")]
    [Address(RVA = "0x8D92E0", Offset = "0x8D80E0", VA = "0x108D92E0")]
    public bool IsOpendTower() => new bool();

    [Token(Token = "0x600C4FD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryQuestShortcut()
    {
    }
  }
}
