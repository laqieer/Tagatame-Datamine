// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200284A")]
  [FlowNode.Pin(1, "バッジ更新", FlowNode.PinTypes.Input, 1)]
  public class PointQuestRewardBadge : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C042")]
    private const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400C043")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private PointQuestRewardBadge.BadgeStyleType BadgeStyle;

    [Token(Token = "0x600B5DC")]
    [Address(RVA = "0x7C05F0", Offset = "0x7BF3F0", VA = "0x107C05F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B5DD")]
    [Address(RVA = "0x7C07E0", Offset = "0x7BF5E0", VA = "0x107C07E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B5DE")]
    [Address(RVA = "0x7C0790", Offset = "0x7BF590", VA = "0x107C0790")]
    private bool IsReward() => new bool();

    [Token(Token = "0x600B5DF")]
    [Address(RVA = "0x7C0690", Offset = "0x7BF490", VA = "0x107C0690")]
    private bool IsPersonReward() => new bool();

    [Token(Token = "0x600B5E0")]
    [Address(RVA = "0x7C0710", Offset = "0x7BF510", VA = "0x107C0710")]
    private bool IsPortReward() => new bool();

    [Token(Token = "0x600B5E1")]
    [Address(RVA = "0x7640B0", Offset = "0x762EB0", VA = "0x107640B0")]
    public PointQuestRewardBadge()
    {
    }

    [Token(Token = "0x200284B")]
    private enum BadgeStyleType
    {
      [Token(Token = "0x400C045")] PERSON,
      [Token(Token = "0x400C046")] PORT,
      [Token(Token = "0x400C047")] ALL,
    }
  }
}
