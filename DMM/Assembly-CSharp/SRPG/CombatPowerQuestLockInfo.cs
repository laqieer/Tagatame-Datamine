// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerQuestLockInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021B0")]
  [FlowNode.Pin(1, "エリアロック表示", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/CombatPowerQuestLockInfo")]
  [FlowNode.Pin(2, "クエストロック表示", FlowNode.PinTypes.Input, 2)]
  public class CombatPowerQuestLockInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400938D")]
    private const int PIN_INPUT_AREA_LOCK = 1;
    [Token(Token = "0x400938E")]
    private const int PIN_INPUT_QUEST_LOCK = 2;
    [Token(Token = "0x400938F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x4009390")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text NeedCombatPowerText;
    [Token(Token = "0x4009391")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text ConditionsText;
    [Token(Token = "0x4009392")]
    [FieldOffset(Offset = "0x18")]
    private ChapterParam mChapter;
    [Token(Token = "0x4009393")]
    [FieldOffset(Offset = "0x1C")]
    private QuestParam mQuest;
    [Token(Token = "0x4009394")]
    [FieldOffset(Offset = "0x20")]
    private CombatPowerQuestParam mParam;

    [Token(Token = "0x6008DD5")]
    [Address(RVA = "0x5130A0", Offset = "0x511EA0", VA = "0x105130A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008DD6")]
    [Address(RVA = "0x514240", Offset = "0x513040", VA = "0x10514240")]
    private void RefreshArea()
    {
    }

    [Token(Token = "0x6008DD7")]
    [Address(RVA = "0x5143F0", Offset = "0x5131F0", VA = "0x105143F0")]
    private void RefreshQuest()
    {
    }

    [Token(Token = "0x6008DD8")]
    [Address(RVA = "0x513A30", Offset = "0x512830", VA = "0x10513A30")]
    private void DisplayNeedText()
    {
    }

    [Token(Token = "0x6008DD9")]
    [Address(RVA = "0x5130D0", Offset = "0x511ED0", VA = "0x105130D0")]
    private void DisplayConditions()
    {
    }

    [Token(Token = "0x6008DDA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CombatPowerQuestLockInfo()
    {
    }
  }
}
