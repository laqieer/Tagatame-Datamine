// Decompiled with JetBrains decompiler
// Type: SRPG.RecommendTeamWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200293B")]
  [FlowNode.Pin(0, "設定保存", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "保存完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "保存完了(念装自動装備ON)", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/RecommendTeamWindow")]
  public class RecommendTeamWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C69F")]
    private const int INPUT_SAVE_CHANGES = 0;
    [Token(Token = "0x400C6A0")]
    private const int OUTPUT_SAVE_CHANGES = 100;
    [Token(Token = "0x400C6A1")]
    private const int OUTPUT_SAVE_CHANGES_WITH_CARD_EQIUP = 101;
    [Token(Token = "0x400C6A2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ScrollablePulldown TypePullDown;
    [Token(Token = "0x400C6A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ElementDropdown ElemmentPullDown;
    [Token(Token = "0x400C6A4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle SelectAutoEquipConceptCard;
    [Token(Token = "0x400C6A5")]
    [FieldOffset(Offset = "0x18")]
    private readonly RecommendTeamWindow.TypeAndStr[] items;
    [Token(Token = "0x400C6A6")]
    [FieldOffset(Offset = "0x1C")]
    private readonly RecommendTeamWindow.ElemAndStr[] elements;
    [Token(Token = "0x400C6A7")]
    [FieldOffset(Offset = "0x20")]
    private int currentTypeIndex;
    [Token(Token = "0x400C6A8")]
    [FieldOffset(Offset = "0x24")]
    private int currentElemmentIndex;

    [Token(Token = "0x600BA80")]
    [Address(RVA = "0x81E870", Offset = "0x81D670", VA = "0x1081E870", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA81")]
    [Address(RVA = "0x81E890", Offset = "0x81D690", VA = "0x1081E890")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BA82")]
    [Address(RVA = "0x81EB70", Offset = "0x81D970", VA = "0x1081EB70")]
    private void OnTypeItemSelect(int value)
    {
    }

    [Token(Token = "0x600BA83")]
    [Address(RVA = "0x81EB50", Offset = "0x81D950", VA = "0x1081EB50")]
    private void OnElemmentItemSelect(int value)
    {
    }

    [Token(Token = "0x600BA84")]
    [Address(RVA = "0x81EC00", Offset = "0x81DA00", VA = "0x1081EC00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BA85")]
    [Address(RVA = "0x81EE80", Offset = "0x81DC80", VA = "0x1081EE80")]
    private void SaveSettings()
    {
    }

    [Token(Token = "0x600BA86")]
    [Address(RVA = "0x81EAF0", Offset = "0x81D8F0", VA = "0x1081EAF0")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600BA87")]
    [Address(RVA = "0x81EBA0", Offset = "0x81D9A0", VA = "0x1081EBA0")]
    private void OnValueChange(bool value)
    {
    }

    [Token(Token = "0x600BA88")]
    [Address(RVA = "0x81F0E0", Offset = "0x81DEE0", VA = "0x1081F0E0")]
    public RecommendTeamWindow()
    {
    }

    [Token(Token = "0x200293C")]
    private struct TypeAndStr
    {
      [Token(Token = "0x400C6A9")]
      [FieldOffset(Offset = "0x0")]
      public readonly GlobalVars.RecommendType type;
      [Token(Token = "0x400C6AA")]
      [FieldOffset(Offset = "0x4")]
      public readonly string title;

      [Token(Token = "0x600BA89")]
      [Address(RVA = "0x828E50", Offset = "0x827C50", VA = "0x10828E50")]
      public TypeAndStr(GlobalVars.RecommendType type, string title)
      {
      }
    }

    [Token(Token = "0x200293D")]
    private struct ElemAndStr
    {
      [Token(Token = "0x400C6AB")]
      [FieldOffset(Offset = "0x0")]
      public readonly EElement element;
      [Token(Token = "0x400C6AC")]
      [FieldOffset(Offset = "0x4")]
      public readonly string title;

      [Token(Token = "0x600BA8A")]
      [Address(RVA = "0x2EC6D0", Offset = "0x2EB4D0", VA = "0x102EC6D0")]
      public ElemAndStr(EElement element, string title)
      {
      }
    }
  }
}
