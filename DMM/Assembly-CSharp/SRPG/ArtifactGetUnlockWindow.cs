// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactGetUnlockWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FFC")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Unlock", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "Selected Quest", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(500, "武具詳細情報セット(in)", FlowNode.PinTypes.Input, 500)]
  [FlowNode.Pin(501, "武具詳細情報セット(out)", FlowNode.PinTypes.Output, 501)]
  [AddComponentMenu("UI/ArtifactGetUnlockWindow")]
  public class ArtifactGetUnlockWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008843")]
    private const int INPUT_REFRESH = 1;
    [Token(Token = "0x4008844")]
    private const int INPUT_UNLOCK = 100;
    [Token(Token = "0x4008845")]
    private const int INPUT_SELECT_QUEST = 101;
    [Token(Token = "0x4008846")]
    private const int INPUT_ARTIFACT_DETAIL_SET = 500;
    [Token(Token = "0x4008847")]
    private const int OUTPUT_ARTIFACT_DETAIL_SET = 501;
    [Token(Token = "0x4008848")]
    [FieldOffset(Offset = "0xC")]
    private ArtifactData UnlockArtifact;
    [Token(Token = "0x4008849")]
    [FieldOffset(Offset = "0x10")]
    public StatusList ArtifactStatus;
    [Token(Token = "0x400884A")]
    [FieldOffset(Offset = "0x14")]
    public GameObject AbilityListItem;
    [Token(Token = "0x400884B")]
    [FieldOffset(Offset = "0x18")]
    public float ability_unlock_alpha;
    [Token(Token = "0x400884C")]
    [FieldOffset(Offset = "0x1C")]
    public float ability_hidden_alpha;
    [Token(Token = "0x400884D")]
    [FieldOffset(Offset = "0x20")]
    public GameObject lock_object;
    [Token(Token = "0x400884E")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼セット効果確認用のボタン")]
    [SerializeField]
    private Button m_SetEffectsButton;

    [Token(Token = "0x600841F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008420")]
    [Address(RVA = "0x44AEB0", Offset = "0x449CB0", VA = "0x1044AEB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008421")]
    [Address(RVA = "0x44AF40", Offset = "0x449D40", VA = "0x1044AF40")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008422")]
    [Address(RVA = "0x44B5F0", Offset = "0x44A3F0", VA = "0x1044B5F0")]
    private void SetArtifactDetailData()
    {
    }

    [Token(Token = "0x6008423")]
    [Address(RVA = "0x44B570", Offset = "0x44A370", VA = "0x1044B570")]
    public void SetArtifactData()
    {
    }

    [Token(Token = "0x6008424")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactGetUnlockWindow()
    {
    }
  }
}
