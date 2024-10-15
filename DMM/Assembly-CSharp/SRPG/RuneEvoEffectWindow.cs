// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEvoEffectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A2")]
  [FlowNode.Pin(10, "ゲージ増加アニメ再生", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "自身を閉じる", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("UI/Rune/RuneEvoEffectWindow")]
  public class RuneEvoEffectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C98A")]
    private const int INPUT_START_GAUGE_ANIM = 10;
    [Token(Token = "0x400C98B")]
    private const int INPUT_CLOSE_WINDOW = 100;
    [Token(Token = "0x400C98C")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C98D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneIcon mRuneIconBfore;
    [Token(Token = "0x400C98E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneIcon mRuneIconAfter;
    [Token(Token = "0x400C98F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEvoStateOneSetting mOneSetting;
    [Token(Token = "0x400C990")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mCloseButton;
    [Token(Token = "0x400C991")]
    [FieldOffset(Offset = "0x1C")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C992")]
    [FieldOffset(Offset = "0x20")]
    private BindRuneData mCurrRuneData;

    [Token(Token = "0x600BCE8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BCE9")]
    [Address(RVA = "0x848E40", Offset = "0x847C40", VA = "0x10848E40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BCEA")]
    [Address(RVA = "0x849000", Offset = "0x847E00", VA = "0x10849000")]
    public void Setup(RuneManager manager, BindRuneData before_rune, BindRuneData after_rune)
    {
    }

    [Token(Token = "0x600BCEB")]
    [Address(RVA = "0x848F10", Offset = "0x847D10", VA = "0x10848F10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BCEC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneEvoEffectWindow()
    {
    }
  }
}
